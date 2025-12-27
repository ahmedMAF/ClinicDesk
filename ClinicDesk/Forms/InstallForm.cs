using ClinicDesk.Database;
using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class InstallForm : MaterialForm
{
    private bool _doneInit;
    
    public InstallForm()
    {
        InitializeComponent();
        FormClosed += (s, e) =>
        {
            if (!_doneInit)
                Application.Exit();
        };
    }

    private void InstallForm_Load(object sender, EventArgs e)
    {
        Settings settings = Settings.Instance;

        dbServerTxt.Text = settings.Server;
        dbPortTxt.Text = settings.Port.ToString();
        dbNameTxt.Text = settings.Database;
        dbUserTxt.Text = settings.User;
        dbPasswordTxt.Text = settings.Password;

        accountCbo.SelectedIndex = (int)settings.AccountType;
    }

    private async void installBtn_Click(object sender, EventArgs e)
    {
        string licenseUrl = licenseServerUrlTxt.Text;

        string dbServer = dbServerTxt.Text;
        ushort dbPort = 0;
        string database = dbNameTxt.Text;
        string dbUser = dbUserTxt.Text;
        string dbPassword = dbPasswordTxt.Text;
        
        string name = nameTxt.Text;
        string email = emailTxt.Text;
        
        AccountType type = (AccountType)accountCbo.SelectedIndex;

        if (!AppLicense.IsAvailable && !await AppLicense.RequestLicenseAsync(licenseUrl, name, email))
        {
            MessageBox.Show("Failed to request license, try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        if (!AppLicense.Validate())
        {
            MessageBox.Show("Failed to validate license, try requesting new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!ushort.TryParse(dbPortTxt.Text, out dbPort))
        {
            MessageBox.Show("The port must be a number between 0 and 65535.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (type == AccountType.NotDefined)
        {
            MessageBox.Show("Must choose an account type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Settings settings = Settings.Instance;

        settings.Server = dbServer;
        settings.Port = dbPort;
        settings.Database = database;
        settings.User = dbUser;
        settings.Password = dbPassword;
        settings.AccountType = type;

        Settings.SaveSettings();

        ClinicDb.Initialize();

        if (!ClinicDb.IsRunning)
        {
            MessageBox.Show("Failed to create and connect to the database. Check the connection data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _doneInit = true;
        Close();
        AppContext.ShowForm<SplashForm>();
    }
}
