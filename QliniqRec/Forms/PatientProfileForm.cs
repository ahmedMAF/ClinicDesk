using QliniqRec.Database.Models;

namespace QliniqRec.Forms;

public partial class PatientProfileForm : Form
{
    private Patient _patient = null!;

    public PatientProfileForm()
    {
        InitializeComponent();
    }

    internal void SetData(Patient patient)
    {
        _patient = patient;
    }

    private void PatientProfileForm_Load(object sender, EventArgs e)
    {
        nameTxt.Text = _patient.Name;
        sexCbo.SelectedIndex = (int)_patient.Sex;
        dobTxt.Text = _patient.DateOfBirth.ToString("dd-MM-yyyy");
        ageTxt.Text = (_patient.Age.Days / 365).ToString();
        maritalCbo.SelectedIndex = (int)_patient.MaritalStatus;

        bloodTypeCbo.SelectedIndex = (int)_patient.BloodType;

        foreach (string disease in _patient.ChronicDiseases)
            chronicDiseasesLst.Items.Add(disease);

        notesTxt.Text = _patient.Notes;
    }
}
