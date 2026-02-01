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

        IQueryable<Appointment> query = db.Appointments
            .Where(a => allTimeChk.Checked || (a.Date >= start && a.Date <= end));

        int totalApps = query.Count();
        int totalPatients = query.Select(a => a.PatientId).Distinct().Count();

        // FIXME: Remove var and anonymous type.
        var statusCounts = query
            .GroupBy(a => a.Status)
            .Select(g => new { Status = g.Key, Count = g.Count() })
            .ToList();

        IQueryable<Invoice> invoices = db.Invoices
            .Where(i => allTimeChk.Checked || (i.IssuedAt >= start && i.IssuedAt <= end));

        int totalBills = invoices.Count();

        decimal totalAmount = invoices
            .Sum(i => i.TotalAmount);

        decimal totalPaid = invoices
            .SelectMany(i => i.Payments)
            .Sum(p => p.Amount);

        numOfAppsTxt.Text = totalApps.ToString();
        numOfPatientsTxt.Text = totalPatients.ToString();
        attTxt.Text = getCount(AppointmentStatus.Attended).ToString();
        missTxt.Text = getCount(AppointmentStatus.Missed).ToString();
        cancelTxt.Text = getCount(AppointmentStatus.Cancelled).ToString();
        reschTxt.Text = getCount(AppointmentStatus.Rescheduled).ToString();
        pendTxt.Text = getCount(AppointmentStatus.Pending).ToString();

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
