using ClinicDesk.Database;

namespace ClinicDesk;

// TODO:
// * Reports and statistics (Like: case report, referral, statistics, etc)
// * Printable Reports.
// * Tutorial.
// * Filter in data grids (maybe row height = 0 to hide row).
// * Doctor edit previous visits.
// * DPI.
// * Custom calendar, date picker and time picker controls with material theme.
// * Teeth save in database.
// * Age mark teeth missing.

internal static class Program
{
    public static bool IsReady => AppLicense.IsValid && Settings.Instance.AccountType != AccountType.NotDefined && ClinicDb.IsRunning;
    
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        
        /*using Mutex mutex = new(true, "ClinicDeskMutex", out bool createdNew);
        
        if (!createdNew)
        {
            MessageBox.Show("App is already running.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }*/
        
        Application.Run(new AppContext());
    }
}
