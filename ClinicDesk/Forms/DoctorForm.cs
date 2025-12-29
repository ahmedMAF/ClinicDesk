using ClinicDesk.ControlHelpers;
using ClinicDesk.Database.Models;
using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class DoctorForm : MaterialForm
{
    private readonly AppointmentsGrid _grdHelper;

    public DoctorForm()
    {
        InitializeComponent();

        FormClosed += (s, e) => Application.Exit();

        _grdHelper = new AppointmentsGrid(appointmentsGrd, AccountType.Doctor);
    }

    private async void DoctorForm_Load(object sender, EventArgs e)
    {
        await RefreshUI();
    }

    private async Task RefreshUI()
    {
        await _grdHelper.RefreshList();
    }

    private void settingsBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowDialog<SettingsForm>();
    }

    private void searchBtn_Click(object sender, EventArgs e)
    {
        Patient patient = null!;

        if (AppContext.ShowDialog<PatientSearchForm>(actionAfterShow: (form, _) => patient = form.Patient) == DialogResult.Cancel)
            return;

        AppContext.ShowDialog<PatientDataForm>(form => form.SetData(patient));
    }

    private async void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
    {
        await _grdHelper.RefreshList(monthCalendar1.SelectionStart.Date);
    }
}
