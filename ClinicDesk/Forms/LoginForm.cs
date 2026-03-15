using ClinicDesk.Database;
using ClinicDesk.Database.Models;
using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class LoginForm : MaterialForm
{
    private bool _loginDone;

    public LoginForm()
    {
        InitializeComponent();

        FormClosed += (s, e) =>
        {
            if (!_loginDone)
                Application.Exit();
        };
    }

    private async void loginBtn_ClickAsync(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(usernameTxt.Text))
        {
            errorProvider.SetError(usernameTxt, "Username is required.");
            return;
        }

        if (string.IsNullOrWhiteSpace(passwordTxt.Text))
        {
            errorProvider.SetError(passwordTxt, "Password is required.");
            return;
        }

        User? user = await ClinicDb.SafeExecAsync<User, User?>(table => table
            .FirstOrDefaultAsync(u => u.Username == usernameTxt.Text && u.Password == passwordTxt.Text));

        if (user == null)
        {
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Settings.Instance.AccountType = user.Role switch
        {
            UserRole.Doctor => AccountType.Doctor,
            UserRole.Secretary => AccountType.Secretary,
            _ => throw new ArgumentOutOfRangeException()
        };

        AppContext.ShowForm<MainForm>(form => form.SetData(user));

        _loginDone = true;
        Close();
    }

    private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
            loginBtn.PerformClick();
    }

    private void usernameTxt_TextChanged(object sender, EventArgs e)
    {
        errorProvider.SetError(usernameTxt, null);
    }

    private void passwordTxt_TextChanged(object sender, EventArgs e)
    {
        errorProvider.SetError(passwordTxt, null);
    }
}
