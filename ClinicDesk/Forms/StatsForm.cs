using ClinicDesk.Database;
using ClinicDesk.Database.Dto;
using ClinicDesk.Database.Models;
using ReaLTaiizor.Forms;
using System.Data;

namespace ClinicDesk.Forms;

public partial class StatsForm : MaterialForm
{
    public StatsForm()
    {
        InitializeComponent();
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

        try
        {
            // Filter appointments
            IQueryable<Appointment> appointmentsQuery = db.Appointments
                .Where(a => allTimeChk.Checked || (a.Date >= start && a.Date <= end));

            int totalApps = appointmentsQuery.Count();
            int totalPatients = appointmentsQuery
                .Select(a => a.PatientId)
                .Distinct()
                .Count();

            // Group by appointment status into a dictionary for fast lookup
            Dictionary<AppointmentStatus, int> statusCounts = appointmentsQuery
                .GroupBy(a => a.Status)
                .Select(g => new AppointmentStat(g.Key, g.Count()))
                .ToDictionary(x => x.Status, x => x.Count);

            // Filter invoices
            IQueryable<Invoice> invoicesQuery = db.Invoices
                .Where(i => allTimeChk.Checked || (i.IssuedAt >= start && i.IssuedAt <= end));

            int totalBills = invoicesQuery.Count();
            decimal totalAmount = invoicesQuery.Sum(i => i.TotalAmount);
            decimal totalPaid = invoicesQuery
                .SelectMany(i => i.Payments)
                .Sum(p => p.Amount);

            // Payment method stats
            List<PaymentMethodStat> paymentMethodStats = invoicesQuery
                .SelectMany(i => i.Payments)
                .GroupBy(p => p.Method)
                .Select(g => new PaymentMethodStat(g.Sum(p => p.Amount), g.Count(), g.Key))
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
        catch
        {
            Close();
        }
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
