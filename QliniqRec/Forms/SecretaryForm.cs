using Microsoft.EntityFrameworkCore;
using QliniqRec.Database;
using QliniqRec.Database.Dto;

namespace QliniqRec.Forms;

public partial class SecretaryForm : Form
{
    public SecretaryForm()
    {
        InitializeComponent();
        Utils.SetupAppointmentsDataGrid(appointmentsGrd);
    }

    private void SecretaryForm_Load(object sender, EventArgs e)
    {
        monthCalendar1.SelectionStart = DateTime.Now;
    }

    private async void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
    {
        List<AppointmentDto> appointments = await ClinicDb.Instance.Appointments
            .AsNoTracking()
            .Where(a => a.Date.Date == monthCalendar1.SelectionStart.Date)
            .OrderBy(a => a.Date)
            .Select(a => new AppointmentDto
            {
                Id = a.Id,
                Time = a.Date.TimeOfDay,
                PatientName = a.Patient.Name,
                Phone = a.Patient.Phone
            })
            .ToListAsync();

        for (int i = 0; i < appointments.Count; i++)
            appointments[i].Serial = i + 1;

        appointmentsGrd.DataSource = appointments;
    }

    private void newAppBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowForm<NewAppointmentForm>();
    }

    private void billingBtn_Click(object sender, EventArgs e)
    {
    }

    private void appointmentsGrd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.Value is TimeSpan ts)
        {
            e.Value = DateTime.Today.Add(ts).ToString("hh:mm tt");
            e.FormattingApplied = true;
        }
    }
}
