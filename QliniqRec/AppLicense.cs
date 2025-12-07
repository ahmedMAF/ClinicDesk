using Portable.Licensing;
using Portable.Licensing.Validation;

namespace QliniqRec;

public static class AppLicense
{
    private const byte[] PublicKey = Convert.FromBase64String("MIIBCgKCAQEAtc426lD/UHZL6ea9Zo7TBiKM2YR9TEoeC+Xwl55uvLsX/Q8XInDKw1rP8rfTs6EJOAxfuvOeQdAr587P7LnYBRJJBgU774z9xCuiXzXcGHM1c79+HGErUeg1LPmgfiD7znZYLFNHy0fW0EixsmXVzhsqXrDa6jr9fqfyo6y97kkVB4IvvUxfpbEmRk2CxxkSl+MFWiIoSH/VoPWrzFEorpxRLABTS0eOZxvSIDXM1ynIYafLV0iKLlE7LuI2TlOEA4s2T1VfqXAgovgkutYcrd38Z56Fu4nq8zCZEhhToCN/jEVtAGUzlgsRRfR1gLXbMPOvi83Pea1En/x+t1qt9wIDAQAB");
    
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
            int actualId = Utils.GetHardwareId();
            
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
