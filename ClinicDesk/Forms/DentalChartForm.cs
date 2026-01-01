using ClinicDesk.Database.Models;
using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class DentalChartForm : MaterialForm
{
    private StringBuilder _sb = new();
    
    public DentalChartForm()
    {
        InitializeComponent();
    }

    internal void SetData(List<Tooth> teeth)
    {
        toothChart1.Teeth = teeth;
    }
    
    private void toothChart1_HoveredToothChanged(object sender, ToothEventArgs e)
    {
        if (e.Tooth == null)
        {
            nameLbl.Text = "";
            contentLbl.Text = "";
            
            return;
        }
        
        nameLbl.Text = $"{e.ToothGraphic.Number} {e.ToothGraphic.Name}";
        
        _sb.Clear();
        _sb.Append("Status: ").Append(tooth.Status).Append(Environment.NewLine);
        
        if (tooth.Crown != ToothCrown.None)
            _sb.Append("Crown: ").Append(tooth.Crown).Append(Environment.NewLine);
        
        if (tooth.Filling != ToothFilling.None)
            _sb.Append("Filling: ").Append(tooth.Filling).Append(Environment.NewLine);
       
        if (!string.IsNullOrWhiteSpaces(tooth.Notes))
            _sb.Append("Notes: ").Append(Environment.NewLine).Append(tooth.Notes);
        
        contentLbl.Text = _sb.ToString();
    }

    private void saveBtn_Click(object sender, EventArgs e)
    {
        Close();
    }
}
