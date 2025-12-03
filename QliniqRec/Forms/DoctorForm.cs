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
        _appointments = await Utils.PopulateAppointmentGrid(appointmentsGrd, monthCalendar1.SelectionStart.Date);
    }

    private async void appointmentsGrd_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.RowIndex == -1)
            return;
            
        Appointment? appointment = await ClinicDb.Instance.Appointments
            .Include(a => a.Patient)
            .Include(a => a.OriginalAppointment)
            .FirstOrDefaultAsync(a => a.Id == _appointments[e.RowIndex].Id);

        AppContext.ShowForm<AppointmentForm>(form => form.SetData(appointment!));
    }
}
