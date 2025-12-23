using ClinicDesk.ControlHelpers;
using ClinicDesk.Database.Models;
using ReaLTaiizor.Child.Material;
using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class PatientProfileForm : MaterialForm
{
    private readonly VisitsGrid _grdHelper;

    private Patient _patient = null!;

    public PatientProfileForm()
    {
        InitializeComponent();
        _grdHelper = new VisitsGrid(visitsGrd);
    }

    internal void SetData(Patient patient)
    {
        _patient = patient;
    }

    private void PatientProfileForm_Load(object sender, EventArgs e)
    {
        RefreshData();
    }

    private void RefreshData()
    {
        nameTxt.Text = _patient.Name;
        sexTxt.Text = _patient.Sex.ToString();
        ageTxt.Text = (_patient.Age.Days / 365).ToString();
        maritalTxt.Text = _patient.MaritalStatus.ToString();

        bloodTypeTxt.Text = Utils.GetBloodTypeString(_patient.BloodType);

        foreach (string disease in _patient.ChronicDiseases)
            chronicDiseasesLst.Items.Add(new MaterialListBoxItem(disease));

        notesTxt.Text = _patient.Notes;

        _grdHelper.RefreshList(null, _patient);
    }

    private async void editBtn_Click(object sender, EventArgs e)
    {
        Hide();
        AppContext.ShowDialog<PatientDataForm>(form => form.SetData(_patient));
        RefreshData();
        Show();
    }
}
