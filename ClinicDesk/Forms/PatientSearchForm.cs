using Microsoft.EntityFrameworkCore;
using ClinicDesk.Database;
using ClinicDesk.Database.Dto;
using ClinicDesk.Database.Models;
using ReaLTaiizor.Forms;
using System.Data;
using ClinicDesk.ControlHelpers;

namespace ClinicDesk.Forms;

public partial class PatientSearchForm : MaterialForm
{
    private List<Patient> _patients = null!;
    private readonly GridButtonHelper _patientGrid;

    internal Patient Patient { get; private set; } = null!;

    public PatientSearchForm()
    {
        InitializeComponent();

        Utils.SetupPatientsDataGrid(patientsGrd);
        _patientGrid = new GridButtonHelper(patientsGrd, new Dictionary<string, Action<int>>
        {
            ["chooseBtn"] = chooseBtn_Click
        });
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

        _patients = await ClinicDb.Instance.Patients
            .AsNoTracking()
            .Where(p => p.Name.Contains(nameTxt.Text))
            .ToListAsync();

        CheckSearchResult();
    }

    private async void searchPhoneBtn_Click(object sender, EventArgs e)
    {
        if (phoneTxt.Text == "")
        {
            MessageBox.Show("Enter a patient's phone number or a part of it to search!", "Search Result");
            return;
        }

        _patients = await ClinicDb.Instance.Patients
            .AsNoTracking()
            .Where(p => p.Phone != null && p.Phone.Contains(phoneTxt.Text))
            .ToListAsync();

        CheckSearchResult();
    }

    private void CheckSearchResult()
    {
        if (_patients.Count == 1)
        {
            // Patient found.
            Patient = _patients[0];
            DialogResult = DialogResult.OK;
            Close();

            return;
        }

        if (_patients.Count > 1)
        {
            // Search was ambiguous.
            List<PatientDto> patientsResult = _patients
                .Select(p => new PatientDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Phone = p.Phone!
                })
                .ToList();

            patientsGrd.DataSource = patientsResult;

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

    private void chooseBtn_Click(int rowIndex)
    {
        // Safe-guard to account for row sorting.
        PatientDto patient = (PatientDto)patientsGrd.Rows[rowIndex].DataBoundItem!;
        Patient = _patients.FirstOrDefault(p => p.Id == patient.Id)!;
        DialogResult = DialogResult.OK;
        Close();
    }
}
