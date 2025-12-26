using Microsoft.EntityFrameworkCore;
using ClinicDesk.Database.Models;
using System.ServiceProcess;
using System.Diagnostics;
using System.IO;

namespace ClinicDesk.Database;

public class ClinicDb : DbContext
{
    private const string ServiceName = "MySQL80";
    
    public static ClinicDb Instance { get; private set; } = null!;
    public static bool IsRunning { get; private set; }

    public DbSet<Patient> Patients { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Visit> Visits { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<Payment> Payments { get; set; }

    internal ClinicDb(DbContextOptions<ClinicDb> options) : base(options)
    {
        Database.Migrate();
        IsRunning = true;
    }

    internal static void Initialize()
    {
        Instance = Create();
    }

    internal static ClinicDb Create()
    {
        Settings settings = Settings.Instance;

        string conn = $"Server={settings.Server};Port={settings.Port};Database={settings.Database};User={settings.User};Password={settings.Password};SslMode=None;";
        DbContextOptionsBuilder<ClinicDb> optionsBuilder = new();

        DialogResult result = DialogResult.None;

        if (settings.IsServer)
            RunDatabaseService();

        do
        {
            try
            {
                optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
                result = DialogResult.OK;
            }
            catch (Exception ex)
            {
                result = MessageBox.Show($"Can't connect to MySQL. Is it running?{Environment.NewLine}Error: {ex.Message}", "Database Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if (result == DialogResult.Cancel)
                    return null!;
            }
        }
        while (result == DialogResult.Retry);

        return new ClinicDb(optionsBuilder.Options);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Patient>()
            .Property(p => p.ChronicDiseases)
            .HasColumnType("json");
            
       modelBuilder.Entity<Patient>()
            .Property(p => p.Teeth)
            .HasColumnType("json");
    }
    
    private static void RunDatabaseService()
    {
#if DEBUG
        bool isMySqlRunning = Process.GetProcessesByName("mysqld").Count != 0;

        if (!isMySqlRunning)
        {
            string path = @"C:\xampp\mysql\bin\mysqld.exe";
            
            if (!File.Exists(path))
                path = @"C:\Program Files\xampp\mysql\bin\mysqld.exe";
                
            Process.Start(path);
        }
#else
        ServiceController service = new(serviceName);
        
        if (service.Status != ServiceControllerStatus.Running)
        {
            service.Start();
            service.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10));
        }
#endif
    }
}
