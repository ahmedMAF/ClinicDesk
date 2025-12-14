using ClinicDesk.Database.Models;

namespace ClinicDesk.Database.Dto;

internal class VisitDto
{
    public int Id { get; set; }
    public int Serial { get; set; }
    public DateTime CheckInAt { get; set; }
    public VisitType Type { get; set; }
    public string Diagnosis { get; set; } = null!;
    public string Treatment { get; set; } = null!;
    public int FollowUpsCount { get; set; }
}