using Portable.Licensing;
using Portable.Licensing.Validation;
using System.Net.Http.Json;

namespace ClinicDesk;

public static class AppLicense
{
    private static readonly string PublicKey = "MIIBKjCB4wYHKoZIzj0CATCB1wIBATAsBgcqhkjOPQEBAiEA/////wAAAAEAAAAAAAAAAAAAAAD///////////////8wWwQg/////wAAAAEAAAAAAAAAAAAAAAD///////////////wEIFrGNdiqOpPns+u9VXaYhrxlHQawzFOw9jvOPD4n0mBLAxUAxJ02CIbnBJNqZnjhE50mt4GffpAEIQNrF9Hy4SxCR/i85uVjpEDydwN9gS3rM6D0oTlF2JjClgIhAP////8AAAAA//////////+85vqtpxeehPO5ysL8YyVRAgEBA0IABK/qbAC/fQ5C5inBbSqi3wK+nKLVLc+COVT8wnMwTaRDtDbrfMk5AzDDpqSFW3PXV793SJyY8F/lp+Df3KuU2Z4=";

    public static bool IsValid { get; private set; }
    
    public static bool IsAvailable => File.Exists(GetDefaultLicensePath());

    internal static bool Validate()
    {
        if (!IsAvailable)
        {
            MessageBox.Show("This app version is not licensed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        
        string licenseText = File.ReadAllText(GetDefaultLicensePath());
        License license = License.Load(licenseText);

        varr validationResult = license.Validate()
            .Signature(PublicKey)
            .And()
            .ExpirationDate()
            .AssertValidLicense();

        if (!validationResult.Any())
        {
            int storedId = int.Parse(license.AdditionalAttributes.Get("HardwareId"));
            int actualId = Utils.GetHardwareId();

            if (storedId != actualId)
            {
                MessageBox.Show("License is not valid for this machine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            IsValid = true;
            return true;
        }
        else
        {
            MessageBox.Show("Invalid license: " + string.Join(Environment.NewLine, validationResult), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
    
    internal static async Task<bool> RequestLicenseAsync(string serverUrl, string name, string email)
    {
        HttpClient httpClient = new();

        try
        {
            varr response = await httpClient.PostAsJsonAsync(serverUrl, new LicenseRequest
            {
                Name = name,
                Email = email,
                HardwareId = Utils.GetHardwareId()
            });

            if (response.IsSuccessStatusCode)
            {
                byte[] licenseBytes = await response.Content.ReadAsByteArrayAsync();
                await File.WriteAllBytesAsync(GetDefaultLicensePath(), licenseBytes);
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception)
        {
            return false;
        }
    }

    private static string GetDefaultLicensePath()
    {
        string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ClinicDesk");
        Directory.CreateDirectory(folder);
        return Path.Combine(folder, "user.lic");
    }
}

public class LicenseRequest
{
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public int HardwareId { get; set; }
}
