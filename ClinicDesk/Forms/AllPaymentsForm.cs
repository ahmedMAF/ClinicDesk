using ClinicDesk.Database;
using ClinicDesk.Database.Dto;
using ClinicDesk.Database.Models;
using ClinicDesk.Utilities;
using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class AllPaymentsForm : MaterialForm
{
    private readonly SemaphoreSlim _refreshLock = new(1, 1);

    public AllPaymentsForm()
    {
        InitializeComponent();

        Utils.SetupAllPaymentsDataGrid(paymentsGrd);
    }

    private async void AllPaymentsForm_Load(object sender, EventArgs e)
    {
        DateTime now = DateTime.Now;

        DateTime firstDay = new(now.Year, now.Month, 1);
        DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);

        dateFromPkr.Value = firstDay;
        dateToPkr.Value = lastDay;

        await RefreshStats();
    }

    private async void showBtn_Click(object sender, EventArgs e)
    {
        // already running, ignore this call
        if (!await _refreshLock.WaitAsync(0))
            return;

        try
        {
            await RefreshStats();
        }
        finally
        {
            _refreshLock.Release();
        }
    }

    private async Task RefreshStats()
    {
        DateTime start = dateFromPkr.Value.Date;
        DateTime end = dateToPkr.Value.Date.AddDays(1);

        List<PaymentDto>? payments = await ClinicDb.SafeExecAsync<Payment, List<PaymentDto>>(table => table
            .Where(p => p.PaidAt >= start && p.PaidAt < end)
            .Select(p => new PaymentDto
            {
                Id = p.Id,
                PatientName = p.Invoice.Patient.Name,
                PaidAt = p.PaidAt,
                Amount = p.Amount,
                Method = p.Method
            })
            .OrderBy(p => p.Method)
            .ThenBy(p => p.PaidAt)
            .ToListAsync()
        );

        if (payments == null)
        {
            Close();
            return;
        }

        for (int i = 0; i < payments.Count; i++)
            payments[i].Serial = i + 1;

        paymentsGrd.DataSource = payments;
    }
}
