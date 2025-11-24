namespace QliniqRec.Forms;

public partial class NewPatientForm : Form
{
    public NewPatient()
    {
        InitializeComponent();
    }

    private void disOtherChk_CheckedChanged(object sender, EventArgs e)
    {
        disOtherTxt.Enabled = disOtherChk.Checked;

        if (disOtherChk.Checked)
            disOtherTxt.Text = "";
    }
}
