namespace QliniqRec.Forms;

public partial class PatientProfilesForm : Form
{
    public static PatientProfilesForm? Instance { get; private set; }

    public PatientProfilesForm()
    {
        InitializeComponent();
    }

    public static void ShowInstance()
    {
        if (Instance == null || Instance.IsDisposed)
            Instance = new PatientProfilesForm();

        Instance.Show();
    }

    public static void CloseInstance()
    {
        Instance?.Close();
        Instance = null;
    }
}
