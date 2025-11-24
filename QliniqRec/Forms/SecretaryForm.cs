namespace QliniqRec.Forms;

public partial class SecretaryForm : Form
{
    public SecretaryForm()
    {
        InitializeComponent();
    }

    private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
    {
        listView1.Items.Clear();
    }

    private void newAppBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowForm<NewAppointmentForm>();
    }

    private void billingBtn_Click(object sender, EventArgs e)
    {
    }
}
