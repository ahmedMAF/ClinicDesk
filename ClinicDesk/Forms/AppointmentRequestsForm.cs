using ClinicDesk.ControlHelpers;
using ClinicDesk.Database;
using ClinicDesk.Database.Dto;
using ClinicDesk.Database.Models;
using ClinicDesk.Utilities;
using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class AppointmentRequestsForm : MaterialForm
{
    private readonly GridButtonHelper _grdHelper;
    private List<AppointmentRequestDto> _requests = null!;

    public AppointmentRequestsForm()
    {
        InitializeComponent();
        Utils.SetupAppointmentRequestsDataGrid(requestsGrd);

        _grdHelper = new GridButtonHelper(requestsGrd, new Dictionary<string, Action<int>>
        {
            ["createBtn"] = createBtn_Click,
            ["cancelBtn"] = cancelBtn_Click
        });
    }

    private void AppointmentRequestsForm_Load(object sender, EventArgs e)
    {
        RefreshUI();
    }

    private void RefreshUI()
    {
        _requests = AppointmentApi.Requests
            .Select(r => new AppointmentRequestDto
            {
                Id = r.Id,
                Name = r.Name,
                Phone = r.Phone
            })
            .ToList();

        requestsGrd.DataSource = _requests;
    }

    private async void cancelBtn_Click(int rowIndex)
    {
        await AppointmentApi.SendRemoveRequest(_requests[rowIndex].Id);
        AppointmentApi.Requests.RemoveAt(rowIndex);
        RefreshUI();
    }

    private async void createBtn_Click(int rowIndex)
    {
        AppointmentRequest request = AppointmentApi.Requests[rowIndex];

        Patient? patient = await ClinicDb.Instance.Patients
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Name.Contains(request.Name) && (p.Phone == null || p.Phone.Contains(request.Phone)));

        if (patient == null)
        {
            patient = Patient.New();

            patient.Name = request.Name;
            patient.Phone = request.Phone;
            patient.Sex = request.Sex;
            patient.MaritalStatus = request.MaritalStatus;
            patient.DateOfBirth = request.DateOfBirth.Date;
            patient.BloodType = request.BloodType;
            patient.ChronicDiseases = [];

            if (Settings.Instance.IsDental)
                TeethHelper.MarkMissingTeethByAge(patient.Teeth!, patient.AgeYears);

            ClinicDb.Instance.Patients.Add(patient);
            await ClinicDb.Instance.SaveChangesAsync();
        }

        AppContext.ShowDialog<NewAppointmentForm>(form => form.SetData(patient));

        await AppointmentApi.SendRemoveRequest(_requests[rowIndex].Id);
        AppointmentApi.Requests.RemoveAt(rowIndex);
        RefreshUI();
    }
}
