using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;

namespace ClinicDesk;

public static class LicenseDateHelper
{
    private const string RegistryPath = @"Software\ClinicDesk\License";
    private const string ValueName = "LastSeenEncrypted";

    public static void SaveLastSeen()
    {
        // ISO Format
        string dateStr = DateTime.UtcNow.ToString("O");
        string encrypted = Encrypt(dateStr);
        
        using var key = Registry.CurrentUser.CreateSubKey(RegistryPath);
        key?.SetValue(ValueName, encrypted, RegistryValueKind.String);
    }

    public static bool IsSystemDateValid()
    {
        using var key = Registry.CurrentUser.OpenSubKey(RegistryPath);
        string encrypted = (string)key?.GetValue(ValueName);

        if (string.IsNullOrWhiteSpace(encrypted))
            // First run or key missing
            return true;

        DateTime storedDate = DateTime.Parse(Decrypt(encrypted));
        DateTime now = DateTime.UtcNow;

        // Return false if current time is before stored time, likely tampering.
        return now >= storedDate;
    }

    private static string Encrypt(string plainText)
    {
        DeriveKeyAndIV(out byte[] key, out byte[] iv);
        
        using Aes aes = Aes.Create();
        aes.Key = key;
        aes.IV = iv;
        
        using var encryptor = aes.CreateEncryptor();
        using MemoryStream ms = new();
        using CryptoStream cs = new(ms, encryptor, CryptoStreamMode.Write);
        using StreamWriter sw = new(cs);
        
        sw.Write(plainText);
        
        return Convert.ToBase64String(ms.ToArray());
    }

    private static string Decrypt(string encryptedText)
    {
        DeriveKeyAndIV(out byte[] key, out byte[] iv);
        
        byte[] bytes = Convert.FromBase64String(encryptedText);
        
        using Aes aes = Aes.Create();
        aes.Key = key;
        aes.IV = iv;
        
        using var decryptor = aes.CreateDecryptor();
        using MemoryStream ms = new(bytes);
        using CryptoStream cs = new(ms, decryptor, CryptoStreamMode.Read);
        using StreamReader sr = new(cs);
        
        return sr.ReadToEnd();
    }
    
    public static void DeriveKeyAndIV(out byte[] key, out byte[] iv)
    {
        byte[] hash = Utils.GetHardwareIdBytes();

        // Use first 16 bytes (128 bits) as AES key
        key = new byte[16];
        Array.Copy(hash, 0, key, 0, 16);

        // Use next 16 bytes (128 bits) as IV
        iv = new byte[16];
        Array.Copy(hash, 16, iv, 0, 16);
    }
}
