using QliniqRec.Database;
using QliniqRec.Database.Dto;
using QliniqRec.Database.Models;

namespace QliniqRec.Forms;

public partial class AppointmentForm : Form
{
    private Appointment _appointment = null!;
    private Patient _patient = null!;
    private int? _originalVisitId;

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

        PopulateVisitsGrd(_originalVisitId);
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

    private void visitsGrd_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        // FIXME: ArgumentOutOfRangeException
        if (visitsGrd.Rows[e.RowIndex].DataBoundItem is not VisitDto visit)
            return;

        PopulateVisitsGrd(visit.Id == -1 ? null : visit.Id);
    }

    private void appointmentsGrd_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
    {
        if (visitsGrd.Rows[e.RowIndex].DataBoundItem is not VisitDto visit)
            return;

        if (visit.Id == -1)
        {
            visitsGrd.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            visitsGrd.Rows[e.RowIndex + 1].DefaultCellStyle.BackColor = Color.LightBlue;
        }
    }

    private void PopulateVisitsGrd(int? originalVisitId)
    {
        List<VisitDto> visits = _patient.Visits
            .Where(v => v.OriginalVisitId == originalVisitId)
            .Select(v => new VisitDto
            {
                Id = v.Id,
                CheckInAt = v.CheckInAt,
                Type = v.Type,
                Diagnosis = v.Diagnosis,
                Treatment = v.Treatment,
            })
            .ToList();

        // For the backward row
        if (originalVisitId.HasValue)
        {
            // Show original visit.
            VisitDto? orgVisit = _patient.Visits
                .Select(v => new VisitDto
                {
                    Id = v.Id,
                    CheckInAt = v.CheckInAt,
                    Type = v.Type,
                    Diagnosis = v.Diagnosis,
                    Treatment = v.Treatment,
                })
                .FirstOrDefault(v => v.Id == originalVisitId);

            visits.InsertRange(0, [new VisitDto
            {
                Id = -1,
                Diagnosis = "Back to all visits..."
            }, orgVisit!]);

            for (int i = 1; i < visits.Count; i++)
                visits[i].Serial = i;
        }
        else
        {
            for (int i = 0; i < visits.Count; i++)
                visits[i].Serial = i + 1;
        }

        visitsGrd.DataSource = visits;
    }

    private void cancelBtn_Click(object sender, EventArgs e)
    {
        Close();
    }
}
