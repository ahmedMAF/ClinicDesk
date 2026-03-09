using ClinicDesk.ControlHelpers;
using ClinicDesk.Database;
using ClinicDesk.Database.Models;
using Lidgren.Network;
using ReaLTaiizor.Forms;
using System.Data;

namespace ClinicDesk.Forms;

public partial class DoctorForm : MaterialForm
{
    private readonly AppointmentsGrid _grdHelper;
    private readonly SemaphoreSlim _refreshLock = new(1, 1);

    public DoctorForm()
    {
        InitializeComponent();

        _grdHelper = new AppointmentsGrid(appointmentsGrd, AccountType.Doctor);

        FormClosed += (s, e) => Application.Exit();
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

    /*private void LanConnectionStateChanged(NetPeerStatus status)
    {
        if (InvokeRequired)
        {
            BeginInvoke(() => LanConnectionStateChanged(status));
            return;
        }

        if (status == NetPeerStatus.Running)
        {
            lanConStatusLbl.Image = Properties.Resources.connected;
            lanConStatusLbl.Text = "LAN: Connected";
        }
        else
        {
            lanConStatusLbl.Image = Properties.Resources.disconnected;
            lanConStatusLbl.Text = "LAN: Disconnected";
        }
    }

    private void DbConnectionStateChanged(object sender, StateChangeEventArgs e)
    {
        if (InvokeRequired)
        {
            BeginInvoke(() => DbConnectionStateChanged(sender, e));
            return;
        }

        if (e.CurrentState == ConnectionState.Open)
        {
            dbConStatusLbl.Image = Properties.Resources.connected;
            dbConStatusLbl.Text = "DB: Connected";
        }
        else
        {
            dbConStatusLbl.Image = Properties.Resources.disconnected;
            dbConStatusLbl.Text = "DB: Disconnected";
        }
    }*/
}
