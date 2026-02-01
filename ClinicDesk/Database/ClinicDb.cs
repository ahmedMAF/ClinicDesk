using ClinicDesk.Database.Models;
using ClinicDesk.Net;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Diagnostics;
using System.Text.Json;
using System.Threading.Tasks;
#if !DEBUG
using System.ServiceProcess;
#endif

namespace ClinicDesk.Database;

public class ClinicDb : DbContext
{
#if !DEBUG
    private const string ServiceName = "MySQL80";
#else
    private static Process? _mySqlProcess;
#endif

    private static bool _wasMySqlRunning;

    private static Server? _server;

    public static ClinicDb Instance { get; private set; } = null!;
    public static bool IsRunning { get; private set; }

    public static Client? Client { get; private set; }

    public DbSet<Patient> Patients { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Visit> Visits { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<Payment> Payments { get; set; }

    internal ClinicDb(DbContextOptions<ClinicDb> options) : base(options)
    {
        if (Settings.Instance.IsServer)
            Database.Migrate();

        IsRunning = true;
    }

    internal static async Task Initialize()
    {
        DialogResult result;

        do
        {
            bool success = Create(out ClinicDb? db);

            if (success)
            {
                result = DialogResult.OK;
                Instance = db!;
            }
            else
                result = MessageBox.Show("Can't connect to database server.", "Database Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
        while (result == DialogResult.Retry);


        if (Settings.Instance.AccountType == AccountType.AllInOne)
            return;

        if (Settings.Instance.IsServer)
        {
            _server = new Server();
            _ = _server.StartAsync();
        }

        Client = new Client();
        await Client.StartAsync();
    }

    internal static bool TestConnection(string server, ushort port, string db, string user, string pass)
    {
        if (server is "localhost" or "127.0.0.1")
            RunDatabaseService();

        return Create($"Server={server};Port={port};Database={db};User={user};Password={pass};", out _);
    }

    internal static bool Create(out ClinicDb? db)
    {
        Settings settings = Settings.Instance;

        if (Settings.Instance.IsServer)
            RunDatabaseService();

        return Create($"Server={settings.Server};Port={settings.Port};Database={settings.Database};User={settings.User};Password={settings.Password};", out db);
    }

    internal static bool Create(string conn, out ClinicDb? db)
    {
        DbContextOptionsBuilder<ClinicDb> optionsBuilder = new();

        try
        {
            optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
            db = new ClinicDb(optionsBuilder.Options);

            return true;
        }
        catch
        {
            db = null;
            return false;
        }
    }
    
    private static void RunDatabaseService()
    {
#if DEBUG
        _wasMySqlRunning = Process.GetProcessesByName("mysqld").Length != 0;

        if (!_wasMySqlRunning)
        {
            string path = @"C:\xampp\mysql\bin\mysqld.exe";
            string iniPath = @"C:\xampp\mysql\bin\my.ini";

            if (!File.Exists(path))
            {
                path = @"C:\Program Files\xampp\mysql\bin\mysqld.exe";
                iniPath = @"C:\Program Files\xampp\mysql\bin\my.ini";
            }

            ProcessStartInfo psi = new()
            {
                FileName = path,
                Arguments = $"--defaults-file=\"{iniPath}\" --standalone",
                CreateNoWindow = true
            };

            _mySqlProcess = Process.Start(psi);
            Task.Delay(3000).Wait();
        }
#else
        ServiceController service = new(ServiceName);
        
        _wasMySqlRunning = service.Status == ServiceControllerStatus.Running;
        
        if (!_wasMySqlRunning)
        {
            service.Start();
            service.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10));
        }
#endif
    }

    public static void StopDatabaseService()
    {
        // We should not stop MySQL if it was running before we started.
        if (_wasMySqlRunning)
            return;
            
#if DEBUG
        if (_mySqlProcess != null && !_mySqlProcess.HasExited)
        {
            _mySqlProcess.Kill();
            _mySqlProcess.Dispose();
        }
#else
        ServiceController service = new(ServiceName);
        
        if (service.Status != ServiceControllerStatus.Stopped)
            service.Stop();
#endif
    }
    
    public static void AutoBackup()
    {
        Settings settings = Settings.Instance;

        if (!settings.IsServer || settings.NextBackup != DateTime.Now.Date)
            return;

        settings.LastBackup = DateTime.Now.Date;
        Settings.SaveSettings();
        Backup();
    }
    
    public static void Backup(string? path = null)
    {
        Settings settings = Settings.Instance;
        
        if (!settings.IsServer)
            return;
        
        string dumpFile = Path.Combine(path ?? settings.BackupPath, $"{settings.Database}_{DateTime.UtcNow:yyyyMMdd_HHmmss}.sql");
        
#if DEBUG
        string mySqlDumpPath = @"C:\xampp\mysql\bin\mysqldump.exe";
        
        if (!File.Exists(mySqlDumpPath))
            mySqlDumpPath = @"C:\Program Files\xampp\mysql\bin\mysqldump.exe";
#else
        string mySqlDumpPath = @"C:\Program Files\MySQL\MySQL Server 8.0\bin\mysqldump.exe";
#endif
    
        ProcessStartInfo psi = new()
        {
            FileName = mySqlDumpPath,
            Arguments = $"-u {settings.User} {settings.Database} -r \"{dumpFile}\"",
            RedirectStandardError = true,
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        // safe password passing.
        psi.Environment["MYSQL_PWD"] = settings.Password;

        using Process? process = Process.Start(psi);

        if (process == null)
            return;

        string errorOutput = process.StandardError.ReadToEnd();
        process.WaitForExit();

        if (process.ExitCode != 0)
        {
            MessageBox.Show($"Backup failed.{Environment.NewLine}Error: {errorOutput}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        MessageBox.Show($"Backup done successfully.", "backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        ValueConverter<List<Tooth>?, string> converter = new(
            v => JsonSerializer.Serialize(v),
            v => JsonSerializer.Deserialize<List<Tooth>>(v));

        modelBuilder.Entity<Patient>()
            .Property(p => p.Teeth)
            .HasConversion(converter);

        modelBuilder.Entity<Patient>()
            .Property(p => p.ChronicDiseases)
            .HasColumnType("json");
    }

    public override int SaveChanges()
    {
        int result = base.SaveChanges();
        _ = Client?.SendAsync();

        return result;
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        int result = await base.SaveChangesAsync(cancellationToken);

        if (Client != null)
            await Client.SendAsync();

        return result;
    }
}
