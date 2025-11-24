namespace QliniqRec.Forms;

public partial class DoctorForm : Form
{
    public DoctorForm()
    {
        InitializeComponent();
    }

    private void patientsLst_MouseDoubleClick(object sender, MouseEventArgs e)
    {
    }

    private void patientsLst_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void patientsLst_MouseClick(object sender, MouseEventArgs e)
    {
        AppContext.ShowForm<AppointmentForm>();
    }
}
