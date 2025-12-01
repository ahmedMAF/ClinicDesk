using QliniqRec.Database;

namespace QliniqRec;

// TODO:
// * See AwesomeWinForms.
// * Billing.
// * UI Style (MaterialSkin or ReaLTaiizor)
// * Reports (Like: case report, referral, statistics, etc)
// * Printing.
// * Single laptop case.
// * Security.

internal static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        Settings.Initialize();
        
        if (!Settings.Instance.Initialized)
        {
            // TODO: Call installer.
        }
        
        if (Settings.Instance.LastSeenDate < DateTime.UtcNow)
        {
            // TODO: Trying to cheat license.
        }
        else
        {
            // We are good.
            Settings.Instance.LastSeenDate = DateTime.UtcNow;
            Settings.SaveSettings();
        }
        
        ClinicDb.Initialize();

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new AppContext());
    }
}
