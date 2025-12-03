using QliniqRec.Database;
using QliniqRec.Database.Models;

namespace QliniqRec.Forms;

public partial class AppointmentForm : Form
{
    private Appointment _appointment = null!;
    private Patient _patient = null!;
    private Visit? _originalVisit;

    public AppointmentForm()
    {
        InitializeComponent();
    }

    internal void SetData(Appointment appointment)
    {
        _appointment = appointment;
        _patient = _appointment.Patient;

        if (appointment.OriginalAppointment != null)
            _originalVisit = appointment.OriginalAppointment.Visit;
    }

    private void AppointmentForm_Load(object sender, EventArgs e)
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

        foreach (Visit visit in _patient.Visits)
        {

        }
    }

    private void saveBtn_Click(object sender, EventArgs e)
    {
        Visit visit = new()
        {
            PatientId = _patient.Id,
            Type = _originalVisit == null ? VisitType.FirstVisit : VisitType.Followup,
            OriginalVisitId = _originalVisit?.Id,
            Diagnosis = diagnosisTxt.Text,
            Treatment = treatmentTxt.Text
        };

        Invoice invoice = new()
        {
            Visit = visit,
            TotalAmount = 0
        };

        _appointment.Visit = visit;
        _appointment.Status = AppointmentStatus.Attended;

        ClinicDb.Instance.Visits.Add(visit);
        ClinicDb.Instance.Invoices.Add(invoice);
        ClinicDb.Instance.SaveChanges();
    }
}
