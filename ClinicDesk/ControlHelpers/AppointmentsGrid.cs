namespace QliniqRec.ControlHelpers;

public class AppointmentsGrid : GridButtonHelper
{
    private readonly bool _isSecretary;
    
    private DateTime _date = DateTime.Now;
    private List<AppointmentDto> _appointments = null!;
    
    public AppointmentsGrid(DataGridView grd, bool isSecretary) : base(grd, null)
    {
        _isSecretary = isSecretary;
        
        ColumnActions = new Dictionary<string, Action<int>>
        {
            ["profileBtn"] = isSecretary ? profileBtn_Click : visitBtn_Click,
            ["billingBtn"] = billingBtn_Click,
            ["followupBtn"] = followupBtn_Click,
            ["rescheduleBtn"] = rescheduleBtn_Click,
            ["cancelBtn"] = cancelBtn_Click
        }
        
        SetupAppointmentsDataGrid();
    }
    
    private void SetupAppointmentsDataGrid()
    {
        Utils.SetupDataGrid(Grid);
        
        Grid.RowPrePaint += Grid_RowPrePaint;
        Grid.CellPainting += Grid_CellPainting;

        Grid.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 50,
            DataPropertyName = "Serial",
            HeaderText = "No."
        });

        Grid.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 300,
            DataPropertyName = "PatientName",
            HeaderText = "Name"
        });

        Grid.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 90,
            DataPropertyName = "Time",
            HeaderText = "Time",
            DefaultCellStyle = { Format = "hh:mm tt" }
        });

        Grid.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 120,
            DataPropertyName = "Phone",
            HeaderText = "Phone"
        });
        
        Grid.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 90,
            DataPropertyName = "Status",
            HeaderText = "Status"
        });

        if (!_isSecretary)
        {
            Grid.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "profileBtn",
                Width = 180,
                HeaderText = "",
                Text = "Open Visit",
                UseColumnTextForButtonValue = true
            });
        
            return;
        }
            
        Grid.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "profileBtn",
            Width = 180,
            HeaderText = "",
            Text = "View Profile",
            UseColumnTextForButtonValue = true
        });

        Grid.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "billingBtn",
            Width = 120,
            HeaderText = "",
            Text = "Billing",
            UseColumnTextForButtonValue = true
        });

        Grid.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "followupBtn",
            Width = 120,
            HeaderText = "",
            Text = "Follow Up",
            UseColumnTextForButtonValue = true
        });
        
        Grid.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "rescheduleBtn",
            Width = 120,
            HeaderText = "",
            Text = "Reschedule",
            UseColumnTextForButtonValue = true
        });
        
        Grid.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "cancelBtn",
            Width = 120,
            HeaderText = "",
            Text = "Cancel",
            UseColumnTextForButtonValue = true
        });
    }
    
    private async void newAppointmentBtn_Click(object sender, EventArgs e)
    {
        Patient patient = null!;
        
        if (AppContext.ShowDialog<PatientSearchForm>(actionAfterShow: (form, _) => patient = form.Patient) == DialogResult.Cancel)
            return;
        
        AppContext.ShowDialog<NewAppointmentForm>(form => form.SetData(patient));
        await RefreshList();
    }

    private void billingSearchBtn_Click(object sender, EventArgs e)
    {
        Patient patient = null!;
        
        if (AppContext.ShowDialog<PatientSearchForm>(actionAfterShow: (form, _) => patient = form.Patient) == DialogResult.Cancel)
            return;
            
        AppContext.ShowDialog<BillingForm>(form => form.SetData(patient));
    }

    private async void profileBtn_Click(int rowIndex)
    {
        Patient? patient = await ClinicDb.Instance.Patients
            .FirstOrDefaultAsync(p => p.Id == _appointments[rowIndex].PatientId);

        AppContext.ShowForm<PatientProfileForm>(form => form.SetData(patient!));
    }
    
    private async void visitBtn_Click(int rowIndex)
    {
        Appointment? appointment = await ClinicDb.Instance.Appointments
            .Include(a => a.OriginalAppointment)
            .FirstOrDefaultAsync(a => a.Id == _appointments[rowIndex].Id);
        
        Patient? patient = await ClinicDb.Instance.Patients
            .Include(p => p.Visits)
            .FirstOrDefaultAsync(p => p.Id == appointment!.PatientId);

        AppContext.ShowDialog<AppointmentForm>(form => form.SetData(appointment!, patient!));

        await RefreshList();
    }

    private async void billingBtn_Click(int rowIndex)
    {
        Patient? patient = await ClinicDb.Instance.Patients
            .FirstOrDefaultAsync(p => p.Id == _appointments[rowIndex].PatientId);

        AppContext.ShowDialog<BillingForm>(form => form.SetData(patient!));
    }

    private async void followupBtn_Click(int rowIndex)
    {
        Appointment? appointment = await ClinicDb.Instance.Appointments
            .Include(a => a.Patient)
            .FirstOrDefaultAsync(a => a.Id == _appointments[rowIndex].Id);

        AppContext.ShowDialog<NewAppointmentForm>(form => form.SetData(appointment!, AppointmentAction.FollowUp));
        
        await RefreshList();
    }
    
    private async void rescheduleBtn_Click(int rowIndex)
    {
        Appointment? appointment = await ClinicDb.Instance.Appointments
            .Include(a => a.Patient)
            .FirstOrDefaultAsync(a => a.Id == _appointments[rowIndex].Id);

        appointment!.Status = AppointmentStatus.Rescheduled;
        AppContext.ShowDialog<NewAppointmentForm>(form => form.SetData(appointment!, AppointmentAction.Reschedule));
        
        await RefreshList();
    }
    
    private async void cancelBtn_Click(int rowIndex)
    {
        Appointment? appointment = await ClinicDb.Instance.Appointments
            .Include(a => a.Patient)
            .FirstOrDefaultAsync(a => a.Id == _appointments[rowIndex].Id);

        appointment!.Status = AppointmentStatus.Cancelled;
        await ClinicDb.Instance.SaveChangesAsync();
        
        await RefreshList();
    }
    
    private void Grid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
    {
        if (Grid.Rows[e.RowIndex].DataBoundItem is not AppointmentDto appointment)
            return;

        Grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = appointment.Status switch
        {
            AppointmentStatus.Pending => Color.White,
            AppointmentStatus.Attended => Color.LightGreen,
            AppointmentStatus.Cancelled => Color.LightPink,
            AppointmentStatus.Missed => Color.LightGray,
            AppointmentStatus.Rescheduled => Color.LightYellow,
            _ => Color.White
        };
    }
    
    private void Grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.ColumnIndex == -1 || e.RowIndex == -1)
           return;
        
        AppointmentDto appointment = (AppointmentDto)Grid.Rows[e.RowIndex].DataBoundItem;
        
        switch (Grid.Columns[e.ColumnIndex].Name)
        {
            case "followupBtn":
                if (appointment.Status is AppointmentStatus.Missed or AppointmentStatus.Cancelled or AppointmentStatus.Rescheduled)
                    DisableButton();
            
                break;
                
            case "rescheduleBtn":
                if (appointment.Status is AppointmentStatus.Canceled or AppointmentStatus.Rescheduled or AppointmentStatus.Attended)
                    DisableButton();
            
                break;
                
            case "cancelBtn":
                if (appointment.Status is not AppointmentStatus.Pending)
                    DisableButton();
            
                break;
        }
        
        static void DisableButton()
        {
            row.Cells[e.ColumnIndex].ReadOnly = true;
            e.PaintBackground(e.CellBounds, true);
            e.Handled = true;
        }
    }
    
    private async Task RefreshList(DateTime? date = null)
    {
        if (date != null)
            _date = date;
            
        await Utils.MarkMissedAppointments();
        await PopulateGrid();
    }
    
    private async Task PopulateGrid()
    {
        _appointments = await ClinicDb.Instance.Appointments
            .AsNoTracking()
            .Where(a => a.Status == AppointmentStatus.Pending && a.Date.Date == _date)
            .Select(a => new AppointmentDto
            {
                Id = a.Id,
                Time = a.Date,
                PatientName = a.Patient.Name,
                PatientId = a.Patient.Id,
                Phone = a.Patient.Phone!,
                Status = a.Status
            })
            .OrderBy(a => a.Status)
            .ThenBy(a => a.Date)
            .ToListAsync();
            
        for (int i = 0; i < appointments.Count; i++)
            _appointments[i].Serial = i + 1;

        Grid.DataSource = _appointments;
    }
}
