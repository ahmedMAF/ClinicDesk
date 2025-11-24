using Microsoft.EntityFrameworkCore;
using QliniqRec.Database.Models;

namespace QliniqRec.Database;

public class ClinicDb : DbContext
{
    private string _conn = null!;

    public static ClinicDb Instance { get; private set; } = null!;

    public DbSet<Patient> Patients { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Visit> Visits { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<Payment> Payments { get; set; }

    internal static void Initialize(string conn)
    {
        Instance = new ClinicDb
        {
            _conn = conn
        };
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseMySql(_conn, ServerVersion.AutoDetect(_conn));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Patient>()
            .Property(p => p.ChronicDiseases)
            .HasColumnType("json");
    }
}
