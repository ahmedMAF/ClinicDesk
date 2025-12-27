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
}
