using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicDesk.Database.Models;

public class Patient
{
    public int Id { get; set; }

    [Required, MaxLength(256)]
    public string Name { get; set; } = null!;
    public Sex Sex { get; set; }
    public MaritalStatus MaritalStatus { get; set; }
    public DateTime DateOfBirth { get; set; }

    public string? Phone { get; set; }

    public BloodType BloodType { get; set; }
    public List<string> ChronicDiseases { get; set; } = [];
    public List<Tooth> Teeth { get; set; } = [];
    public string? Notes { get; set; }

    public List<Appointment> Appointments { get; set; } = [];
    public List<Visit> Visits { get; set; } = [];

    [NotMapped]
    public TimeSpan Age => DateTime.Now - DateOfBirth;
}
