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

        FormClosed += (s, e) => Application.Exit();
        FormClosing += (s, e) => SignalR.DatabaseChanged -= RefreshUI;
        
        _grdHelper = new AppointmentsGrid(appointmentsGrd, AccountType.Secretary);
    }

    private async void SecretaryForm_Load(object sender, EventArgs e)
    {
        SignalR.DatabaseChanged += RefreshUI;
        
        await RefreshUI();
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
        await RefreshUI();
    }

    private void billingSearchBtn_Click(object sender, EventArgs e)
    {
        Patient patient = null!;

        if (AppContext.ShowDialog<PatientSearchForm>(actionAfterShow: (form, _) => patient = form.Patient) == DialogResult.Cancel)
            return;

        AppContext.ShowDialog<BillingForm>(form => form.SetData(patient));
    }
    
    private async Task RefreshUI()
    {
        await _grdHelper.RefreshList();
    }
}
