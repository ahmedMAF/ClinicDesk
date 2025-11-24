namespace QliniqRec.Database.Models;

public class Visit
{
    public int Id { get; set; }

    public int PatientId { get; set; }
    public Patient Patient { get; set; } = null!;

    public DateTimeOffset CheckInAt { get; set; } // = DateTimeOffset.UtcNow;

    public VisitType Type { get; set; }
    public string Diagnosis { get; set; } = null!;
    public string Treatment { get; set; } = null!;

    public int? AppointmentId { get; set; }
    public Appointment? Appointment { get; set; }

    public Visit? OriginalVisit { get; set; }
    public List<Visit> FollowUps { get; set; } = [];

    public List<Invoice> Invoices { get; set; } = [];
}

public enum VisitType : byte
{
    FirstVisit,
    Followup
}
