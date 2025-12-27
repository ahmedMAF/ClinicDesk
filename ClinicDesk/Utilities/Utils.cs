using ClinicDesk.Database;
using ClinicDesk.Database.Models;
using Microsoft.EntityFrameworkCore;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace ClinicDesk.Utilities;

internal static class Utils
{
    public static string GetBloodTypeString(BloodType type) => type switch
    {
        BloodType.NotSpecified => "Normal",
        BloodType.APos => "A+",
        BloodType.ANeg => "A-",
        BloodType.BPos => "B+",
        BloodType.BNeg => "B-",
        BloodType.ABPos => "AB+",
        BloodType.ABNeg => "AB-",
        BloodType.OPos => "O+",
        BloodType.ONeg => "O-",
        _ => throw new NotImplementedException(type.ToString())
    };

    public static void SetupDataGrid(DataGridView grd)
    {
        grd.AutoGenerateColumns = false;
        grd.AllowUserToAddRows = false;
        grd.AllowUserToDeleteRows = false;
        grd.AllowUserToOrderColumns = true;
        grd.RowHeadersVisible = false;
        grd.EnableHeadersVisualStyles = false;
        grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grd.MultiSelect = false;
        grd.ReadOnly = true;
        grd.RowHeadersWidth = 50;

        grd.BackgroundColor = Theme.BackdropColor;
        grd.DefaultCellStyle.BackColor = Theme.BackdropColor;
        grd.GridColor = Theme.DataGridLinesColor;

        grd.CellPainting += Grid_CellPainting;
    }
    
    public static Color DarkenColor(Color color, float factor)
    {
        factor = 1f - Math.Clamp(factor, 0f, 1f);
        
        return Color.FromArgb(
            color.A,
            (int)(color.R * factor),
            (int)(color.G * factor),
            (int)(color.B * factor));
    }

    private static void Grid_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex != -1)
            return;

        // Background
        using (Brush backBrush = new SolidBrush(Theme.DataGridHeaderColor))
            e.Graphics.FillRectangle(backBrush, e.CellBounds);

        // Border
        using (Pen borderPen = new(Theme.DataGridLinesColor))
            e.Graphics.DrawRectangle(borderPen,
                e.CellBounds.X,
                e.CellBounds.Y,
                e.CellBounds.Width - 1,
                e.CellBounds.Height - 1);

        // Text
        TextRenderer.DrawText(
            e.Graphics,
            e.FormattedValue.ToString(),
            e.CellStyle.Font,
            e.CellBounds,
            ((DataGridView)sender).ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

        e.Handled = true;
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
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            e.Handled = true;
    }

    public static void NumDotTxt_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            e.Handled = true;

        // Allow only ONE decimal point
        if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
            e.Handled = true;
    }

    public static string GetHardwareId()
    {
        return Convert.ToHexString(GetHardwareIdBytes());
    }
    
    public static byte[] GetHardwareIdBytes()
    {
        string cpu = GetWMI("Win32_Processor", "ProcessorId");
        string disk = GetWMI("Win32_DiskDrive", "SerialNumber");
        string board = GetWMI("Win32_BaseBoard", "SerialNumber");

        return SHA256.HashData(Encoding.UTF8.GetBytes($"{cpu}-{disk}-{board}"));
    }

    private static string GetWMI(string wmiClass, string wmiProperty)
    {
        using ManagementObjectSearcher searcher = new($"SELECT {wmiProperty} FROM {wmiClass}");
        
        foreach (ManagementBaseObject? obj in searcher.Get())
            return obj[wmiProperty]?.ToString() ?? "";
            
        return "";
    }
}
