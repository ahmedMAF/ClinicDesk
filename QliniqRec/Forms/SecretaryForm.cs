namespace QliniqRec.Forms;

public partial class SecretaryForm : Form
{
    public static SecretaryForm? Instance { get; private set; }

    public SecretaryForm()
    {
        InitializeComponent();
    }

    public static void ShowInstance()
    {
        if (Instance == null || Instance.IsDisposed)
            Instance = new SecretaryForm();

        Instance.Show();
    }

    public static void CloseInstance()
    {
        Instance?.Close();
        Instance = null;
    }

    private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
    {
        listView1.Items.Clear();
    }

    private void newAppBtn_Click(object sender, EventArgs e)
    {
        NewAppointmentForm.ShowInstance();
    }

    private void billingBtn_Click(object sender, EventArgs e)
    {

    }
}
