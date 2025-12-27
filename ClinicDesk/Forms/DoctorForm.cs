using ReaLTaiizor.Forms;
using ClinicDesk.ControlHelpers;
using ClinicDesk.Database;

namespace ClinicDesk.Forms;

public partial class DoctorForm : MaterialForm
{
    private readonly AppointmentsGrid _grdHelper;

    public DoctorForm()
    {
        InitializeComponent();

        FormClosed += (s, e) => Application.Exit();
        FormClosing += (s, e) => SignalR.DatabaseChanged -= RefreshUI;
        
        _grdHelper = new AppointmentsGrid(appointmentsGrd, AccountType.Doctor);
    }

    private async void DoctorForm_Load(object sender, EventArgs e)
    {
        SignalR.DatabaseChanged += RefreshUI;
        
        await RefreshUI();
    }
    
    private async Task RefreshUI()
    {
        await _grdHelper.RefreshList();
    }
}
