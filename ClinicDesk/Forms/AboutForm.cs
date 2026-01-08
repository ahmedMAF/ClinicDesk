using System.Diagnostics;
using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class AboutForm : MaterialForm
{
    public AboutForm()
    {
        InitializeComponent();
    }

    private void novaLink_Click(object sender, EventArgs e)
    {
        Process.Start("https://nova4is.com");
    }
}
