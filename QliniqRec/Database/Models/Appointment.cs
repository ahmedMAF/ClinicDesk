namespace QliniqRec.Database.Models;

public class Appointment
{
    public int Id { get; set; }

    public int PatientId { get; set; }
    public Patient Patient { get; set; } = null!;
    
    public DateTime Date { get; set; }
    public AppointmentStatus Status { get; set; }
    public string? Notes { get; set; }

    public int? VisitId { get; set; }
    public Visit? Visit { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
}

public enum AppointmentStatus : byte
{
    Pending,
    Attended,
    Cancelled,
    Missed,
    Rescheduled
}