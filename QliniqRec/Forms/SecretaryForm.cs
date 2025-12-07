using Microsoft.EntityFrameworkCore;
using QliniqRec.Database;
using QliniqRec.Database.Dto;
using QliniqRec.Database.Models;
using ReaLTaiizor.Forms;
using System.Windows.Forms;

namespace QliniqRec.Forms;

public partial class SecretaryForm : MaterialForm
{
    private readonly Dictionary<string, Action<int>> _columnActions;
    private List<AppointmentDto> _appointments = null!;

    public SecretaryForm()
    {
        InitializeComponent();

        FormClosed += (s, e) => Application.Exit();
        Utils.SetupAppointmentsDataGrid(appointmentsGrd, true);
        
        _columnActions = new Dictionary<string, Action<int>>
        {
            ["profileBtn"] = profileBtn_Click,
            ["billingBtn"] = billingBtn_Click,
            ["followupBtn"] = followupBtn_Click,
            ["rescheduleBtn"] = rescheduleBtn_Click,
            ["cancelBtn"] = cancelBtn_Click
        };
    }

    private async void SecretaryForm_Load(object sender, EventArgs e)
    {
        monthCalendar1.SelectionStart = DateTime.Now;
        _appointments = await Utils.PopulateAppointmentGrid(appointmentsGrd, monthCalendar1.SelectionStart.Date);
    }

    private async void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
    {
        _appointments = await Utils.PopulateAppointmentGrid(appointmentsGrd, monthCalendar1.SelectionStart.Date);
    }

    private async void newAppointmentBtn_Click(object sender, EventArgs e)
    {
        Patient patient = null!;
        
        if (AppContext.ShowDialog<PatientSearchForm>(actionAfterShow: (form, _) => patient = form.Patient) == DialogResult.Cancel)
            return;
        
        AppContext.ShowDialog<NewAppointmentForm>(form => form.SetData(patient));
        _appointments = await Utils.PopulateAppointmentGrid(appointmentsGrd, monthCalendar1.SelectionStart.Date);
    }

    private void billingSearchBtn_Click(object sender, EventArgs e)
    {
        Patient patient = null!;
        
        if (AppContext.ShowDialog<PatientSearchForm>(actionAfterShow: (form, _) => patient = form.Patient) == DialogResult.Cancel)
            return;
            
        AppContext.ShowDialog<BillingForm>(form => form.SetData(patient));
    }

    private async void profileBtn_Click(int rowIndex)
    {
        Patient? patient = await ClinicDb.Instance.Patients
            .FirstOrDefaultAsync(p => p.Id == _appointments[rowIndex].PatientId);

        AppContext.ShowForm<PatientProfileForm>(form => form.SetData(patient!));
    }

    private async void billingBtn_Click(int rowIndex)
    {
        Patient? patient = await ClinicDb.Instance.Patients
            .FirstOrDefaultAsync(p => p.Id == _appointments[rowIndex].PatientId);

        AppContext.ShowDialog<BillingForm>(form => form.SetData(patient!));
    }

    private async void followupBtn_Click(int rowIndex)
    {
        Appointment? appointment = await ClinicDb.Instance.Appointments
            .Include(a => a.Patient)
            .FirstOrDefaultAsync(a => a.Id == _appointments[rowIndex].Id);

        AppContext.ShowForm<NewAppointmentForm>(form => form.SetData(appointment!, AppointmentAction.FollowUp));
        
        _appointments = await Utils.PopulateAppointmentGrid(appointmentsGrd, monthCalendar1.SelectionStart.Date);
    }
    
    private async void rescheduleBtn_Click(int rowIndex)
    {
        Appointment? appointment = await ClinicDb.Instance.Appointments
            .Include(a => a.Patient)
            .FirstOrDefaultAsync(a => a.Id == _appointments[rowIndex].Id);

        appointment!.Status = AppointmentStatus.Rescheduled;
        AppContext.ShowForm<NewAppointmentForm>(form => form.SetData(appointment!, AppointmentAction.Reschedule));
        
        _appointments = await Utils.PopulateAppointmentGrid(appointmentsGrd, monthCalendar1.SelectionStart.Date);
    }
    
    private async void cancelBtn_Click(int rowIndex)
    {
        Appointment? appointment = await ClinicDb.Instance.Appointments
            .Include(a => a.Patient)
            .FirstOrDefaultAsync(a => a.Id == _appointments[rowIndex].Id);

        appointment!.Status = AppointmentStatus.Cancelled;
        await ClinicDb.Instance.SaveChangesAsync();
        
        _appointments = await Utils.PopulateAppointmentGrid(appointmentsGrd, monthCalendar1.SelectionStart.Date);
    }

    private async void appointmentsGrd_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex == -1 || e.ColumnIndex == -1 || appointmentsGrd.Columns[e.ColumnIndex] is not DataGridViewButtonColumn)
            return;
            
        string colName = appointmentsGrd.Columns[e.ColumnIndex].Name;
        _columnActions[colName](e.RowIndex);
    }
}

public enum AppointmentAction
{
    New,
    FollowUp,
    Reschedule
}
