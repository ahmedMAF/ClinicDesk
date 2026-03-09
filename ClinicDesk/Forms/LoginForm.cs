using ClinicDesk.Database;
using ClinicDesk.Database.Models;
using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class LoginForm : MaterialForm
{
    public LoginForm()
    {
        InitializeComponent();
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
            return;

        AppContext.ShowForm<MainForm>(form => form.SetData(user));

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
