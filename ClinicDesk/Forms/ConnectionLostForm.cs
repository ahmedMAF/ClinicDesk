using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class ConnectionLostForm : MaterialForm
{
    public ConnectionLostForm()
    {
        InitializeComponent();
    }

    private void exitBtn_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
