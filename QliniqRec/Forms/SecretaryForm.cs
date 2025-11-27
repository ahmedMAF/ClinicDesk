using QliniqRec;
using QliniqRec.Models;

namespace QliniqRec.Forms;

public partial class SecretaryForm : Form
{
    public SecretaryForm()
    {
        InitializeComponent();
    }

    private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
    {
        listView1.Items.Clear();
        
        List<Appointment> appointments = ClinicDb.Instance.Appointments
            .Where(a => a.Date == monthCalendar1.StartValue)
            .ToList();
            
        foreach (Appointment appointment in appointments)
        {
            listView1.Items.Add(new ListViewItem([ "", "1" ], -1));
        }
    }

    private void newAppBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowForm<NewAppointmentForm>();
    }

    private void billingBtn_Click(object sender, EventArgs e)
    {
    }
}
