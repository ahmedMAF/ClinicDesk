using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class WelcomeForm : MaterialForm
{
    public WelcomeForm()
    {
        InitializeComponent();
    }

    private void secretBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowForm<SecretaryForm>();
        Close();
    }

    private void docBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowForm<DoctorForm>();
        Close();
    }
    
    private void allBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowForm<AllInOneForm>();
        Close();
    }
}
