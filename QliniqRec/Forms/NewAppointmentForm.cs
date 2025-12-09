using Microsoft.EntityFrameworkCore;
using QliniqRec.Database;
using QliniqRec.Database.Models;
using ReaLTaiizor.Forms;

namespace QliniqRec.Forms;

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

        if (_action == AppointmentAction.FollowUp)
            appointment.OriginalAppointmentId = _appointment!.OriginalAppointmentId == null ? _appointment!.Id : _appointment!.OriginalAppointmentId;
        else if (_action == AppointmentAction.Reschedule)
            appointment.OriginalAppointmentId = _appointment!.OriginalAppointmentId;

        ClinicDb.Instance.Appointments.Add(appointment);
        await ClinicDb.Instance.SaveChangesAsync();
        Close();
    }

    private void NewAppointmentForm_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Escape)
        {
            Close();
            e.Handled = true;
        }
    }
}
