using Microsoft.EntityFrameworkCore;
using QliniqRec.Database;
using QliniqRec.Database.Dto;

namespace QliniqRec.Forms;

public partial class SecretaryForm : Form
{
    public SecretaryForm()
    {
        InitializeComponent();
    }

    private async void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
    {
        listView1.Items.Clear();

        List<AppointmentDto> appointments = await ClinicDb.Instance.Appointments
            .AsNoTracking()
            .Where(a => a.Date == monthCalendar1.SelectionStart)
            .Select(a => new AppointmentDto { Id = a.Id, Date = a.Date })
            .ToListAsync();

        dataGridView1.DataSource = new BindingSource()
        {
            DataSource = appointments
        };
    }

    private void newAppBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowForm<NewAppointmentForm>();
    }

    private void billingBtn_Click(object sender, EventArgs e)
    {
    }
}
