using System.Management;
using Microsoft.EntityFrameworkCore;
using ClinicDesk.Database;
using ClinicDesk.Database.Models;

namespace ClinicDesk;

internal static class Utils
{
    public static void SetupDataGrid(DataGridView grd)
    {
        grd.AutoGenerateColumns = false;
        grd.AllowUserToAddRows = false;
        grd.AllowUserToDeleteRows = false;
        grd.AllowUserToOrderColumns = true;
        grd.BackgroundColor = Color.White;
        grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        grd.ReadOnly = true;
        grd.RowHeadersWidth = 50;
    }

    public static void SetupPatientsDataGrid(DataGridView patientsGrd)
    {
        SetupDataGrid(patientsGrd);

        patientsGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 50,
            DataPropertyName = "Serial",
            HeaderText = "No."
        });

        patientsGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 300,
            DataPropertyName = "Name",
            HeaderText = "Name"
        });

        patientsGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 120,
            DataPropertyName = "Phone",
            HeaderText = "Phone"
        });

        patientsGrd.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "chooseBtn",
            Width = 180,
            HeaderText = "",
            Text = "Choose",
            UseColumnTextForButtonValue = true
        });
    }

    public static void SetupInvoicesDataGrid(DataGridView invoicesGrd)
    {
        SetupDataGrid(invoicesGrd);

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
            Name = "detailsBtn",
            Width = 120,
            HeaderText = "",
            Text = "Details",
            UseColumnTextForButtonValue = true
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

    public static void SetupPaymentsDataGrid(DataGridView paymentsGrd)
    {
        SetupDataGrid(paymentsGrd);

        paymentsGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 50,
            DataPropertyName = "Serial",
            HeaderText = "No."
        });

        paymentsGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 180,
            DataPropertyName = "Amount",
            HeaderText = "Amount",
            DefaultCellStyle = { Format = "0.00" }
        });

        paymentsGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 180,
            DataPropertyName = "Method",
            HeaderText = "Method"
        });

        paymentsGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 200,
            DataPropertyName = "PaidAt",
            HeaderText = "Paid At",
            DefaultCellStyle = { Format = "dd-MM-yyyy hh:mm tt" }
        });

        paymentsGrd.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "deleteBtn",
            Width = 120,
            HeaderText = "",
            Text = "Delete",
            UseColumnTextForButtonValue = true
        });
    }
    
    public static async Task MarkMissedAppointments()
    {
        List<Appointment> appointments = await ClinicDb.Instance.Appointments
            .Where(a => a.Status == AppointmentStatus.Pending)
            .ToListAsync();
            
        foreach (Appointment appointment in appointments)
            if (appointment.Date.AddMinutes(30) < DateTime.Now)
                appointment.Status = AppointmentStatus.Missed;
                
        await ClinicDb.Instance.SaveChangesAsync();
    }

    public static void NumTxt_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            e.Handled = true;

        // Allow only ONE decimal point
        if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
            e.Handled = true;
    }

    public static int GetHardwareId()
    {
        string cpu = GetWMI("Win32_Processor", "ProcessorId");
        string disk = GetWMI("Win32_DiskDrive", "SerialNumber");
        string board = GetWMI("Win32_BaseBoard", "SerialNumber");

        return $"{cpu}-{disk}-{board}".GetHashCode();
    }
    
    private static string GetWMI(string wmiClass, string wmiProperty)
    {
        using ManagementObjectSearcher searcher = new($"SELECT {wmiProperty} FROM {wmiClass}");
        
        foreach (ManagementBaseObject? obj in searcher.Get())
            return obj[wmiProperty]?.ToString() ?? "";
            
        return "";
    }
}
