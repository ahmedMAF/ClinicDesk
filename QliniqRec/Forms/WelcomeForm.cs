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
        AppContext.CloseForm<WelcomeForm>();
    }

    private void docBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowForm<DoctorForm>();
        AppContext.CloseForm<WelcomeForm>();
    }
}
