namespace QliniqRec.Forms;

public partial class NewPatient : Form
{
    public static NewPatient? Instance { get; private set; }

    public NewPatient()
    {
        InitializeComponent();
    }

    public static void ShowInstance()
    {
        if (Instance == null || Instance.IsDisposed)
            Instance = new NewPatient();

        Instance.ShowDialog();
    }

    public static void CloseInstance()
    {
        Instance?.Close();
        Instance = null;
    }

    private void disOtherChk_CheckedChanged(object sender, EventArgs e)
    {
        disOtherTxt.Enabled = disOtherChk.Checked;

        if (disOtherChk.Checked)
            disOtherTxt.Text = "";
    }
}
