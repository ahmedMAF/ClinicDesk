using ClinicDesk.Database.Models;

namespace ClinicDesk.Database.Dto;

internal class AppointmentDto
{
    public int Id { get; set; }
    public int Serial { get; set; }
    public int PatientId { get; set; }
    public string PatientName { get; set; } = "";
    public DateTime Time { get; set; }
    public string Phone { get; set; } = "";
    public AppointmentStatus Status { get; set; }
}
