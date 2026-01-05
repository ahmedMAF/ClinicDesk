using ClinicDesk.ControlHelpers;
using ClinicDesk.Database;
using ClinicDesk.Database.Models;
using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class SecretaryForm : MaterialForm
{
    private readonly AppointmentsGrid _grdHelper;

    public SecretaryForm()
    {
        InitializeComponent();

        _grdHelper = new AppointmentsGrid(appointmentsGrd, AccountType.Secretary);

        FormClosed += (s, e) =>
        {
            ClinicDb.Instance.Client.RefreshUI -= RefreshUI;
            Application.Exit();
        };

        ClinicDb.Instance.Client.RefreshUI += RefreshUI;
    }

    private async void SecretaryForm_Load(object sender, EventArgs e)
    {
        await _grdHelper.RefreshList();
    }

    private async void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
    {
        await _grdHelper.RefreshList(monthCalendar1.SelectionStart.Date);
    }

    private async void newAppointmentBtn_Click(object sender, EventArgs e)
    {
        Patient patient = null!;

        if (AppContext.ShowDialog<PatientSearchForm>(actionAfterShow: (form, _) => patient = form.Patient) == DialogResult.Cancel)
            return;

        AppContext.ShowDialog<NewAppointmentForm>(form => form.SetData(patient));
        await _grdHelper.RefreshList();
    }

    private void billingSearchBtn_Click(object sender, EventArgs e)
    {
        Patient patient = null!;

        if (AppContext.ShowDialog<PatientSearchForm>(actionAfterShow: (form, _) => patient = form.Patient) == DialogResult.Cancel)
            return;

        AppContext.ShowDialog<BillingForm>(form => form.SetData(patient));
    }

    private async void RefreshUI()
    {
        await _grdHelper.RefreshList();
    }

    private void settingsBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowDialog<SettingsForm>();
    }
}
