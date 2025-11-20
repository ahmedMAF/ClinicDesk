namespace QliniqRec;

public partial class WelcomeForm : Form
{
    public WelcomeForm()
    {
        InitializeComponent();
    }

    private void secretBtn_Click(object sender, EventArgs e)
    {
        SecretaryForm.ShowInstance();
        Hide();
    }

    private void docBtn_Click(object sender, EventArgs e)
    {
        DoctorForm.ShowInstance();
        Hide();
    }
}
