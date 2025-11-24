using QliniqRec.Database;
using QliniqRec.Forms;
using YAXLib;

namespace QliniqRec;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        YAXSerializer serial = new(typeof(Settings));
        Settings? settings = (Settings)serial.DeserializeFromFile("settings.xml");

        if (settings == null)
            settings = new Settings();

        ClinicDb.Initialize($"Server={settings.Server};Port={settings.Port};Database={settings.Database};User={settings.User};Password={settings.Password};");

        Application.Run(new WelcomeForm());
    }
}