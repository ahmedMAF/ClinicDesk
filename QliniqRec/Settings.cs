using YAXLib;
using YAXLib.Attributes;

namespace QliniqRec;

public class Settings
{
    public static Settings Instance { get; private set; }
    
    [YAXAttributeFor("Database/Connection")]
    public string Server { get; internal set; } = "127.0.0.1";
    
    [YAXAttributeFor("Database/Connection")]
    public ushort Port { get; internal set; } = 3306;
    
    [YAXAttributeFor("Database/Connection")]
    public string Database { get; internal set; } = "qliniq_rec_db";
    
    [YAXAttributeFor("Database/Credentials")]
    public string User { get; internal set; } = "root";
    
    [YAXAttributeFor("Database/Credentials")]
    public string Password { get; internal set; } = "";
    
    internal static void Initialize()
    {
        YAXSerializer serial = new(typeof(Settings));

        try
        {
            Instance = (Settings)serial.DeserializeFromFile("settings.xml")!;

            if (Instance == null)
                CreateSettings(serial);
        }
        catch
        {
            CreateSettings(serial);
        }
    }

    private static void CreateSettings(YAXSerializer serial)
    {
        Instance = new Settings();
        serial.SerializeToFile(Instance, "settings.xml");
    }
}
