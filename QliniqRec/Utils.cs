using System.Management;
using Microsoft.EntityFrameworkCore;
using QliniqRec.Database;
using QliniqRec.Database.Dto;
using QliniqRec.Database.Models;

namespace QliniqRec;

internal static class Utils
{
    public static void SetupAppointmentsDataGrid(DataGridView appointmentsGrd, bool addButtonColumns)
    {
        appointmentsGrd.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        appointmentsGrd.AutoGenerateColumns = false;

        appointmentsGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 50,
            DataPropertyName = "Serial",
            HeaderText = "No."
        });

        appointmentsGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 300,
            DataPropertyName = "PatientName",
            HeaderText = "Name"
        });

        appointmentsGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 90,
            DataPropertyName = "Time",
            HeaderText = "Time",
            DefaultCellStyle = { Format = "hh:mm tt" }
        });

        appointmentsGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 120,
            DataPropertyName = "Phone",
            HeaderText = "Phone"
        });

        if (!addButtonColumns)
            return;
            
        appointmentsGrd.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "followupBtn",
            Width = 120,
            HeaderText = "",
            Text = "Follow Up",
            UseColumnTextForButtonValue = true
        });
        
        appointmentsGrd.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "rescheduleBtn",
            Width = 120,
            HeaderText = "",
            Text = "Reschedule",
            UseColumnTextForButtonValue = true
        });
        
        appointmentsGrd.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "cancelBtn",
            Width = 120,
            HeaderText = "",
            Text = "Cancel",
            UseColumnTextForButtonValue = true
        });
    }
    
    public static async Task<List<AppointmentDto>> PopulateAppointmentGrid(DataGridView appointmentsGrd, DateTime date)
    {
        List<AppointmentDto> appointments = await ClinicDb.Instance.Appointments
            .AsNoTracking()
            .Where(a => a.Date.Date == date)
            .OrderBy(a => a.Date)
            .Select(a => new AppointmentDto
            {
                Id = a.Id,
                Time = a.Date,
                PatientName = a.Patient.Name,
                Phone = a.Patient.Phone!
            })
            .ToListAsync();

        for (int i = 0; i < _appointments.Count; i++)
            appointments[i].Serial = i + 1;

        appointmentsGrd.DataSource = appointments;
        
        return appointments;
    }
    
    public static string GetHardwareId()
    {
        string cpu = GetWMI("Win32_Processor", "ProcessorId");
        string disk = GetWMI("Win32_DiskDrive", "SerialNumber");
        string board = GetWMI("Win32_BaseBoard", "SerialNumber");
        return $"{cpu}-{disk}-{board}";
    }
    
    private static string GetWMI(string wmiClass, string wmiProperty)
    {
        using ManagementObjectSearcher searcher = new($"SELECT {wmiProperty} FROM {wmiClass}");
        
        foreach (var obj in searcher.Get())
            return obj[wmiProperty]?.ToString() ?? "";
            
        return "";
    }
}
