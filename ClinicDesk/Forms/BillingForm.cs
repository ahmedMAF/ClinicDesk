using System.Data;
using Microsoft.EntityFrameworkCore;
using ClinicDesk.Database;
using ClinicDesk.Database.Dto;
using ClinicDesk.Database.Models;
using ReaLTaiizor.Forms;
using ClinicDesk.ControlHelpers;
using ClinicDesk.Utilities;

namespace ClinicDesk.Forms;

public partial class BillingForm : MaterialForm
{
    private Patient? _patient;

    private List<InvoiceDto> _invoices = null!;
    private readonly GridButtonHelper _grdHelper;

    public BillingForm()
    {
        InitializeComponent();
        Utils.SetupInvoicesDataGrid(invoicesGrd);

        _grdHelper = new GridButtonHelper(invoicesGrd, new Dictionary<string, Action<int>>
        {
            ["detailsBtn"] = detailsBtn_Click,
            ["payBtn"] = payBtn_Click,
            ["payFullBtn"] = payFullBtn_Click
        });
        
        FormClosed += (s, e) => ClinicDb.Client?.RefreshUI -= RefreshUI;
        ClinicDb.Client?.RefreshUI += RefreshUI;
    }

    internal void SetData(Patient patient)
    {
        _patient = patient;
        nameTxt.Text = patient.Name;
        phoneTxt.Text = patient.Phone;
    }

    private async void BillingForm_Load(object sender, EventArgs e)
    {
        await RefreshList();
    }

    private async Task RefreshList()
    {
        _invoices = await ClinicDb.Instance.Invoices
            .AsNoTracking()
            .Include(i => i.Payments)
            .Where(i => i.Visit.PatientId == _patient!.Id)
            .Select(i => new InvoiceDto
            {
                Id = i.Id,
                IssuedAt = i.IssuedAt,
                TotalAmount = i.TotalAmount,
                PaidAmount = i.Payments.Sum(p => p.Amount),
            })
            .ToListAsync();

        for (int i = 0; i < _invoices.Count; i++)
            _invoices[i].RemainingAmount = _invoices[i].TotalAmount - _invoices[i].PaidAmount;

        _invoices = _invoices
            .OrderBy(i => i.RemainingAmount == 0)
            .ThenBy(i => i.IssuedAt)
            .ToList();
        
        for (int i = 0; i < _invoices.Count; i++)
            _invoices[i].Serial = i + 1;

        invoicesGrd.DataSource = _invoices;
    }

    private async void detailsBtn_Click(int rowIndex)
    {
        Invoice? invoice = await ClinicDb.Instance.Invoices
            .Include(i => i.Payments)
            .FirstOrDefaultAsync(i => i.Id == _invoices[rowIndex].Id);

        AppContext.ShowDialog<InvoiceDetailsForm>(form => form.SetData(invoice!));
        await RefreshList();
    }

    private async void payBtn_Click(int rowIndex)
    {
        InvoiceDto invoice = _invoices[rowIndex];

        if (IsPayButtonDisabled(invoice))
            return;

        AppContext.ShowDialog<PaymentForm>(form => form.SetData(invoice.RemainingAmount), async (form, result) => await PerformPayment(invoice, form.Amount, form.Method, result));
    }

    private async void payFullBtn_Click(int rowIndex)
    {
        InvoiceDto invoice = _invoices[rowIndex];

        if (IsPayButtonDisabled(invoice) ||
            MessageBox.Show($"Are you sure you want to fully pay this invoice with a value of \"{invoice.RemainingAmount:0.00}\"?", "Payment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            return;

        await PerformPayment(invoice, invoice.RemainingAmount, "Cash");
    }

    private async Task PerformPayment(InvoiceDto invoice, decimal amount, string method, DialogResult result = default)
    {
        if (result == DialogResult.Cancel)
            return;

        Payment payment = new()
        {
            InvoiceId = invoice.Id,
            Amount = amount,
            Method = method
        };

        ClinicDb.Instance.Payments.Add(payment);
        await ClinicDb.Instance.SaveChangesAsync();

        await RefreshList();
    }

    private void invoicesGrd_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
    {
        if (invoicesGrd.Rows[e.RowIndex].DataBoundItem is not InvoiceDto invoice)
            return;

        invoicesGrd.Rows[e.RowIndex].DefaultCellStyle.BackColor = invoice.RemainingAmount == 0 ? Theme.DataGridMissedRowBackColor : Theme.DataGridRowBackColor;
    }
    
    private void invoicesGrd_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.ColumnIndex == -1 || e.RowIndex == -1)
            return;

        DataGridViewRow row = invoicesGrd.Rows[e.RowIndex];
        InvoiceDto invoice = (InvoiceDto)row.DataBoundItem!;

        if (invoicesGrd.Columns[e.ColumnIndex].Name is "payBtn" or "payFullBtn" && IsPayButtonDisabled(invoice))
        {
            row.Cells[e.ColumnIndex].ReadOnly = true;
            e.PaintBackground(e.CellBounds, true);
            e.Handled = true;
        }
    }

    private static bool IsPayButtonDisabled(InvoiceDto invoice)
    {
        return invoice.RemainingAmount == 0;
    }
    
    private async void RefreshUI()
    {
        if (InvokeRequired)
        {
            BeginInvoke(RefreshUI);
            return;
        }

        await RefreshList();
    }
}
