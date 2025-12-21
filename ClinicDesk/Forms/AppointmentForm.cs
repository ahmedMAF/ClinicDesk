using ClinicDesk.ControlHelpers;
using ClinicDesk.Database;
using ClinicDesk.Database.Models;
using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class AppointmentForm : MaterialForm
{
    private readonly VisitsGrid _grdHelper;

    private Appointment _appointment = null!;
    private Patient _patient = null!;
    private int? _originalVisitId;

    public AppointmentForm()
    {
        InitializeComponent();
        _grdHelper = new VisitsGrid(visitsGrd);
    }

    internal void SetData(Appointment appointment, Patient patient)
    {
        _appointment = appointment;
        _patient = patient;

        if (appointment.OriginalAppointment != null)
            _originalVisitId = appointment.OriginalAppointment.VisitId;
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

        _grdHelper.RefreshList(_originalVisitId, _patient);
    }

    private async void saveBtn_Click(object sender, EventArgs e)
    {
        Visit visit = new()
        {
            PatientId = _patient.Id,
            Type = _originalVisitId == null ? VisitType.FirstVisit : VisitType.Followup,
            OriginalVisitId = _originalVisitId,
            Diagnosis = diagnosisTxt.Text,
            Treatment = treatmentTxt.Text
        };

        ClinicDb.Instance.Visits.Add(visit);

        if (decimal.TryParse(billTxt.Text, out decimal bill) && bill > 0)
        {
            Invoice invoice = new()
            {
                Visit = visit,
                TotalAmount = bill
            };

            ClinicDb.Instance.Invoices.Add(invoice);
        }

        _appointment.Visit = visit;
        _appointment.Status = AppointmentStatus.Attended;
        await ClinicDb.Instance.SaveChangesAsync();

        Close();
    }

    private void cancelBtn_Click(object sender, EventArgs e)
    {
        Close();
    }
}
