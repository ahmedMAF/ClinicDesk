using Microsoft.EntityFrameworkCore;
using QliniqRec.Database;
using QliniqRec.Database.Models;

namespace QliniqRec.Forms;

public partial class NewAppointmentForm : Form
{
    private int _patientId;

    public NewAppointmentForm()
    {
        InitializeComponent();
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
            PatientId = _patientId,
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
            _patientId = patients[0].Id;
            nameTxt.Text = patients[0].Name;
            phoneTxt.Text = patients[0].Phone;
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
            _patientId = patients[0].Id;
            nameTxt.Text = patients[0].Name;
            phoneTxt.Text = patients[0].Phone;
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

        Patient p = form.Patient;
        _patientId = p.Id;

        nameTxt.Text = p.Name;
        phoneTxt.Text = p.Phone;
        saveBtn.Enabled = true;
    }
}
