using ClinicDesk.Database;
using ClinicDesk.Utilities;

namespace ClinicDesk.Forms;

public partial class SplashForm : Form
{
    private bool _doneInit;

    public SplashForm()
    {
        InitializeComponent();
    }

    private async void SplashForm_Shown(object sender, EventArgs e)
    {
        await Task.Delay(500);

        Settings settings = Settings.Instance;

        if (!AppLicense.Validate())
        {
            Application.Exit();
            return;
        }

        if (!LicenseDateHelper.IsSystemDateValid())
        {
            // TODO: Trying to cheat license.
            Application.Exit();
            return;
        }
      
        // We are good.
        LicenseDateHelper.SaveLastSeen();

        if (settings.UseApi)
            AppointmentApi.Initialize();

        ClinicDb.GetDbServerType();
        await ClinicDb.Initialize();

        if (!ClinicDb.IsRunning)
        {
            Application.Exit();
            return;
        }

        ClinicDb.AutoBackup();
        
        if (settings.IsDental)
            TeethHelper.Initialize();

        AppContext.ShowForm<LoginForm>();

        _doneInit = true;

        Close();
    }

    private void SplashForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (!_doneInit)
            Application.Exit();
    }
}
