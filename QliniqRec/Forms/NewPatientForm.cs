using QliniqRec.Database.Models;

namespace QliniqRec.Forms;

public partial class NewPatientForm : Form
{
    internal Patient Patient { get; private set; } = null!;
    
    public NewPatientForm()
    {
        InitializeComponent();
    }
    
    internal void SetData(string name, string phone)
    {
        textBox1.Text = name;
        textBox4.Text = phone;
    }

    private void disOtherChk_CheckedChanged(object sender, EventArgs e)
    {
        disOtherTxt.Enabled = disOtherChk.Checked;

        if (disOtherChk.Checked)
            disOtherTxt.Text = "";
    }
}
