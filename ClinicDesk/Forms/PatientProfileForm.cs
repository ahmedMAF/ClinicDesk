using ClinicDesk.ControlHelpers;
using ClinicDesk.Database.Models;
using ClinicDesk.Utilities;
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
        _grdHelper = new VisitsGrid(visitsGrd, true);

        editBtn.Enabled = Settings.Instance.AccountType != AccountType.Doctor;
    }

    internal void SetData(Patient patient)
    {
        _patient = patient;
    }

    private void PatientProfileForm_Load(object sender, EventArgs e)
    {
        chartBtn.Visible = Settings.Instance.AccountType != AccountType.Secretary;
        _grdHelper.RefreshList(null, _patient);
    }

    private async void editBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowDialog<PatientDataForm>(form => form.SetData(_patient));
        _grdHelper.RefreshList(null, _patient);
    }

    private void chartBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowDialog<DentalChartForm>(form => form.SetData(_patient.Teeth!, true));
    }
}
