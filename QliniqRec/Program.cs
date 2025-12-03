using Portable.Licensing;
using QliniqRec.Database;

namespace QliniqRec;

// TODO:
// * Perform action on enter in textbox, for search.
// * See AwesomeWinForms.
// * Billing.
// * UI Style (MaterialSkin or ReaLTaiizor)
// * Reports (Like: case report, referral, statistics, etc)
// * Printing.
// * Single laptop case.
// * Security.

internal static class Program
{
    public static bool IsReady => AppLicense.IsValid && Settings.Instance.Initialized && ClinicDb.IsRunning;
    
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        AppLicense.Validate();
        Settings.Initialize();
        
        if (!Settings.Instance.Initialized)
        {
            // TODO: Call installer.
            
            Settings.Instance.Initialized = true;
            Settings.SaveSettings();
        }
        
        if (Settings.Instance.LastSeenDate > DateTime.UtcNow)
        {
            // TODO: Trying to cheat license.
            Application.Exit();
        }
        else
        {
            // We are good.
            Settings.Instance.LastSeenDate = DateTime.UtcNow;
            Settings.SaveSettings();
        }
        
        // TODO: Run MySQL if server.
        ClinicDb.Initialize();

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new AppContext());
    }
}
