namespace QliniqRec.Database.Models;

public class Visit
{
    public int Id { get; set; }

    public int PatientId { get; set; }
    public Patient Patient { get; set; } = null!;

    public DateTime CheckInAt { get; set; } = DateTime.Now;

    public VisitType Type { get; set; }
    public string Diagnosis { get; set; } = null!;
    public string Treatment { get; set; } = null!;

    public int? OriginalVisitId { get; set; }
    public Visit? OriginalVisit { get; set; }
    public List<Visit> FollowUps { get; set; } = [];

    public Invoice Invoice { get; set; } = null!;
}
