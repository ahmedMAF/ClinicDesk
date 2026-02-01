using ClinicDesk.ControlHelpers;
using ClinicDesk.Database;
using ClinicDesk.Database.Models;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class AllInOneForm : MaterialForm
{
    private readonly AppointmentsGrid _grdHelper;

    public AllInOneForm()
    {
        InitializeComponent();

        _grdHelper = new AppointmentsGrid(appointmentsGrd, AccountType.AllInOne);

        FormClosed += (s, e) =>
        {
            ClinicDb.Instance.Client?.RefreshUI -= RefreshUI;
            AppointmentApi.NewRequestsRecieved -= NewRequestsRecieved;
            Application.Exit();
        };

        ClinicDb.Instance.Client?.RefreshUI += RefreshUI;
        AppointmentApi.NewRequestsRecieved += NewRequestsRecieved;
    }

    private async void AllInOneForm_Load(object sender, EventArgs e)
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

    private void settingsBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowDialog<SettingsForm>();
        appointmentsGrd.BackgroundColor = Theme.BackgroundColor;
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

    private void NewRequestsRecieved()
    {
        if (InvokeRequired)
        {
            BeginInvoke(NewRequestsRecieved);
            return;
        }

        if (MaterialMessageBox.Show(
            this,
            "New appointment requests need your attention!",
            "Notification",
            MessageBoxButtons.YesNo, false) == DialogResult.Yes)
            AppContext.ShowDialog<AppointmentRequestsForm>();
    }

    private void aboutBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowDialog<AboutForm>();
    }

    private void statsBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowDialog<StatsForm>();
    }

    private async void requestsBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowDialog<AppointmentRequestsForm>();
        await _grdHelper.RefreshList();
    }
}
