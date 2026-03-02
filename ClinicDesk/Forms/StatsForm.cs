using ClinicDesk.Database;
using ClinicDesk.Database.Models;
using ReaLTaiizor.Forms;
using System.Data;

namespace ClinicDesk.Forms;

public partial class StatsForm : MaterialForm
{
    public StatsForm()
    {
        InitializeComponent();

        FormClosed += (s, e) => ClinicDb.Client?.RefreshUI -= RefreshUI;
        ClinicDb.Client?.RefreshUI += RefreshUI;
    }

    private void StatsForm_Load(object sender, EventArgs e)
    {
        RefreshStats();
    }

    private void RefreshStats()
    {
        ClinicDb db = ClinicDb.Instance;

        DateTime start = dateFromPkr.Value.Date;
        DateTime end = dateToPkr.Value.Date;

        // Filter appointments
        IQueryable<Appointment> query = db.Appointments
            .Where(a => allTimeChk.Checked || (a.Date >= start && a.Date <= end));

        int totalApps = query.Count();
        int totalPatients = query.Select(a => a.PatientId).Distinct().Count();

        // Group by appointment status into a dictionary for fast lookup
        Dictionary<AppointmentStatus, int> statusCounts = query
            .GroupBy(a => a.Status)
            .Select(g => new AppointmentStat(g.Key, g.Count()))
            .ToDictionary(x => x.Status, x => x.Count);

        // Filter invoices
        IQueryable<Invoice> invoices = db.Invoices
            .Where(i => allTimeChk.Checked || (i.IssuedAt >= start && i.IssuedAt <= end));

        int totalBills = invoices.Count();
        decimal totalAmount = invoices.Sum(i => i.TotalAmount);
        decimal totalPaid = invoices.SelectMany(i => i.Payments).Sum(p => p.Amount);

        // Payment method stats
        List<PaymentMethodStat> paymentMethodStats = invoices
            .SelectMany(i => i.Payments)
            .GroupBy(p => p.Method)
            .Select(g => new PaymentMethodStat
            {
                Method = g.Key,
                TotalAmount = g.Sum(p => p.Amount),
                Count = g.Count()
            })
            .ToList();

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

    private void RefreshStatsOld()
    {
        ClinicDb db = ClinicDb.Instance;

        DateTime start = dateFromPkr.Value.Date;
        DateTime end = dateToPkr.Value.Date;

        IQueryable<Appointment> query = db.Appointments
            .Where(a => allTimeChk.Checked || (a.Date >= start && a.Date <= end));

        int totalApps = query.Count();
        int totalPatients = query.Select(a => a.PatientId).Distinct().Count();

        List<AppointmentStat> statusCounts = query
            .GroupBy(a => a.Status)
            .Select(g => new AppointmentStat(g.Key, g.Count()))
            .ToList();

        IQueryable<Invoice> invoices = db.Invoices
            .Where(i => allTimeChk.Checked || (i.IssuedAt >= start && i.IssuedAt <= end));

        int totalBills = invoices.Count();

        decimal totalAmount = invoices
            .Sum(i => i.TotalAmount);

        decimal totalPaid = invoices
            .SelectMany(i => i.Payments)
            .Sum(p => p.Amount);

        IQueryable<Payment> paymentsQuery = invoices
            .SelectMany(i => i.Payments);

        List<PaymentMethodStat> paymentMethodStats = paymentsQuery
            .GroupBy(p => p.Method)
            .Select(g => new PaymentMethodStat
            {
                Method = g.Key,
                TotalAmount = g.Sum(p => p.Amount),
                Count = g.Count()
            })
            .ToList();

        numOfAppsTxt.Text = totalApps.ToString();
        numOfPatientsTxt.Text = totalPatients.ToString();

        appointmentList.Items.Clear();
        appointmentList.Items.AddRange([.. Enum.GetValues<AppointmentStatus>().Select(s => new ListViewItem([s.ToString(), getCount(s).ToString()]))]);

        methodList.Items.Clear();
        methodList.Items.AddRange([.. paymentMethodStats.Select(s => new ListViewItem([s.Method, s.Count.ToString(), s.TotalAmount.ToString("0.00")]))]);

        numOfBillsTxt.Text = totalBills.ToString();
        totalTxt.Text = totalAmount.ToString("0.00");
        paidTxt.Text = totalPaid.ToString("0.00");
        remainTxt.Text = (totalAmount - totalPaid).ToString("0.00");

        // result lookup
        int getCount(AppointmentStatus s) => statusCounts.FirstOrDefault(x => x.Status == s)?.Count ?? 0;
    }

    private void RefreshUI()
    {
        if (InvokeRequired)
        {
            BeginInvoke(RefreshUI);
            return;
        }

        RefreshStats();
    }

    private void showBtn_Click(object sender, EventArgs e)
    {
        RefreshUI();
    }

    private void allTimeChk_CheckedChanged(object sender, EventArgs e)
    {
        dateFromPkr.Enabled = !allTimeChk.Checked;
        dateToPkr.Enabled = !allTimeChk.Checked;
    }
}

public class PaymentMethodStat
{
    public string Method { get; set; } = null!;
    public decimal TotalAmount { get; set; }
    public int Count { get; set; }
}

public class AppointmentStat(AppointmentStatus status, int count)
{
    public AppointmentStatus Status { get; } = status;
    public int Count { get; } = count;
}