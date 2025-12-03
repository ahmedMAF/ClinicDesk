using Microsoft.EntityFrameworkCore;
using QliniqRec.Database;
using QliniqRec.Database.Dto;
using QliniqRec.Database.Models;

namespace QliniqRec.Forms;

public partial class DoctorForm : Form
{
    private List<AppointmentDto> _appointments = null!;

    public DoctorForm()
    {
        InitializeComponent();

        FormClosed += (s, e) => Application.Exit();
        Utils.SetupAppointmentsDataGrid(appointmentsGrd, false);
    }

    private async void DoctorForm_Load(object sender, EventArgs e)
    {
        _appointments = await Utils.PopulateAppointmentGrid(appointmentsGrd, DateTime.Now.Date);
    }

    private async void appointmentsGrd_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.RowIndex == -1 || e.ColumnIndex == -1 || appointmentsGrd.Columns[e.ColumnIndex] is not DataGridViewButtonColumn)
            return;

        Appointment? appointment = await ClinicDb.Instance.Appointments
            .Include(a => a.OriginalAppointment)
            .FirstOrDefaultAsync(a => a.Id == _appointments[e.RowIndex].Id);
        
        Patient? patient = await ClinicDb.Instance.Patients
            .Include(p => p.Visits)
            .FirstOrDefaultAsync(p => p.Id == appointment!.PatientId);

        AppContext.ShowForm<AppointmentForm>(form => form.SetData(appointment!, patient!));
    }
}
