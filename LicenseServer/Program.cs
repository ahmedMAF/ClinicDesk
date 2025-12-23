using Portable.Licensing;

namespace LicenseServer;

public partial class Program
{
    private static readonly string PrivateKey = "MIICITAjBgoqhkiG9w0BDAEDMBUEEHPGyZC2vzwNI3yprz0x7+YCAQoEggH4HkRBKLJY14CpwjkDucXxK72Eh8eWWGHQy2xdxTaFxBq91xFIyOO+F93B2HfYFo0i7f5bIcDBxQqmdYpdGFRqfkYRb8GDy2ief/30Tf+/6B807xMn2wqQZvaVuDkzPm9IRsQY9Ty/bpWG/bN0Nb827/siZRAInzNYNRp18d+w7miTUQ3C5DCNncv6C3CQ6QLYtVge/Vw3fHMaUomkI67bH0PcnUAxbR5+b4cQio0axKt0rjxNMSP9spz+7bPd1L8yzlGJk40AKrEydyO5vzzIIUhEI/TQzmh+bk/NlkdUmynjh076YKekiHPHcTSV6+eEMJEMdU9PFKLo0mqbicc3APE2DB0f0UTbTeLFLwouEZsKhacXZQRGGz7+zZniiYG+NFzjDqiCB4IdgSJqNYJtKnjRX/NsAxiNWJIl6jiq7w2ZqJ21n/ZHBdFowwS80ONIg4rPEp9Sa4A35N9Pd1PzC/PXw5b9WRPdt3PTRzKKIRLcJrtA3Rx27o6vR0zQM9b1UJetXRn89vczffd/OR2VycAR69kwARUgG6IZ5IVO5V5hPPcafW7DGKgsMNfiqQ7nC7500ktiuNDxycfBlqrvQSkw3exUUyiLTywfkP2Y4gHo23FPhiab3Quag08eKmJKRH+xX5gh4j4qQz7z0xl0jF6Fqv9YH4dT";

    private static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        builder.Services.AddOpenApi();

        WebApplication app = builder.Build();

        if (app.Environment.IsDevelopment())
            app.MapOpenApi();

        app.MapGet("/api/status", () => "Running...").WithName("Status");
        app.MapPost("/api/getlicense", GetLicensePostAsync).WithName("GetLicense");

        app.Run();
    }

    private static async Task GetLicensePostAsync(HttpRequest request, HttpResponse response)
    {
        LicenseRequest? licenseRequest = await request.ReadFromJsonAsync<LicenseRequest>();

        if (licenseRequest == null || string.IsNullOrWhiteSpace(licenseRequest.HardwareId))
        {
            response.StatusCode = 400;
            await response.WriteAsync("Invalid request");
            return;
        }

        if (!ValidateHardwareId(licenseRequest.HardwareId))
        {
            response.StatusCode = 400;
            await response.WriteAsync("Invalid hardware ID");
            return;
        }

        string license = License.New()
            .WithUniqueIdentifier(Guid.NewGuid())
            .As(LicenseType.Standard)
            .ExpiresAt(DateTime.UtcNow.AddYears(1))
            .WithMaximumUtilization(1)
            .WithAdditionalAttributes(new Dictionary<string, string>
            {{ "HardwareId", licenseRequest.HardwareId }})
            .LicensedTo(licenseRequest.Name, licenseRequest.Email)
            .CreateAndSignWithPrivateKey(PrivateKey, passPhrase: null)
            .ToString();

        response.ContentType = "text/plain";
        await response.WriteAsync(license);
    }

    private static bool ValidateHardwareId(string id)
    {
        // Add your validation logic here
        return !string.IsNullOrWhiteSpace(id);
    }
}
