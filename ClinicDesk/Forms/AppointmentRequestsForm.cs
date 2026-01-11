using ClinicDesk.ControlHelpers;
using ClinicDesk.Database.Dto;
using ClinicDesk.Utilities;
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
        AppContext.ShowDialog<NewAppointmentForm>(form => form.SetData(AppointmentApi.Requests[rowIndex]));

        await AppointmentApi.SendRemoveRequest(_requests[rowIndex].Id);
        AppointmentApi.Requests.RemoveAt(rowIndex);
        RefreshUI();
    }
}
