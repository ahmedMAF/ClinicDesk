using ClinicDesk.Database.Models;

namespace ClinicDesk.Controls;

public partial class ToothDropDown : UserControl
{
    private Tooth _tooth = null!;
    private ToolStripDropDown _dropdown = null!;

    public ToothDropDown()
    {
        InitializeComponent();
    }

    internal void SetData(Tooth tooth, ToolStripDropDown dropdown)
    {
        _tooth = tooth;
        _dropdown = dropdown;

        statusCbo.SelectedIndex = (int)tooth.Status;
        crownCbo.SelectedIndex = (int)tooth.Crown;
        fillingCbo.SelectedIndex = (int)tooth.Filling;

        noteTxt.Text = tooth.Notes;
    }

    private void ToothDropDown_Load(object sender, EventArgs e)
    {
        BackColor = Theme.BackdropColor;
    }

    private void saveBtn_Click(object sender, EventArgs e)
    {
        _tooth.Status = (ToothStatus)statusCbo.SelectedIndex;
        _tooth.Crown = (ToothCrown)crownCbo.SelectedIndex;
        _tooth.Filling = (ToothFilling)fillingCbo.SelectedIndex;

        _tooth.Notes = noteTxt.Text;

        _dropdown.Close();
    }
}
