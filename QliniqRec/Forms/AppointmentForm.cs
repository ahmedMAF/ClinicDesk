using QliniqRec.Database;
using QliniqRec.Database.Dto;
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
        Utils.SetupVisitsDataGrid(visitsGrd);
    }

    internal void SetData(Appointment appointment, Patient patient)
    {
        _appointment = appointment;
        _patient = patient;

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

        List<VisitDto> visits = _patient.Visits.Select(v => new VisitDto
        {
            Id = v.Id,
            CheckInAt = v.CheckInAt,
            Type = v.Type,
            Diagnosis = v.Diagnosis,
            Treatment = v.Treatment,
        }).ToList();

        for (int i = 0; i < visits.Count; i++)
            visits[i].Serial = i + 1;

        visitsGrd.DataSource = visits;
    }

    private async void saveBtn_Click(object sender, EventArgs e)
    {
        Visit visit = new()
        {
            PatientId = _patient.Id,
            Type = _originalVisit == null ? VisitType.FirstVisit : VisitType.Followup,
            OriginalVisitId = _originalVisit?.Id,
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

    private void billTxt_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            e.Handled = true;

        // Allow only ONE decimal point
        if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
            e.Handled = true;
    }
}
