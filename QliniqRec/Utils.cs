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

        appointmentsGrd.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "profileBtn",
            Width = 180,
            HeaderText = "",
            Text = "View Profile",
            UseColumnTextForButtonValue = true
        });

        if (!addButtonColumns)
            return;

        appointmentsGrd.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "billingBtn",
            Width = 120,
            HeaderText = "",
            Text = "Billing",
            UseColumnTextForButtonValue = true
        });

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

    public static void SetupVisitsDataGrid(DataGridView visitsGrd)
    {
        visitsGrd.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        visitsGrd.AutoGenerateColumns = false;

        visitsGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 50,
            DataPropertyName = "Serial",
            HeaderText = "No."
        });

        visitsGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 200,
            DataPropertyName = "CheckInAt",
            HeaderText = "Date",
            DefaultCellStyle = { Format = "dd-MM-yyyy hh:mm tt" }
        });

        visitsGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 300,
            DataPropertyName = "Diagnosis",
            HeaderText = "Diagnosis"
        });

        visitsGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 300,
            DataPropertyName = "Treatment",
            HeaderText = "Treatment"
        });

        visitsGrd.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "showBtn",
            Width = 120,
            HeaderText = "",
            Text = "Show More",
            UseColumnTextForButtonValue = true
        });
    }

    public static void SetupInvoicesDataGrid(DataGridView invoicesGrd)
    {
        invoicesGrd.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        invoicesGrd.AutoGenerateColumns = false;

        invoicesGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 50,
            DataPropertyName = "Serial",
            HeaderText = "No."
        });

        invoicesGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 200,
            DataPropertyName = "IssuedAt",
            HeaderText = "Issued At",
            DefaultCellStyle = { Format = "dd-MM-yyyy hh:mm tt" }
        });

        invoicesGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 180,
            DataPropertyName = "TotalAmount",
            HeaderText = "Total Amount",
            DefaultCellStyle = { Format = "0.00" }
        });

        invoicesGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 180,
            DataPropertyName = "PaidAmount",
            HeaderText = "Paid Amount",
            DefaultCellStyle = { Format = "0.00" }
        });

        invoicesGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 180,
            DataPropertyName = "RemainingAmount",
            HeaderText = "Remaining Amount",
            DefaultCellStyle = { Format = "0.00" }
        });

        invoicesGrd.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "payBtn",
            Width = 120,
            HeaderText = "",
            Text = "Pay",
            UseColumnTextForButtonValue = true
        });

        invoicesGrd.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "payFullBtn",
            Width = 120,
            HeaderText = "",
            Text = "Pay Full",
            UseColumnTextForButtonValue = true
        });
    }

    public static async Task<List<AppointmentDto>> PopulateAppointmentGrid(DataGridView appointmentsGrd, DateTime date)
    {
        List<AppointmentDto> appointments = await ClinicDb.Instance.Appointments
            .AsNoTracking()
            .Where(a => a.Date.Date == date && a.Status == AppointmentStatus.Pending)
            .OrderBy(a => a.Date)
            .Select(a => new AppointmentDto
            {
                Id = a.Id,
                Time = a.Date,
                PatientName = a.Patient.Name,
                PatientId = a.Patient.Id,
                Phone = a.Patient.Phone!
            })
            .ToListAsync();

        for (int i = 0; i < appointments.Count; i++)
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
        
        foreach (ManagementBaseObject? obj in searcher.Get())
            return obj[wmiProperty]?.ToString() ?? "";
            
        return "";
    }
}
