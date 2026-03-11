using ClinicDesk.Utilities;
using MemoryPack;

namespace ClinicDesk;

[MemoryPackable]
public partial class Settings
{
    [MemoryPackIgnore]
    private static readonly string SettingsPath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "ClinicDesk",
        "settings.bin"
    );
    
    [MemoryPackIgnore]
    public static Settings Instance { get; private set; } = null!;

    public string Server { get; internal set; } = "127.0.0.1";
    public ushort Port { get; internal set; } = 3306;
    public string Database { get; internal set; } = "clinic_desk_db";
    public string User { get; internal set; } = "root";
    public string Password { get; internal set; } = "";

    public AccountType AccountType { get; internal set; }
    public bool IsDental { get; internal set; }
    public bool IsDarkTheme { get; internal set; }
    public bool UseApi { get; internal set; }
    public bool UseConnectionCheck { get; internal set; }
    public string BackupPath { get; internal set; } = @"D:\ClinicDesk Backup";
    public string AppointmentApiUrl { get; internal set; } = "https://nova4is.com/api/appointments";
    public int BackupDays { get; internal set; } = 2;
    public DateTime LastBackup { get; internal set; }
    public DateTime LastSeen { get; internal set; }

    [MemoryPackIgnore]
    public DateTime NextBackup => LastBackup.AddDays(BackupDays);

    [MemoryPackIgnore]
    public bool IsServer { get; private set; }

    [MemoryPackIgnore]
    public bool IsLanServer { get; private set; }

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

            Instance.CheckIP();
        }
    }
    
    private static void LoadSettings()
    {
        byte[] bytes = File.ReadAllBytes(SettingsPath);
        Instance = MemoryPackSerializer.Deserialize<Settings>(bytes) ?? new Settings();

        Instance.CheckIP();
    }

    public static void SaveSettings()
    {
        byte[] bytes = MemoryPackSerializer.Serialize(Instance);
        File.WriteAllBytes(SettingsPath, bytes);
    }

    private void CheckIP()
    {
        IsServer = Server is "127.0.0.1" or "localhost";
        IsLanServer = Utils.IsLanAddress(Server).GetAwaiter().GetResult();
    }
}
