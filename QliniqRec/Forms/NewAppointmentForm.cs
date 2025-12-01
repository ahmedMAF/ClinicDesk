using Microsoft.EntityFrameworkCore;
using QliniqRec.Database;
using QliniqRec.Database.Models;

namespace QliniqRec.Forms;

public partial class NewAppointmentForm : Form
{
    private Patient _patient = null!;
    private Appointment? _appointment;

    public NewAppointmentForm()
    {
        InitializeComponent();
    }

    internal void SetData(Appointment appointment)
    {
        _appointment = appointment;
        _patient = _appointment.Patient;

        nameTxt.Text = _patient.Name;
        phoneTxt.Text = _patient.Phone;

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

    private void saveBtn_Click(object sender, EventArgs e)
    {
        Appointment appointment = new()
        {
            PatientId = _patient.Id,
            OriginalAppointmentId = _appointment?.Id,
            Date = datePkr.Value
        };

        ClinicDb.Instance.Appointments.Add(appointment);
        ClinicDb.Instance.SaveChanges();
        Close();
    }

    private async void searchNameBtn_Click(object sender, EventArgs e)
    {
        List<Patient> patients = await ClinicDb.Instance.Patients
            .AsNoTracking()
            .Where(p => p.Name.Contains(nameTxt.Text))
            .ToListAsync();

        if (patients.Count == 1)
        {
            // Patient found.
            _patient = patients[0];
            nameTxt.Text = _patient.Name;
            phoneTxt.Text = _patient.Phone;
            saveBtn.Enabled = true;

            return;
        }

        if (patients.Count > 1)
        {
            // Search was ambiguous.

            return;
        }

        // Patient not found.
        if (MessageBox.Show("Patient was not found, do you want to add a new patient?", "Search Result", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            AppContext.ShowDialog<NewPatientForm>(SendData, ReceiveData);
        }
    }

    private async void searchPhoneBtn_Click(object sender, EventArgs e)
    {
        List<Patient> patients = await ClinicDb.Instance.Patients
            .AsNoTracking()
            .Where(p => p.Phone != null && p.Phone.Contains(textBox2.Text))
            .ToListAsync();

        if (patients.Count == 1)
        {
            // Patient found.
            _patient = patients[0];
            nameTxt.Text = _patient.Name;
            phoneTxt.Text = _patient.Phone;
            saveBtn.Enabled = true;

            return;
        }

        if (patients.Count > 1)
        {
            // Search was ambiguous.

            return;
        }

        // Patient not found.
        if (MessageBox.Show("Patient was not found, do you want to add a new patient?", "Search Result", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            AppContext.ShowDialog<NewPatientForm>(SendData, ReceiveData);
        }
    }

    private void SendData(NewPatientForm form)
    {
        form.SetData(nameTxt.Text, phoneTxt.Text);
    }

    private void ReceiveData(NewPatientForm form, DialogResult result)
    {
        if (result == DialogResult.Cancel)
            return;

        _patient = form.Patient;

        nameTxt.Text = _patient.Name;
        phoneTxt.Text = _patient.Phone;
        saveBtn.Enabled = true;
    }
}
