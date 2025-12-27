using ClinicDesk.Database;
using ClinicDesk.Database.Models;
using ReaLTaiizor.Forms;
using System.Data;

namespace ClinicDesk.Forms
{
    public partial class StatsForm : MaterialForm
    {
        public StatsForm()
        {
            InitializeComponent();
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            ClinicDb db = ClinicDb.Instance;

            DateTime start = monthCalendar1.SelectionStart;
            DateTime end = monthCalendar1.SelectionEnd;

            IQueryable<Appointment> query = db.Appointments
                .Where(a => a.Date >= start && a.Date <= end);

            int totalApps = query.Count();
            int totalPatients = query.Select(a => a.PatientId).Distinct().Count();

            var statusCounts = query
                .GroupBy(a => a.Status)
                .Select(g => new { Status = g.Key, Count = g.Count() })
                .ToList();

            IQueryable<Invoice> invoices = db.Invoices
                .Where(i => i.IssuedAt >= start && i.IssuedAt <= end);

            int totalbills = query.Count();

            numOfAppsTxt.Text = totalApps.ToString();
            numOfPatientsTxt.Text = totalPatients.ToString();
            attTxt.Text = getCount(AppointmentStatus.Attended).ToString();
            missTxt.Text = getCount(AppointmentStatus.Missed).ToString();
            cancelTxt.Text = getCount(AppointmentStatus.Cancelled).ToString();
            reschTxt.Text = getCount(AppointmentStatus.Rescheduled).ToString();
            pendTxt.Text = getCount(AppointmentStatus.Pending).ToString();

            // result lookup
            int getCount(AppointmentStatus s) => statusCounts.FirstOrDefault(x => x.Status == s)?.Count ?? 0;
        }
    }
}
