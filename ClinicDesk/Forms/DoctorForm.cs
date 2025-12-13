using Microsoft.EntityFrameworkCore;
using QliniqRec.Database;
using QliniqRec.Database.Dto;
using QliniqRec.Database.Models;
using ReaLTaiizor.Forms;

namespace QliniqRec.Forms;

public partial class DoctorForm : MaterialForm
{
    private readonly AppointmentsGrid _grdHelper;

    public DoctorForm()
    {
        InitializeComponent();

        FormClosed += (s, e) => Application.Exit();
        
        _grdHelper = new AppointmentsGrid(appointmentsGrd, false);
    }

    private async void DoctorForm_Load(object sender, EventArgs e)
    {
        await _grdHelper.RefreshList();
    }
}
