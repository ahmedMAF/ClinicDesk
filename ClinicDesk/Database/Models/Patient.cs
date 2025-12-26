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
    public List<string> ChronicDiseases { get; set; } = null!;
    public List<Tooth[]> Teeth { get; set; } = null!;
    public string? Notes { get; set; }

    public List<Appointment> Appointments { get; set; } = null!;
    public List<Visit> Visits { get; set; } = null!;

    [NotMapped]
    public TimeSpan Age => DateTime.Now - DateOfBirth;
    
    public static Patient New()
    {
        Patient patient = new();
        
        patient.Teeth = [];
        
        for (int i = 0; i < 52; i++)
            patient.Teeth.Add(new Tooth());
            
        return patient;
    }
}
