namespace QliniqRec.Forms;

public partial class WelcomeForm : Form
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
}
