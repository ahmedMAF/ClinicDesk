using ClinicDesk.Database;
using ClinicDesk.Utilities;
using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class InstallForm : MaterialForm
{
    private bool _doneInstall;

    public InstallForm()
    {
        InitializeComponent();

        FormClosed += (s, e) =>
        {
            if (!_doneInstall)
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
        backupTxt.Text = settings.BackupPath;
        daysSld.Value = settings.BackupDays;
        isDentalSwt.Checked = settings.IsDental;
        apiUrltxt.Text = settings.AppointmentApiUrl;

        accountCbo.SelectedIndex = (int)settings.AccountType;
    }

    private async void installBtn_Click(object sender, EventArgs e)
    {
        progressBar.Visible = true;

        string licenseUrl = licenseServerUrlTxt.Text;

        string dbServer = dbServerTxt.Text;
        string database = dbNameTxt.Text;
        string dbUser = dbUserTxt.Text;
        string dbPassword = dbPasswordTxt.Text;
        string backupPath = backupTxt.Text;

        string name = nameTxt.Text;
        string email = emailTxt.Text;
        bool isServer = dbServer is "127.0.0.1" or "localhost";

        AccountType type = (AccountType)accountCbo.SelectedIndex;
        bool useApi = apiSwt.Checked;
        string apiUrl = apiUrltxt.Text;

        if (!AppLicense.IsAvailable)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill in your name and email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (!await AppLicense.RequestLicenseAsync(licenseUrl, name, email))
            {
                MessageBox.Show("Failed to request license, try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        if (!AppLicense.Validate())
        {
            MessageBox.Show("Failed to validate license, try requesting a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!ushort.TryParse(dbPortTxt.Text, out ushort dbPort))
        {
            MessageBox.Show("The port must be a number between 0 and 65535.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (isServer)
        {
            try
            {
                Directory.CreateDirectory(backupPath);
            }
            catch (Exception)
            {
                MessageBox.Show($"Couldn't create the backup folder. Check the path again.{Environment.NewLine}{backupPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        if (type == AccountType.NotDefined)
        {
            MessageBox.Show("Must choose an account type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (isServer)
        {
            ClinicDb.GetDbServerType();

            if (!ClinicDb.IsServerInstalled)
            {
                Utils.InstallMariaDb();
            }
        }

        if (!ClinicDb.TestConnection(dbServer, dbPort, database, dbUser, dbPassword))
        {
            MessageBox.Show("Failed to connect to the database. Check the connection data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (useApi && !await AppointmentApi.TestApiUrl(apiUrl))
        {
            MessageBox.Show("Failed to connect to the API. Check the URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Settings settings = Settings.Instance;

        settings.Server = dbServer;
        settings.Port = dbPort;
        settings.Database = database;
        settings.User = dbUser;
        settings.Password = dbPassword;
        settings.AccountType = type;
        settings.UseApi = useApi;
        settings.AppointmentApiUrl = apiUrl;
        settings.BackupDays = daysSld.Value;
        settings.BackupPath = backupTxt.Text;
        settings.IsDental = isDentalSwt.Checked;
        settings.LastBackup = DateTime.Now.Date;

        Settings.SaveSettings();

        _doneInstall = true;
        Close();
        AppContext.ShowForm<SplashForm>();
    }

    private void browseBtn_Click(object sender, EventArgs e)
    {
        if (folderBrowser.ShowDialog() == DialogResult.OK)
            backupTxt.Text = folderBrowser.SelectedPath;
    }

    private void apiSwt_CheckedChanged(object sender, EventArgs e)
    {
        apiUrltxt.Enabled = apiSwt.Checked;
    }
}
