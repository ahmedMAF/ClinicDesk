using ClinicDesk.Database;
using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class SettingsForm : MaterialForm
{
    public SettingsForm()
    {
        InitializeComponent();
    }

    private void SettingsForm_Load(object sender, EventArgs e)
    {
        Settings settings = Settings.Instance;

        dbServerTxt.Text = settings.Server;
        dbPortTxt.Text = settings.Port.ToString();
        dbNameTxt.Text = settings.Database;
        dbUserTxt.Text = settings.User;
        dbPasswordTxt.Text = settings.Password;
        backupTxt.Text = settings.BackupPath;
        daysSld.Value = settings.BackupDays;
        isDarkSwt.Checked = settings.IsDarkTheme;
    }

    private void saveBtn_Click(object sender, EventArgs e)
    {
        string dbServer = dbServerTxt.Text;
        string database = dbNameTxt.Text;
        string dbUser = dbUserTxt.Text;
        string dbPassword = dbPasswordTxt.Text;
        string backupPath = backupTxt.Text;

        if (!ushort.TryParse(dbPortTxt.Text, out ushort dbPort))
        {
            MessageBox.Show("The port must be a number between 0 and 65535.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            Directory.CreateDirectory(backupPath);
        }
        catch (Exception)
        {
            MessageBox.Show($"Couldn't create the backup folder. Check the path again.{Environment.NewLine}{backupPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (ClinicDb.TestConnection(dbServer, dbPort, database, dbUser, dbPassword))
        {
            MessageBox.Show("Failed to create and connect to the database. Check the connection data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Settings settings = Settings.Instance;

        settings.Server = dbServer;
        settings.Port = dbPort;
        settings.Database = database;
        settings.User = dbUser;
        settings.Password = dbPassword;
        settings.BackupDays = daysSld.Value;
        settings.BackupPath = backupTxt.Text;
        settings.IsDarkTheme = isDarkSwt.Checked;

        Settings.SaveSettings();

        SkinManager.Theme = settings.IsDarkTheme ? ReaLTaiizor.Manager.MaterialSkinManager.Themes.DARK : ReaLTaiizor.Manager.MaterialSkinManager.Themes.LIGHT;

        Close();
    }

    private void materialButton1_Click(object sender, EventArgs e)
    {
        if (folderBrowser.ShowDialog() == DialogResult.OK)
            backupTxt.Text = folderBrowser.SelectedPath;
    }

    private void backupBtn_Click(object sender, EventArgs e)
    {
        ClinicDb.AutoBackup();
    }

    private void backupCustomBtn_Click(object sender, EventArgs e)
    {
        if (folderBrowser.ShowDialog() == DialogResult.OK)
            ClinicDb.Backup(folderBrowser.SelectedPath);
    }
}
