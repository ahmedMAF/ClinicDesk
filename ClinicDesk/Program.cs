using ClinicDesk.Database;

namespace ClinicDesk;

// TODO:
// - Perform action on enter in textbox, for search.
// - Billing.
// - UI Style (MaterialSkin or ReaLTaiizor)
// - Single laptop case.
// * Reports (Like: case report, referral, statistics, etc)
// * Printing.
// * Security.
// * Tutorial.
// -
// - Screenshots
// - Secretary appointment status + sort.
// - Doctor color rows.
// - Doctor visits fix buttons 2.
// - Secretary edit buttons on cancelled or attended appointments. (attended can still follow up, with search filter)
// - Secretary missed appointment.
// - Patient search, multiple results form.
// - Better material theme implementation for WinForms.
// - See AwesomeWinForms.
// - Hide multi-result search table.
// - Secretary edit profile + cancel + show past visits.
// - Doctor only pending has button.
// - Past visits show more button + show less button not showing.
// - Follow up dont have show more button.
// - When invoice is full, hide pay button.
// - Refresh after details of invoice.
// - multi-line search numbers.
// - Disable hidden buttons in grids.
// * Save LastSeenDate, IsInstalled and IsFirstRun in registry.
// * Filter height = 0 to hide row.
// * Doctor edit previous visits.
// * Custom calendar, date picker and time picker controls with material theme.

internal static class Program
{
    public static bool IsReady => AppLicense.IsValid && Settings.Instance.AccountType != AccountType.NotDefined && ClinicDb.IsRunning;
    
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new AppContext());
    }
}
