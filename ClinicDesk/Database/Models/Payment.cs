namespace QliniqRec.Database.Models;

public class Payment
{
    public int Id { get; set; }

    public int InvoiceId { get; set; }
    public Invoice Invoice { get; set; } = null!;

    public decimal Amount { get; set; }
    public string Method { get; set; } = "Cash";

    public DateTime PaidAt { get; set; } = DateTime.Now;
}
