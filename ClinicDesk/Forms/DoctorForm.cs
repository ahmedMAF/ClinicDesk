using ReaLTaiizor.Forms;
using ClinicDesk.ControlHelpers;

namespace ClinicDesk.Forms;

public partial class DoctorForm : MaterialForm
{
    private readonly AppointmentsGrid _grdHelper;

    public DoctorForm()
    {
        InitializeComponent();

        FormClosed += (s, e) => Application.Exit();
        FormClosing += (s, e) => SignalR.DatabaseChanged -= Refresh;
        
        _grdHelper = new AppointmentsGrid(appointmentsGrd, AccountType.Doctor);
    }

    private async void DoctorForm_Load(object sender, EventArgs e)
    {
        SignalR.DatabaseChanged += Refresh;
        
        await Refresh();
    }
    
    private async void Refresh()
    {
        await _grdHelper.RefreshList();
    }
}
