using Microsoft.EntityFrameworkCore;
using QliniqRec.Database;
using QliniqRec.Database.Dto;
using QliniqRec.Database.Models;

namespace QliniqRec.Forms;

public partial class DoctorForm : Form
{
    private List<AppointmentDto> _appointments;

    public DoctorForm()
    {
        InitializeComponent();
        
        FormClosed += (s, e) => Application.ExitThread();
        Utils.SetupAppointmentsDataGrid(appointmentsGrd);
    }

    private async void DoctorForm_Load(object sender, EventArgs e)
    {
        _appointments = await ClinicDb.Instance.Appointments
            .AsNoTracking()
            .Where(a => a.Date.Date == DateTime.Now.Date)
            .OrderBy(a => a.Date)
            .Select(a => new AppointmentDto
            {
                Id = a.Id,
                Time = a.Date.TimeOfDay,
                PatientName = a.Patient.Name,
                Phone = a.Patient.Phone
            })
            .ToListAsync();

        for (int i = 0; i < _appointments.Count; i++)
            _appointments[i].Serial = i + 1;

        appointmentsGrd.DataSource = _appointments;
    }

    private void appointmentsGrd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.Value is TimeSpan ts)
        {
            e.Value = DateTime.Today.Add(ts).ToString("hh:mm tt");
            e.FormattingApplied = true;
        }
    }

    private async void appointmentsGrd_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        Appointment? appointment = await ClinicDb.Instance.Appointments
            .Include(a => a.Patient)
            .FirstOrDefaultAsync(a => a.Id == _appointments[e.RowIndex].Id);

        PatientProfilesForm form = AppContext.ShowForm<PatientProfilesForm>();

        form.SetData(appointment);
    }
}
