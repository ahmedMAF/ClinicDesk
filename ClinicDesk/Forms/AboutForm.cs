using ReaLTaiizor.Forms;
using System.Diagnostics;
using System.Security.Policy;

namespace ClinicDesk.Forms;

public partial class AboutForm : MaterialForm
{
    public AboutForm()
    {
        InitializeComponent();
    }

    private void novaLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Process.Start(new ProcessStartInfo
        {
            FileName = "https://nova4is.com",
            UseShellExecute = true
        });
    }
}
