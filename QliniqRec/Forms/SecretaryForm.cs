using Microsoft.EntityFrameworkCore;
using QliniqRec.Database;
using QliniqRec.Database.Dto;
using QliniqRec.Database.Models;
using System.Windows.Forms;

namespace QliniqRec.Forms;

public partial class SecretaryForm : Form
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

    private void newAppBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowForm<NewAppointmentForm>();
    }

    private void billingBtn_Click(object sender, EventArgs e)
    {
    }

    private async void profileBtn_Click(int rowIndex)
    {
        Appointment? appointment = await ClinicDb.Instance.Appointments
            .Include(a => a.Patient)
            .FirstOrDefaultAsync(a => a.Id == _appointments[rowIndex].Id);

        AppContext.ShowForm<PatientProfileForm>(form => form.SetData(appointment!.Patient));
    }

    private async void followupBtn_Click(int rowIndex)
    {
        Appointment? appointment = await ClinicDb.Instance.Appointments
            .Include(a => a.Patient)
            .FirstOrDefaultAsync(a => a.Id == _appointments[rowIndex].Id);

        AppContext.ShowForm<NewAppointmentForm>(form => form.SetData(appointment!, AppointmentAction.FollowUp));
    }
    
    private async void rescheduleBtn_Click(int rowIndex)
    {
        Appointment? appointment = await ClinicDb.Instance.Appointments
            .Include(a => a.Patient)
            .FirstOrDefaultAsync(a => a.Id == _appointments[rowIndex].Id);

        appointment.Status = AppointmentStatus.Rescheduled;
        AppContext.ShowForm<NewAppointmentForm>(form => form.SetData(appointment!, AppointmentAction.Reschedule));
    }
    
    private async void cancelBtn_Click(int rowIndex)
    {
        Appointment? appointment = await ClinicDb.Instance.Appointments
            .Include(a => a.Patient)
            .FirstOrDefaultAsync(a => a.Id == _appointments[rowIndex].Id);

        appointment.Status = AppointmentStatus.Cancelled;
        ClinicDb.Instance.SaveChanges();
        
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
