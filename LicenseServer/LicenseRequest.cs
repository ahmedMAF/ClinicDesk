namespace LicenseServer;

public class LicenseRequest
{
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string HardwareId { get; set; } = null!;
}
