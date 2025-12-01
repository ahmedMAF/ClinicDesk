using System;
using System.IO;
using MemoryPack;

namespace QliniqRec;

[MemoryPackable]
public partial class Settings
{
    [MemoryPackIgnore]
    private static readonly string SettingsPath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "QliniqRec",
        "settings.bin"
    );
    
    [MemoryPackIgnore]
    public static Settings Instance { get; private set; } = null!;

    public string Server { get; internal set; } = "127.0.0.1";
    public ushort Port { get; internal set; } = 3306;
    public string Database { get; internal set; } = "qliniq_rec_db";
    public string User { get; internal set; } = "root";
    public string Password { get; internal set; } = "";

    public bool Initialized { get; internal set; }
    public AccountType AccountType { get; internal set; }
    public DateTime LastSeenDate { get; internal set; } = DateTime.UtcNow;

    internal static void Initialize()
    {
        Directory.CreateDirectory(Path.GetDirectoryName(SettingsPath)!);

        if (File.Exists(SettingsPath))
        {
            LoadSettings();
        }
        else
        {
            Instance = new Settings();
            SaveSettings();
        }
    }
    
    private static Settings LoadSettings()
    {
        var bytes = File.ReadAllBytes(SettingsPath);
        Instance = MemoryPackSerializer.Deserialize<Settings>(bytes) ?? new Settings();
    }

    public static void SaveSettings()
    {
        var bytes = MemoryPackSerializer.Serialize(Instance);
        File.WriteAllBytes(SettingsPath, bytes);
    }
}

public enum AccountType : byte
{
    NotDefined,
    Doctor,
    Secretary
}
