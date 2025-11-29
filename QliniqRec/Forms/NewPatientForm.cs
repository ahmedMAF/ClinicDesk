using QliniqRec.Database;
using QliniqRec.Database.Models;

namespace QliniqRec.Forms;

public partial class NewPatientForm : Form
{
    private readonly HashSet<string> _chronicDiseases = [];

    internal Patient Patient { get; private set; } = null!;

    public NewPatientForm()
    {
        InitializeComponent();
    }

    internal void SetData(string name, string phone)
    {
        nameTxt.Text = name;
        phoneTxt.Text = phone;
    }

    private void disOtherChk_CheckedChanged(object sender, EventArgs e)
    {
        disOtherTxt.Enabled = disOtherChk.Checked;

        if (disOtherChk.Checked)
            disOtherTxt.Text = "";
    }

    private void saveBtn_Click(object sender, EventArgs e)
    {
        if (disOtherChk.Checked)
        {
            string[] otherChronicDiseases = disOtherTxt.Text.Split("\r\n");

            foreach (string diseases in otherChronicDiseases)
                _chronicDiseases.Add(diseases);
        }

        Patient = new Patient
        {
            Name = nameTxt.Text,
            Phone = phoneTxt.Text,
            Sex = (Sex)sexCbo.SelectedIndex,
            MaritalStatus = (MaritalStatus)maritalCbo.SelectedIndex,
            DateOfBirth = dobPkr.Value,
            BloodType = (BloodType)bloodTypeCbo.SelectedIndex,
            ChronicDiseases = [.. _chronicDiseases],
            Notes = notesTxt.Text
        };

        ClinicDb.Instance.Patients.Add(Patient);
        ClinicDb.Instance.SaveChanges();

        DialogResult = DialogResult.OK;
        Close();
    }

    private void cancelBtn_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void chronicDiseasesChk_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox chk = (CheckBox)sender;

        if (chk.Checked)
            _chronicDiseases.Add(chk.Text);
        else
            _chronicDiseases.Remove(chk.Text);
    }
}
