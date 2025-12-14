using ClinicDesk.Database.Models;

namespace ClinicDesk.Database.Dto;

internal class PatientDto
{
    public int Id { get; set; }
    public int Serial { get; set; }
    public string Name { get; set; } = null!;
    public string Phone { get; set; } = null!;
}