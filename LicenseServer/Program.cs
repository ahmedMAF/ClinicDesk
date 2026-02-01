using Portable.Licensing;
using System.Text;

namespace LicenseServer;

public partial class Program
{
    private static readonly string PrivateKey = "MIICITAjBgoqhkiG9w0BDAEDMBUEEHPGyZC2vzwNI3yprz0x7+YCAQoEggH4HkRBKLJY14CpwjkDucXxK72Eh8eWWGHQy2xdxTaFxBq91xFIyOO+F93B2HfYFo0i7f5bIcDBxQqmdYpdGFRqfkYRb8GDy2ief/30Tf+/6B807xMn2wqQZvaVuDkzPm9IRsQY9Ty/bpWG/bN0Nb827/siZRAInzNYNRp18d+w7miTUQ3C5DCNncv6C3CQ6QLYtVge/Vw3fHMaUomkI67bH0PcnUAxbR5+b4cQio0axKt0rjxNMSP9spz+7bPd1L8yzlGJk40AKrEydyO5vzzIIUhEI/TQzmh+bk/NlkdUmynjh076YKekiHPHcTSV6+eEMJEMdU9PFKLo0mqbicc3APE2DB0f0UTbTeLFLwouEZsKhacXZQRGGz7+zZniiYG+NFzjDqiCB4IdgSJqNYJtKnjRX/NsAxiNWJIl6jiq7w2ZqJ21n/ZHBdFowwS80ONIg4rPEp9Sa4A35N9Pd1PzC/PXw5b9WRPdt3PTRzKKIRLcJrtA3Rx27o6vR0zQM9b1UJetXRn89vczffd/OR2VycAR69kwARUgG6IZ5IVO5V5hPPcafW7DGKgsMNfiqQ7nC7500ktiuNDxycfBlqrvQSkw3exUUyiLTywfkP2Y4gHo23FPhiab3Quag08eKmJKRH+xX5gh4j4qQz7z0xl0jF6Fqv9YH4dT";

    private static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        builder.WebHost.UseUrls("http://0.0.0.0:80");
        builder.Services.AddOpenApi();

        WebApplication app = builder.Build();

        if (app.Environment.IsDevelopment())
            app.MapOpenApi();

        app.MapGet("/api/status", () => "Running...").WithName("Status");
        app.MapPost("/api/getlicense", GetLicensePostAsync).WithName("GetLicense");
        app.MapPost("/api/gettrailer", GetTrailerPostAsync).WithName("GetTrailer");

        app.Run();
    }
    
    private static async Task GetLicensePostAsync(HttpRequest request, HttpResponse response)
    {
        string license = await GetLicense(request, DateTime.UtcNow.AddYears(1), false);
        await SendLicense(license, response);
    }
    
    private static async Task GetTrailerPostAsync(HttpRequest request, HttpResponse response)
    {
        string license = await GetLicense(request, DateTime.UtcNow.AddDays(30), true);
        await SendLicense(license, response);
    }
    
    private static async Task<string> GetLicense(HttpRequest request, DateTime date, bool isTrailer)
    {
        LicenseRequest? licenseRequest = await request.ReadFromJsonAsync<LicenseRequest>();

        if (licenseRequest == null || string.IsNullOrWhiteSpace(licenseRequest.Name) || string.IsNullOrWhiteSpace(licenseRequest.Email))
        {
            return "";
        }

        Console.WriteLine($"Requesting license for: {licenseRequest.Name}, {licenseRequest.Email}");

        if (!ValidateHardwareId(licenseRequest.HardwareId))
        {
            return "";
        }

        string license = License.New()
            .WithUniqueIdentifier(Guid.NewGuid())
            .As(LicenseType.Standard)
            .ExpiresAt(date)
            .WithMaximumUtilization(1)
            .WithAdditionalAttributes(new Dictionary<string, string>
            {{ "HardwareId", licenseRequest.HardwareId.ToString() }})
            .LicensedTo(licenseRequest.Name, licenseRequest.Email)
            .CreateAndSignWithPrivateKey(PrivateKey, "")
            .ToString();

        Console.WriteLine("License file generated.");
        return license;
    }
    
    private static async Task SendLicense(string license, HttpResponse response)
    {
        response.ContentType = "text/plain";

        if (string.IsNullOrWhiteSpace(license))
        {
            response.StatusCode = 400;
            await response.WriteAsync("Invalid request");
            return;
        }

        response.StatusCode = 200;
        await response.WriteAsync(license);

        Console.WriteLine($"Response sent. {Encoding.UTF8.GetByteCount(license)} bytes.");
    }
    
    private static bool ValidateHardwareId(string id)
    {
        // Add your validation logic here
        return !string.IsNullOrWhiteSpace(id);
    }
}
