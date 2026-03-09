namespace ClinicDesk.Database.Models;

public class Invoice
{
    public int Id { get; set; }

    public int PatientId { get; set; }
    public Patient Patient { get; set; } = null!;

    public decimal TotalAmount { get; set; }
    public DateTime IssuedAt { get; set; } = DateTime.Now;

    public InvoiceStatus Status { get; set; }

    public List<Payment> Payments { get; set; } = [];
}
