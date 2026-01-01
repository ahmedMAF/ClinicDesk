using System.Security.Cryptography;
using Microsoft.Win32;

namespace ClinicDesk.Utilities;

public static class LicenseDateHelper
{
    private const string RegistryPath = @"Software\ClinicDesk\License";
    private const string ValueName = "LastSeenEncrypted";

    public static void SaveLastSeen()
    {
        DateTime now = DateTime.UtcNow;
        
        Settings settings = Settings.Instance;
        settings.LastSeen = now;
        Settings.SaveSettings();
        
        // ISO Format
        string dateStr = now.ToString("O");
        string encrypted = Encrypt(dateStr);
        
        using RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryPath);
        key?.SetValue(ValueName, encrypted, RegistryValueKind.String);
    }

    public static bool IsSystemDateValid()
    {
        using RegistryKey? key = Registry.CurrentUser.OpenSubKey(RegistryPath);
        string? encrypted = (string?)key?.GetValue(ValueName);

        if (string.IsNullOrWhiteSpace(encrypted))
        {
            // If settings doesn't have LastSeen then it's most probably a first run.
            return Settings.Instance.LastSeen == DateTime.MinValue;
        }

        DateTime storedDate = DateTime.Parse(Decrypt(encrypted));

        // Return false if current time is before stored time or registry date is different from settings date, likely tampering.
        return DateTime.UtcNow >= storedDate || storedDate != Settings.Instance.LastSeen;
    }

    private static string Encrypt(string plainText)
    {
        DeriveKeyAndIV(out byte[] key, out byte[] iv);
        
        using Aes aes = Aes.Create();
        aes.Key = key;
        aes.IV = iv;
        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.PKCS7;

        using ICryptoTransform encryptor = aes.CreateEncryptor();
        using MemoryStream ms = new();
        using CryptoStream cs = new(ms, encryptor, CryptoStreamMode.Write);
        using StreamWriter sw = new(cs);
        
        sw.Write(plainText);
        sw.Close();

        return Convert.ToBase64String(ms.ToArray());
    }

    private static string Decrypt(string encryptedText)
    {
        DeriveKeyAndIV(out byte[] key, out byte[] iv);

        byte[] bytes = Convert.FromBase64String(encryptedText);
        
        using Aes aes = Aes.Create();
        aes.Key = key;
        aes.IV = iv;
        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.PKCS7;

        using ICryptoTransform decryptor = aes.CreateDecryptor();
        using MemoryStream ms = new(bytes);
        using CryptoStream cs = new(ms, decryptor, CryptoStreamMode.Read);
        using StreamReader sr = new(cs);
        
        return sr.ReadToEnd();
    }
    
    public static void DeriveKeyAndIV(out byte[] key, out byte[] iv)
    {
        byte[] hash = Utils.GetHardwareIdBytes();

        // Use first 16 bytes (128 bits) as AES key, for AES-128
        key = new byte[16];
        Array.Copy(hash, 0, key, 0, 16);

        // Use next 16 bytes (128 bits) as IV, must be 16 byte, AES block size
        iv = new byte[16];
        Array.Copy(hash, 16, iv, 0, 16);
    }
}
