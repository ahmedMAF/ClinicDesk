using Microsoft.EntityFrameworkCore;
using QliniqRec.Database.Models;

namespace QliniqRec.Database;

public class ClinicDb : DbContext
{
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

        string conn = $"Server={settings.Server};Port={settings.Port};Database={settings.Database};User={settings.User};Password={settings.Password};";
        DbContextOptionsBuilder<ClinicDb> optionsBuilder = new();

        DialogResult result = default;

        do
        {
            try
            {
                optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
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
    }
}
