using ClinicDesk.ControlHelpers;
using ClinicDesk.Database;
using ClinicDesk.Database.Models;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class MainForm : MaterialForm
{
    private readonly AppointmentsGrid _grdHelper;
    private readonly SemaphoreSlim _refreshLock = new(1, 1);

    public MainForm()
    {
        InitializeComponent();

        Settings settings = Settings.Instance;

        _grdHelper = new AppointmentsGrid(appointmentsGrd, settings.AccountType);

        bool notDoctor = settings.AccountType != AccountType.Doctor;
        bool useApi = settings.UseApi && notDoctor;

        requestsBtn.Visible = useApi;
        newAppointmentBtn.Visible = notDoctor;
        newPatientBtn.Visible = notDoctor;
        billingBtn.Visible = notDoctor;

        bool showConnectionIndicator = settings.UseConnectionCheck && settings.AccountType != AccountType.AllInOne;
        statusStrip.Visible = showConnectionIndicator;

        if (!showConnectionIndicator)
        {
            
        }

        if (!notDoctor)
        {
            searchBtn.Location = new Point(701, 73);
            statsBtn.Location = new Point(701, 130);
        }

        FormClosed += (s, e) =>
        {
            if (showConnectionIndicator)
                ClinicDb.ConnectionStateChanged -= ConnectionStateChanged;

            if (useApi)
                AppointmentApi.NewRequestsRecieved -= NewRequestsRecieved;

            Application.Exit();
        };

        if (showConnectionIndicator)
            ClinicDb.ConnectionStateChanged += ConnectionStateChanged;

        if (useApi)
            AppointmentApi.NewRequestsRecieved += NewRequestsRecieved;
    }

    private async void MainForm_Load(object sender, EventArgs e)
    {
        await _grdHelper.RefreshList();
    }

    private async void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
    {
        // already running, ignore this call
        if (!await _refreshLock.WaitAsync(0))
            return;

        try
        {
            await _grdHelper.RefreshList(monthCalendar1.SelectionStart.Date);
        }
        finally
        {
            _refreshLock.Release();
        }
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

    private void ConnectionStateChanged(bool isAvailable)
    {
        if (InvokeRequired)
        {
            BeginInvoke(() => ConnectionStateChanged(isAvailable));
            return;
        }

        if (isAvailable)
        {
            conStatusLbl.Image = Properties.Resources.connected;
            conStatusLbl.Text = "Connected";
        }
        else
        {
            conStatusLbl.Image = Properties.Resources.disconnected;
            conStatusLbl.Text = "Disconnected";
        }
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

    private void settingsBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowDialog<SettingsForm>();
        appointmentsGrd.BackgroundColor = Theme.BackgroundColor;
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

    private void newPatientBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowDialog<PatientDataForm>();
    }

    private async void searchBtn_Click(object sender, EventArgs e)
    {
        Patient patient = null!;

        if (AppContext.ShowDialog<PatientSearchForm>(actionAfterShow: (form, _) => patient = form.Patient) == DialogResult.Cancel)
            return;

        AppContext.ShowDialog<PatientProfileForm>(form => form.SetData(patient));
        await _grdHelper.RefreshList();
    }
}
