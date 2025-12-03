using Portable.Licensing;
using Portable.Licensing.Validation;

namespace QliniqRec;

public static class AppLicense
{
    private const string PublicKey = "<Your RSA public key here>";
    
    public static bool IsValid { get; private set; }

    internal static void Validate()
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
            int actualId = Utils.GetHardwareId().GetHashCode();
            
            if (storedId != actualId)
            {
                MessageBox.Show("License is not valid for this machine.");
                Application.Exit();
            }
            
            IsValid = true;
        }
        else
        {
            MessageBox.Show("Invalid license: " + string.Join("\n", validationResult));
            Application.Exit();
        }
    }
}
