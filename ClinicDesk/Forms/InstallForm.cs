using ClinicDesk.Database;
using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms
{
    public partial class InstallForm : MaterialForm
    {
        public InstallForm()
        {
            InitializeComponent();
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

        private void installBtn_Click(object sender, EventArgs e)
        {
            string licenseUrl = licenseServerUrlTxt.Text;

            string dbServer = dbServerTxt.Text;
            ushort dbPort = 0;
            string database = dbNameTxt.Text;
            string dbUser = dbUserTxt.Text;
            string dbPassword = dbPasswordTxt.Text;
            AccountType type = (AccountType)accountCbo.SelectedIndex;

            // TODO: License

            if (!ushort.TryParse(dbPortTxt.Text, out dbPort))
            {
                MessageBox.Show("The port must be a number between 0 and 65535.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClinicDb.Initialize();

            if (!ClinicDb.IsRunning)
            {
                MessageBox.Show("Failed to create and connect to the database. Check the connection data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
    }
}
