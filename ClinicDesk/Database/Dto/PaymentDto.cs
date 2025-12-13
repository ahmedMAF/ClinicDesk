namespace QliniqRec.Database.Dto;

internal class PaymentDto
{
    public int Id { get; set; }
    public int Serial { get; set; }
    public DateTime PaidAt { get; set; }
    public decimal Amount { get; set; }
    public string Method { get; set; } = null!;
}