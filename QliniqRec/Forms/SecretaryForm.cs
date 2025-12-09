using Microsoft.EntityFrameworkCore;
using QliniqRec.Database;
using QliniqRec.Database.Dto;
using QliniqRec.Database.Models;
using ReaLTaiizor.Forms;
using System.Windows.Forms;

namespace QliniqRec.Forms;

public partial class SecretaryForm : MaterialForm
{
    private readonly GridButtonHelper _grdHelper;
    private List<AppointmentDto> _appointments = null!;

    public SecretaryForm()
    {
        InitializeComponent();

        FormClosed += (s, e) => Application.Exit();
        Utils.SetupAppointmentsDataGrid(appointmentsGrd, true);
        
        _grdHelper = new GridButtonHelper(appointmentsGrd, new Dictionary<string, Action<int>>
        {
            ["profileBtn"] = profileBtn_Click,
            ["billingBtn"] = billingBtn_Click,
            ["followupBtn"] = followupBtn_Click,
            ["rescheduleBtn"] = rescheduleBtn_Click,
            ["cancelBtn"] = cancelBtn_Click
        });
    }

    private async void SecretaryForm_Load(object sender, EventArgs e)
    {
        monthCalendar1.SelectionStart = DateTime.Now;
        await RefreshList();
    }

    private async void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
    {
        await RefreshList();
    }
    
    private void appointmentsGrd_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
    {
        if (appointmentsGrd.Rows[e.RowIndex].DataBoundItem is not AppointmentDto appointment)
            return;

        appointmentsGrd.Rows[e.RowIndex].DefaultCellStyle.BackColor = appointment.Status switch
        {
            AppointmentStatus.Pending => Color.White,
            AppointmentStatus.Attended => Color.LightGreen,
            AppointmentStatus.Cancelled => Color.LightPink,
            AppointmentStatus.Missed => Color.LightGray,
            AppointmentStatus.Rescheduled => Color.LightYellow,
            _ => Color.White
        };
    }

    private async void newAppointmentBtn_Click(object sender, EventArgs e)
    {
        Patient patient = null!;
        
        if (AppContext.ShowDialog<PatientSearchForm>(actionAfterShow: (form, _) => patient = form.Patient) == DialogResult.Cancel)
            return;
        
        AppContext.ShowDialog<NewAppointmentForm>(form => form.SetData(patient));
        await RefreshList();
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

        AppContext.ShowDialog<NewAppointmentForm>(form => form.SetData(appointment!, AppointmentAction.FollowUp));
        
        await RefreshList();
    }
    
    private async void rescheduleBtn_Click(int rowIndex)
    {
        Appointment? appointment = await ClinicDb.Instance.Appointments
            .Include(a => a.Patient)
            .FirstOrDefaultAsync(a => a.Id == _appointments[rowIndex].Id);

        appointment!.Status = AppointmentStatus.Rescheduled;
        AppContext.ShowDialog<NewAppointmentForm>(form => form.SetData(appointment!, AppointmentAction.Reschedule));
        
        await RefreshList();
    }
    
    private async void cancelBtn_Click(int rowIndex)
    {
        Appointment? appointment = await ClinicDb.Instance.Appointments
            .Include(a => a.Patient)
            .FirstOrDefaultAsync(a => a.Id == _appointments[rowIndex].Id);

        appointment!.Status = AppointmentStatus.Cancelled;
        await ClinicDb.Instance.SaveChangesAsync();
        
        await RefreshList();
    }
    
    private async Task RefreshList()
    {
        _appointments = await Utils.PopulateAppointmentGrid(appointmentsGrd, monthCalendar1.SelectionStart.Date, false);
    }
}

public enum AppointmentAction
{
    New,
    FollowUp,
    Reschedule
}
