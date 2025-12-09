using Microsoft.EntityFrameworkCore;
using QliniqRec.Database;
using QliniqRec.Database.Dto;
using QliniqRec.Database.Models;
using ReaLTaiizor.Forms;

namespace QliniqRec.Forms;

public partial class DoctorForm : MaterialForm
{
    private readonly GridButtonHelper _grdHelper;
    private List<AppointmentDto> _appointments = null!;

    public DoctorForm()
    {
        InitializeComponent();

        FormClosed += (s, e) => Application.Exit();
        Utils.SetupAppointmentsDataGrid(appointmentsGrd, false);

        _grdHelper = new GridButtonHelper(appointmentsGrd, new Dictionary<string, Action<int>>
        {
            ["profileBtn"] = profileBtn_Click
        });
    }

    private async void DoctorForm_Load(object sender, EventArgs e)
    {
        await RefreshList();
    }

    private async void profileBtn_Click(int rowIndex)
    {
        Appointment? appointment = await ClinicDb.Instance.Appointments
            .Include(a => a.OriginalAppointment)
            .FirstOrDefaultAsync(a => a.Id == _appointments[rowIndex].Id);
        
        Patient? patient = await ClinicDb.Instance.Patients
            .Include(p => p.Visits)
            .FirstOrDefaultAsync(p => p.Id == appointment!.PatientId);

        AppContext.ShowDialog<AppointmentForm>(form => form.SetData(appointment!, patient!));

        await RefreshList();
    }
    
    private async Task RefreshList()
    {
        _appointments = await Utils.PopulateAppointmentGrid(appointmentsGrd, DateTime.Now.Date, true);
    }
}
