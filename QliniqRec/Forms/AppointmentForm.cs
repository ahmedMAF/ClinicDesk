namespace QliniqRec.Forms;

public partial class AppointmentForm : Form
{
    public static AppointmentForm? Instance { get; private set; }

    public AppointmentForm()
    {
        InitializeComponent();
    }

    public static void ShowInstance()
    {
        if (Instance == null || Instance.IsDisposed)
            Instance = new AppointmentForm();

        Instance.Show();
    }

    public static void CloseInstance()
    {
        Instance?.Close();
        Instance = null;
    }
}
