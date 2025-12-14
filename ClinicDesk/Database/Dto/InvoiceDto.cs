namespace ClinicDesk.Database.Dto;

internal class InvoiceDto
{
    public int Id { get; set; }
    public int Serial { get; set; }
    public DateTime IssuedAt { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal PaidAmount { get; set; }
    public decimal RemainingAmount { get; set; }
}