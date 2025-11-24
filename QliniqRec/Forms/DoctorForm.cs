namespace QliniqRec.Forms;

public partial class DoctorForm : Form
{
    public static DoctorForm? Instance { get; private set; }

    public DoctorForm()
    {
        InitializeComponent();
    }

    public static void ShowInstance()
    {
        if (Instance == null || Instance.IsDisposed)
            Instance = new DoctorForm();

        Instance.Show();
    }

    public static void CloseInstance()
    {
        Instance?.Close();
        Instance = null;
    }

    private void patientsLst_MouseDoubleClick(object sender, MouseEventArgs e)
    {
    }

    private void patientsLst_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void patientsLst_MouseClick(object sender, MouseEventArgs e)
    {
        AppointmentForm.ShowInstance();
    }
}
