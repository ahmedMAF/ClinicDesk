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

        MaterialSkinManager skin = MaterialSkinManager.Instance;

        skin.Theme = MaterialSkinManager.Themes.LIGHT;

        skin.ColorScheme = new MaterialColorScheme(
            Color.FromArgb(62, 126, 105),
            Color.FromArgb(50, 100, 80),
            Color.FromArgb(62, 126, 105),
            // MaterialPrimary.Indigo700,
            // MaterialPrimary.Indigo100,
            //MaterialAccent.Red200,
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
        ClinicDb.Initialize();

        if (!ClinicDb.IsRunning)
        {
            Application.Exit();
            return;
        }
        
        ClinicDb.AutoBackup();
        
        if (Settings.Instance.IsDental)
            TeethHelper.Initialize();

        await delay;

        switch (Settings.Instance.AccountType)
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
