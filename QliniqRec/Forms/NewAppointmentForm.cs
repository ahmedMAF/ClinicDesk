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

    private void cancelBtn_Click(object sender, EventArgs e)
    {
        AppContext.CloseForm<NewAppointmentForm>();
    }

    private void saveBtn_Click(object sender, EventArgs e)
    {
        Appointment appointment = new()
        {
            PatientId = _patientId,
            Date = dateTimePicker1.Value
        };
        
        ClinicDb.Instance.Appointments.Add(appointment);
        ClinicDb.Instance.SaveChanges();
        
        AppContext.CloseForm<NewAppointmentForm>();
    }

    private async void searchNameBtn_Click(object sender, EventArgs e)
    {
        List<Patient> patients = await ClinicDb.Instance.Patients
            .Where(p => p.Name.Contains(textBox1.Text))
            .ToListAsync();
                
        if (patients.Count == 1)
        {
            // Patient found.
            _patientId = patients[0].Id;
            textBox1.Text = patients[0].Name;
            textBox2.Text = patients[0].Phone;
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
            NewPatientForm form = AppContext.ShowForm<NewPatientForm>();
        }
    }

    private async void searchPhoneBtn_Click(object sender, EventArgs e)
    {
        List<Patient> patients = await ClinicDb.Instance.Patients
            .Where(p => p.Phone != null && p.Phone.Contains(textBox2.Text))
            .ToListAsync();
                
        if (patients.Count == 1)
        {
            // Patient found.
            _patientId = patients[0].Id;
            textBox1.Text = patients[0].Name;
            textBox2.Text = patients[0].Phone;
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
        form.SetData(textBox1.Text, textBox2.Text);
    }
    
    private void ReceiveData(NewPatientForm form, DialogResult result)
    {
        Patient p = form.Patient;
        
        textBox1.Text = p.Name;
        textBox2.Text = p.Phone;
    }
}
