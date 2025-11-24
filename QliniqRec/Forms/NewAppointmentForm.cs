namespace QliniqRec.Forms;

public partial class NewAppointmentForm : Form
{
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
        AppContext.CloseForm<NewAppointmentForm>();
    }

    private void searchNameBtn_Click(object sender, EventArgs e)
    {
        List<Patient> patients = ClinicDb.Patients
            .Where(p => p.Name.Contains(textBox1.Text))
            .ToList();
                
        if (patients.Count == 1)
        {
            // Patient found.

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

    private void searchPhoneBtn_Click(object sender, EventArgs e)
    {
        List<Patient> patients = ClinicDb.Patients
            .Where(p => p.Phone.Contains(textBox2.Text))
            .ToList();
                
        if (patients.Count == 1)
        {
            // Patient found.

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
}
