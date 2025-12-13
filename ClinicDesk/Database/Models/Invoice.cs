namespace QliniqRec.Database.Models;

public class Invoice
{
    public int Id { get; set; }

    public int VisitId { get; set; }
    public Visit Visit { get; set; } = null!;

    public decimal TotalAmount { get; set; }
    public DateTime IssuedAt { get; set; } = DateTime.Now;

    public InvoiceStatus Status { get; set; }

    public List<Payment> Payments { get; set; } = [];
}
