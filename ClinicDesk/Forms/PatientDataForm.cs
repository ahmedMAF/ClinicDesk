using ClinicDesk.Database;
using ClinicDesk.Database.Models;
using ClinicDesk.Utilities;
using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class PatientDataForm : MaterialForm
{
    private HashSet<string> _chronicDiseases = [];

    internal Patient Patient { get; private set; } = null!;

    public PatientDataForm()
    {
        InitializeComponent();
        Text = "Add New Patient";
    }

    internal void SetData(string name, string phone)
    {
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

        disOtherTxt.Text = string.Join(Environment.NewLine, _chronicDiseases);
        _chronicDiseases.Clear();

        notesTxt.Text = patient.Notes;
    }

    private async void saveBtn_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(nameTxt.Text))
        {
            errorProvider.SetError(nameTxt, "Name is required");
            return;
        }

        if (string.IsNullOrWhiteSpace(phoneTxt.Text))
        {
            errorProvider.SetError(phoneTxt, "Phone is required");
            return;
        }

        foreach (CheckBox chk in chronicDiseasesGrp.Controls.OfType<CheckBox>())
            if (chk.Checked && chk.Name != "disOtherChk")
                _chronicDiseases.Add(chk.Text);

        if (!string.IsNullOrWhiteSpace(disOtherTxt.Text))
        {
            string[] otherChronicDiseases = disOtherTxt.Text.Split(Environment.NewLine);

            foreach (string diseases in otherChronicDiseases)
                _chronicDiseases.Add(diseases);
        }

        if (Patient == null)
        {
            Patient = Patient.New();

            Patient.Name = nameTxt.Text;
            Patient.Phone = phoneTxt.Text;
            Patient.Sex = (Sex)sexCbo.SelectedIndex;
            Patient.MaritalStatus = (MaritalStatus)maritalCbo.SelectedIndex;
            Patient.DateOfBirth = dobPkr.Value.Date;
            Patient.BloodType = (BloodType)bloodTypeCbo.SelectedIndex;
            Patient.ChronicDiseases = [.. _chronicDiseases];
            Patient.Notes = notesTxt.Text;

            if (Settings.Instance.IsDental)
                TeethHelper.MarkMissingTeethByAge(Patient.Teeth!, Patient.AgeYears);

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


        await ClinicDb.Instance.SaveChangesAsync();

        DialogResult = DialogResult.OK;
        Close();
    }

    private void ClearError(object sender, EventArgs e)
    {
        errorProvider.SetError((Control)sender, string.Empty);
    }
}
