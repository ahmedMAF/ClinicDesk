using ClinicDesk.Database;

namespace ClinicDesk;

// TODO:
// - Perform action on enter in textbox, for search.
// - Billing.
// - UI Style (MaterialSkin or ReaLTaiizor)
// * Reports (Like: case report, referral, statistics, etc)
// * Printing.
// * Single laptop case.
// * Security.
// * Tutorial.
// -
// - Screenshots
// -
// - Secretary appointment status + sort.
// - Doctor color rows.
// - Doctor visits fix buttons 2.
// - Secretary edit buttons on cancelled or attended appointments. (attended can still follow up, with search filter)
// - Secretary missed appointment.
// - Patient search, multiple results form.
// * Save LastSeenDate, IsInstalled and IsFirstRun in registry.
// * Filter height = 0 to hide row.
// * Doctor edit previous visits.
// * Custom calendar, date picker and time picker controls with material theme.
// * Better material theme implementation for WinForms.
// * See AwesomeWinForms.
// -
// - Hide multi-result search table.
// - Secretary edit profile + cancel + show past visits.
// * Doctor only pending has button.
// * Past visits show more button + show less button not showing.
// * Follow up dont have show more button.
// * When invoice is full, hide pay button.
// * Refresh after details of invoice.

internal static class Program
{
    public static bool IsReady => AppLicense.IsValid && Settings.Instance.AccountType != AccountType.NotDefined && ClinicDb.IsRunning;
    
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        Settings.Initialize();
        //AppLicense.Validate();
        
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
        
        if (Settings.Instance.AccountType == AccountType.NotDefined)
        {
            // TODO: Run MySQL if server.
            ClinicDb.Initialize();

            if (!ClinicDb.IsRunning)
                return;
        }

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new AppContext());
    }
}
