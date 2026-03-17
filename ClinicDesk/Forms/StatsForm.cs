using ClinicDesk.Database;
using ClinicDesk.Database.Dto;
using ClinicDesk.Database.Models;
using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Forms;
using System.Data;

namespace ClinicDesk.Forms;

public partial class StatsForm : MaterialForm
{
    private readonly SemaphoreSlim _refreshLock = new(1, 1);

    public StatsForm()
    {
        InitializeComponent();
    }

    private async void StatsForm_Load(object sender, EventArgs e)
    {
        await RefreshStats();
    }

    private void showPaymentsBtn_Click(object sender, EventArgs e)
    {
        AppContext.ShowDialog<AllPaymentsForm>();
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

    private void allTimeChk_CheckedChanged(object sender, EventArgs e)
    {
        dateFromPkr.Enabled = !allTimeChk.Checked;
        dateToPkr.Enabled = !allTimeChk.Checked;
    }

    private async Task RefreshStats()
    {
        ClinicDb db = ClinicDb.Instance;

        DateTime start = dateFromPkr.Value.Date;
        DateTime end = dateToPkr.Value.Date.AddDays(1);

        try
        {
            // Filter appointments
            IQueryable<Appointment> appointmentsQuery = db.Appointments
                .Where(a => allTimeChk.Checked || (a.Date >= start && a.Date < end));

            int totalApps = await appointmentsQuery.CountAsync();
            int totalPatients = await appointmentsQuery
                .Select(a => a.PatientId)
                .Distinct()
                .CountAsync();

            // Group by appointment status into a dictionary for fast lookup
            Dictionary<AppointmentStatus, int> statusCounts = await appointmentsQuery
                .GroupBy(a => a.Status)
                .Select(g => new AppointmentStat(g.Key, g.Count()))
                .ToDictionaryAsync(x => x.Status, x => x.Count);

            // Filter invoices
            IQueryable<Invoice> invoicesQuery = db.Invoices
                .Where(i => allTimeChk.Checked || (i.IssuedAt >= start && i.IssuedAt < end));

            int totalBills = await invoicesQuery.CountAsync();
            decimal totalAmount = await invoicesQuery.SumAsync(i => i.TotalAmount);
            decimal totalPaid = await invoicesQuery
                .SelectMany(i => i.Payments)
                .SumAsync(p => p.Amount);

            // Payment method stats
            List<PaymentMethodStat> paymentMethodStats = await invoicesQuery
                .SelectMany(i => i.Payments)
                .GroupBy(p => p.Method)
                .Select(g => new PaymentMethodStat(g.Sum(p => p.Amount), g.Count(), g.Key))
                .ToListAsync();

            // Update summary textboxes
            numOfAppsTxt.Text = totalApps.ToString();
            numOfPatientsTxt.Text = totalPatients.ToString();
            numOfBillsTxt.Text = totalBills.ToString();
            totalTxt.Text = totalAmount.ToString("0.00");
            paidTxt.Text = totalPaid.ToString("0.00");
            remainTxt.Text = (totalAmount - totalPaid).ToString("0.00");

            // Populate appointment ListView
            appointmentList.Items.Clear();
            appointmentList.Items.AddRange(
                Enum.GetValues<AppointmentStatus>()
                    .Select(s => new ListViewItem(
                    [
                        s.ToString(),
                    statusCounts.TryGetValue(s, out var c) ? c.ToString() : "0"
                    ]))
                    .ToArray()
            );

            // Populate payment method ListView
            methodList.Items.Clear();
            methodList.Items.AddRange(
                paymentMethodStats
                    .Select(s => new ListViewItem(
                    [
                        s.Method.ToString(),
                    s.Count.ToString(),
                    s.TotalAmount.ToString("0.00")
                    ]))
                    .ToArray()
            );
        }
        catch
        {
            Close();
        }
    }
}
