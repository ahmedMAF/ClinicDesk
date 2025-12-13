using Microsoft.EntityFrameworkCore;
using QliniqRec.Database;
using QliniqRec.Database.Dto;
using QliniqRec.Database.Models;
using ReaLTaiizor.Forms;
using System.Windows.Forms;

namespace QliniqRec.Forms;

public partial class SecretaryForm : MaterialForm
{
    private readonly AppointmentsGrid _grdHelper;

    public SecretaryForm()
    {
        InitializeComponent();

        FormClosed += (s, e) => Application.Exit();
        
        _grdHelper = new AppointmentsGrid(appointmentsGrd, true);
    }

    private async void SecretaryForm_Load(object sender, EventArgs e)
    {
        await _grdHelper.RefreshList();
    }

    private async void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
    {
        await _grdHelper.RefreshList(monthCalendar1.SelectionStart.Date);
    }
}
