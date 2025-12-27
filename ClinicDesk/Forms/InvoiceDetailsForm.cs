using ClinicDesk.Database;
using ClinicDesk.Database.Dto;
using ClinicDesk.Database.Models;
using ClinicDesk.Utilities;
using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class InvoiceDetailsForm : MaterialForm
{
    private Invoice _invoice = null!;
    private List<PaymentDto> _payments = null!;

    public InvoiceDetailsForm()
    {
        InitializeComponent();
        Utils.SetupPaymentsDataGrid(paymentsGrd);
    }

    internal void SetData(Invoice invoice)
    {
        _invoice = invoice;
        RefreshList();
    }

    private void RefreshList()
    {
        _payments = _invoice.Payments
            .OrderBy(i => i.PaidAt)
            .Select(p => new PaymentDto
            {
                Id = p.Id,
                PaidAt = p.PaidAt,
                Amount = p.Amount,
                Method = p.Method
            })
            .ToList();

        for (int i = 0; i < _payments.Count; i++)
            _payments[i].Serial = i + 1;

        paymentsGrd.DataSource = _payments;
    }

    private async void appointmentsGrd_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.RowIndex == -1 || e.ColumnIndex == -1 || paymentsGrd.Columns[e.ColumnIndex] is not DataGridViewButtonColumn)
            return;

        if (MessageBox.Show("Are you sure you want to delete this payment from the invoice? This action is permenant and can't be undone.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            return;

        ClinicDb.Instance.Payments.Remove(_invoice.Payments[e.RowIndex]);
        await ClinicDb.Instance.SaveChangesAsync();

        RefreshList();
    }
}
