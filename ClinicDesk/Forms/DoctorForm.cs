using ClinicDesk.ControlHelpers;
using ClinicDesk.Database;
using ClinicDesk.Database.Models;
using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class DoctorForm : MaterialForm
{
    private readonly AppointmentsGrid _grdHelper;

    public DoctorForm()
    {
        InitializeComponent();

        _grdHelper = new AppointmentsGrid(appointmentsGrd, AccountType.Doctor);

        FormClosed += (s, e) =>
        {
            ClinicDb.Instance.Client?.RefreshUI -= RefreshUI;
            Application.Exit();
        };

        ClinicDb.Instance.Client?.RefreshUI += RefreshUI;
    }

    private async void DoctorForm_Load(object sender, EventArgs e)
    {
        await _grdHelper.RefreshList();
    }

    private void settingsBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowDialog<SettingsForm>();
        appointmentsGrd.BackgroundColor = Theme.BackgroundColor;
    }

    private void searchBtn_Click(object sender, EventArgs e)
    {
        Patient patient = null!;

        if (AppContext.ShowDialog<PatientSearchForm>(actionAfterShow: (form, _) => patient = form.Patient) == DialogResult.Cancel)
            return;

        AppContext.ShowDialog<PatientProfileForm>(form => form.SetData(patient));
    }

    private async void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
    {
        await _grdHelper.RefreshList(monthCalendar1.SelectionStart.Date);
    }

    private async void RefreshUI()
    {
        if (InvokeRequired)
        {
            BeginInvoke(RefreshUI);
            return;
        }

        await _grdHelper.RefreshList();
    }

    private void aboutBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowDialog<AboutForm>();
    }

    private void statsBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowDialog<StatsForm>();
    }
}
