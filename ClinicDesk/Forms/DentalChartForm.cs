using ClinicDesk.Database.Models;
using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class DentalChartForm : MaterialForm
{
    public DentalChartForm()
    {
        InitializeComponent();
    }

    internal void SetData(List<Tooth> teeth)
    {
        toothChart1.Teeth = teeth;
    }

    private void saveBtn_Click(object sender, EventArgs e)
    {
        Close();
    }
}
