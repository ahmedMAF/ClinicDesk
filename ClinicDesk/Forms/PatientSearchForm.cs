using Microsoft.EntityFrameworkCore;
using QliniqRec.Database;
using QliniqRec.Database.Models;
using ReaLTaiizor.Forms;
using System.Data;

namespace QliniqRec.Forms;

public partial class PatientSearchForm : MaterialForm
{
    internal Patient Patient { get; private set; } = null!;

    public PatientSearchForm()
    {
        InitializeComponent();
    }

    private void PatientSearchForm_Load(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
    }

    private async void searchNameBtn_Click(object sender, EventArgs e)
    {
        if (nameTxt.Text == "")
        {
            MessageBox.Show("Enter a patient's name or a part of it to search!", "Search Result");
            return;
        }

        CheckSearchResult(await ClinicDb.Instance.Patients
            .AsNoTracking()
            .Where(p => p.Name.Contains(nameTxt.Text))
            .ToListAsync());
    }

    private async void searchPhoneBtn_Click(object sender, EventArgs e)
    {
        if (phoneTxt.Text == "")
        {
            MessageBox.Show("Enter a patient's phone number or a part of it to search!", "Search Result");
            return;
        }

        CheckSearchResult(await ClinicDb.Instance.Patients
            .AsNoTracking()
            .Where(p => p.Phone != null && p.Phone.Contains(phoneTxt.Text))
            .ToListAsync());
    }

    private void CheckSearchResult(List<Patient> patients)
    {
        if (patients.Count == 1)
        {
            // Patient found.
            Patient = patients[0];
            DialogResult = DialogResult.OK;
            Close();

            return;
        }

        if (patients.Count > 1)
        {
            // Search was ambiguous.

            return;
        }

        // Patient not found.
        if (MessageBox.Show("Patient was not found, do you want to add a new patient?", "Search Result", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            Hide();

            if (AppContext.ShowDialog<NewPatientForm>(form => form.SetData(nameTxt.Text, phoneTxt.Text), (form, _) => Patient = form.Patient) == DialogResult.Cancel)
            {
                Show();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }

    private void PatientSearchForm_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Escape)
        {
            Close();
            e.Handled = true;
        }
    }

    private void nameTxt_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            searchNameBtn.PerformClick();
            e.Handled = true;
        }
    }

    private void phoneTxt_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            searchPhoneBtn.PerformClick();
            e.Handled = true;
        }
    }
}
