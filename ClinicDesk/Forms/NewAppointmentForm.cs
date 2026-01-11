using ClinicDesk.Database;
using ClinicDesk.Database.Models;
using ReaLTaiizor.Forms;
using ClinicDesk.ControlHelpers;

namespace ClinicDesk.Forms;

public partial class NewAppointmentForm : MaterialForm
{
    private Patient _patient = null!;
    private AppointmentAction _action;
    private Appointment? _appointment;

    public NewAppointmentForm()
    {
        InitializeComponent();
    }

    internal void SetData(Appointment appointment, AppointmentAction action)
    {
        _action = action;

        _appointment = appointment;
        SetData(appointment.Patient);
    }


    internal void SetData(AppointmentRequest appointmentRequest)
    {

    }

    internal void SetData(Patient patient)
    {
        _patient = patient;

        nameTxt.Text = patient.Name;
        phoneTxt.Text = patient.Phone;

        saveBtn.Enabled = true;
    }

    private void NewAppointmentForm_Load(object sender, EventArgs e)
    {
        datePkr.Value = DateTime.Now;
    }

    private void cancelBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private async void saveBtn_Click(object sender, EventArgs e)
    {
        Appointment appointment = new()
        {
            PatientId = _patient.Id,
            Date = datePkr.Value.Date + timePkr.Value.TimeOfDay
        };

        bool confict = ClinicDb.Instance.Appointments
            .Any(a => a.Status == AppointmentStatus.Pending && appointment.Date >= a.Date.AddMinutes(-11) && appointment.Date <= a.Date.AddMinutes(10));

        if (confict && MessageBox.Show($"There is another pending appointment in this time.{Environment.NewLine}Are you sure you want to continue?", "Conflict", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            return;

        if (_action == AppointmentAction.FollowUp)
            appointment.OriginalAppointmentId = _appointment!.OriginalAppointmentId == null ? _appointment!.Id : _appointment!.OriginalAppointmentId;
        else if (_action == AppointmentAction.Reschedule)
            appointment.OriginalAppointmentId = _appointment!.OriginalAppointmentId;

        ClinicDb.Instance.Appointments.Add(appointment);
        await ClinicDb.Instance.SaveChangesAsync();
        Close();
    }
}
