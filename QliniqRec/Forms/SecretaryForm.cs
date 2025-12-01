using Microsoft.EntityFrameworkCore;
using QliniqRec.Database;
using QliniqRec.Database.Dto;
using QliniqRec.Database.Models;
using System.Windows.Forms;

namespace QliniqRec.Forms;

public partial class SecretaryForm : Form
{
    private List<AppointmentDto> _appointments = null!;

    public SecretaryForm()
    {
        InitializeComponent();

        FormClosed += (s, e) => Application.Exit();
        Utils.SetupAppointmentsDataGrid(appointmentsGrd);
    }

    private void SecretaryForm_Load(object sender, EventArgs e)
    {
        monthCalendar1.SelectionStart = DateTime.Now;
    }

    private async void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
    {
        _appointments = await ClinicDb.Instance.Appointments
            .AsNoTracking()
            .Where(a => a.Date.Date == monthCalendar1.SelectionStart.Date)
            .OrderBy(a => a.Date)
            .Select(a => new AppointmentDto
            {
                Id = a.Id,
                Time = a.Date.TimeOfDay,
                PatientName = a.Patient.Name,
                Phone = a.Patient.Phone!
            })
            .ToListAsync();

        for (int i = 0; i < _appointments.Count; i++)
            _appointments[i].Serial = i + 1;

        appointmentsGrd.DataSource = _appointments;
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

    private async void appointmentsGrd_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && appointmentsGrd.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
        {
            Appointment? appointment = await ClinicDb.Instance.Appointments
                .Include(a => a.Patient)
                .FirstOrDefaultAsync(a => a.Id == _appointments[e.RowIndex].Id);

            AppContext.ShowForm<NewAppointmentForm>(form => form.SetData(appointment!));
        }
    }
}
