using ClinicDesk.Database;
using ClinicDesk.Database.Models;

namespace ClinicDesk.Forms;

public partial class PatientDataForm : Form
{
    private HashSet<string> _chronicDiseases = [];

    internal Patient Patient { get; private set; } = null!;

    public PatientDataForm()
    {
        InitializeComponent();
    }

    internal void SetData(string name, string phone)
    {
        Text = "Add New Patient";
        nameTxt.Text = name;
        phoneTxt.Text = phone;
    }

    internal void SetData(Patient patient)
    {
        Text = "Edit Patient";
        Patient = patient;

        nameTxt.Text = patient.Name;
        phoneTxt.Text = patient.Phone;
        sexCbo.SelectedIndex = (int)patient.Sex;
        dobPkr.Value = patient.DateOfBirth;
        maritalCbo.SelectedIndex = (int)patient.MaritalStatus;

        bloodTypeCbo.SelectedIndex = (int)patient.BloodType;

        _chronicDiseases = [.. patient.ChronicDiseases];

        foreach (CheckBox chk in chronicDiseasesGrp.Controls.OfType<CheckBox>())
        {
            chk.Checked = _chronicDiseases.Contains(chk.Text);
            _chronicDiseases.Remove(chk.Text);
        }

        disOtherChk.Checked = _chronicDiseases.Count > 0;
        disOtherTxt.Text = string.Join(Environment.NewLine, _chronicDiseases);
        _chronicDiseases.Clear();

        notesTxt.Text = patient.Notes;
    }

    private void disOtherChk_CheckedChanged(object sender, EventArgs e)
    {
        disOtherTxt.Enabled = disOtherChk.Checked;

        if (disOtherChk.Checked)
            disOtherTxt.Text = "";
    }

    private void saveBtn_Click(object sender, EventArgs e)
    {
        foreach (CheckBox chk in chronicDiseasesGrp.Controls.OfType<CheckBox>())
            if (chk.Checked && chk.Name != "disOtherChk")
                _chronicDiseases.Add(chk.Text);

        if (disOtherChk.Checked)
        {
            string[] otherChronicDiseases = disOtherTxt.Text.Split(Environment.NewLine);

            foreach (string diseases in otherChronicDiseases)
                _chronicDiseases.Add(diseases);
        }

        if (Patient == null)
        {
            Patient = new Patient
            {
                Name = nameTxt.Text,
                Phone = phoneTxt.Text,
                Sex = (Sex)sexCbo.SelectedIndex,
                MaritalStatus = (MaritalStatus)maritalCbo.SelectedIndex,
                DateOfBirth = dobPkr.Value.Date,
                BloodType = (BloodType)bloodTypeCbo.SelectedIndex,
                ChronicDiseases = [.. _chronicDiseases],
                Notes = notesTxt.Text
            };

            ClinicDb.Instance.Patients.Add(Patient);
        }
        else
        {
            Patient.Name = nameTxt.Text;
            Patient.Phone = phoneTxt.Text;
            Patient.Sex = (Sex)sexCbo.SelectedIndex;
            Patient.MaritalStatus = (MaritalStatus)maritalCbo.SelectedIndex;
            Patient.DateOfBirth = dobPkr.Value.Date;
            Patient.BloodType = (BloodType)bloodTypeCbo.SelectedIndex;
            Patient.ChronicDiseases = [.. _chronicDiseases];
            Patient.Notes = notesTxt.Text;
        }


        ClinicDb.Instance.SaveChanges();

        DialogResult = DialogResult.OK;
        Close();
    }

    private void cancelBtn_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
