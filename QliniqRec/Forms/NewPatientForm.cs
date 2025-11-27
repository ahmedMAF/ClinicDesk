namespace QliniqRec.Forms;

public partial class NewPatientForm : Form
{
    internal Patient Patient { get; private set; }
    
    public NewPatient()
    {
        InitializeComponent();
    }
    
    internal void SetData(string name, string phone)
    {
        textbox1.Text = name;
        textbox2.Text = phone;
    }

    private void disOtherChk_CheckedChanged(object sender, EventArgs e)
    {
        disOtherTxt.Enabled = disOtherChk.Checked;

        if (disOtherChk.Checked)
            disOtherTxt.Text = "";
    }
}
