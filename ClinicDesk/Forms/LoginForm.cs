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
        User? user = await ClinicDb.Instance.Users
            .FirstOrDefaultAsync(u => u.Username == usernameTxt.Text && u.Password == passwordTxt.Text);

        if (user == null)
        {
            return;
        }

        switch (user.Role)
        {
            case UserRole.Doctor:
                AppContext.ShowForm<DoctorForm>(form => form.SetData(user));
                break;
            case UserRole.Secretary:
                AppContext.ShowForm<SecretaryForm>(form => form.SetData(user));
                break;
        }
    }
}
