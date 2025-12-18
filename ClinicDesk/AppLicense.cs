using Portable.Licensing;
using Portable.Licensing.Security.Cryptography;
using Portable.Licensing.Validation;

namespace ClinicDesk;

public static class AppLicense
{
    private static readonly string PublicKey = "MIIBKjCB4wYHKoZIzj0CATCB1wIBATAsBgcqhkjOPQEBAiEA/////wAAAAEAAAAAAAAAAAAAAAD///////////////8wWwQg/////wAAAAEAAAAAAAAAAAAAAAD///////////////wEIFrGNdiqOpPns+u9VXaYhrxlHQawzFOw9jvOPD4n0mBLAxUAxJ02CIbnBJNqZnjhE50mt4GffpAEIQNrF9Hy4SxCR/i85uVjpEDydwN9gS3rM6D0oTlF2JjClgIhAP////8AAAAA//////////+85vqtpxeehPO5ysL8YyVRAgEBA0IABK/qbAC/fQ5C5inBbSqi3wK+nKLVLc+COVT8wnMwTaRDtDbrfMk5AzDDpqSFW3PXV793SJyY8F/lp+Df3KuU2Z4=";
    
    public static bool IsValid { get; private set; }

    internal static bool Validate()
    {
        string licenseText = File.ReadAllText("license.lic");
        License license = License.Load(licenseText);
        
        var validationResult = license.Validate()
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
                MessageBox.Show("License is not valid for this machine.");
                return false;
            }
            
            IsValid = true;
            return true;
        }
        else
        {
            MessageBox.Show("Invalid license: " + string.Join("\n", validationResult));
            return false;
        }
    }
}
