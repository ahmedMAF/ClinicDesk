using ClinicDesk.Database;
using ClinicDesk.Utilities;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

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
        Task delay = Task.Delay(3000);
        await Task.Delay(500);

        Settings settings = Settings.Instance;
        MaterialSkinManager skin = MaterialSkinManager.Instance;

        skin.Theme = settings.IsDarkTheme ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;

        skin.ColorScheme = new MaterialColorScheme(
            Color.FromArgb(60, 125, 105),
            Color.FromArgb(50, 100, 80),
            Color.FromArgb(100, 180, 150),
            Color.FromArgb(140, 9, 45),
            MaterialTextShade.WHITE
        );

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

        ClinicDb.Initialize();

        if (!ClinicDb.IsRunning)
        {
            Application.Exit();
            return;
        }
        
        ClinicDb.AutoBackup();
        
        if (settings.IsDental)
            TeethHelper.Initialize();

        await delay;

        switch (settings.AccountType)
        {
            case AccountType.Doctor:
                AppContext.ShowForm<DoctorForm>();
                break;

            case AccountType.Secretary:
                AppContext.ShowForm<SecretaryForm>();
                break;

            case AccountType.AllInOne:
                AppContext.ShowForm<AllInOneForm>();
                break;

            default:
                AppContext.ShowForm<WelcomeForm>();
                break;
        }

        _doneInit = true;

        Close();
    }

    private void SplashForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (!_doneInit)
            Application.Exit();
    }
}
