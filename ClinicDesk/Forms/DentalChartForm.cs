using ClinicDesk.Controls;
using ClinicDesk.Database.Models;
using ReaLTaiizor.Forms;
using System.Text;

namespace ClinicDesk.Forms;

public partial class DentalChartForm : MaterialForm
{
    private readonly StringBuilder _sb = new();
    
    public DentalChartForm()
    {
        InitializeComponent();
    }

    internal void SetData(List<Tooth> teeth, bool isReadonly = false)
    {
        toothChart1.Teeth = teeth;
        toothChart1.IsReadonly = isReadonly;
    }
    
    private void toothChart1_HoveredToothChanged(object sender, ToothEventArgs e)
    {
        if (e.Tooth == null)
        {
            nameLbl.Text = "";
            contentLbl.Text = "";
            
            return;
        }
        
        nameLbl.Text = $"{e.ToothGraphic!.Number} {e.ToothGraphic.Name}";
        
        _sb.Clear();
        _sb.Append("Status: ").Append(e.Tooth.Status).Append(Environment.NewLine);
        
        if (e.Tooth.Crown != ToothCrown.None)
            _sb.Append("Crown: ").Append(e.Tooth.Crown).Append(Environment.NewLine);
        
        if (e.Tooth.Filling != ToothFilling.None)
            _sb.Append("Filling: ").Append(e.Tooth.Filling).Append(Environment.NewLine);
       
        if (!string.IsNullOrWhiteSpace(e.Tooth.Notes))
            _sb.Append(Environment.NewLine).Append("Notes: ").Append(Environment.NewLine).Append(e.Tooth.Notes);
        
        contentLbl.Text = _sb.ToString();
    }

    private void saveBtn_Click(object sender, EventArgs e)
    {
        Close();
    }
}
