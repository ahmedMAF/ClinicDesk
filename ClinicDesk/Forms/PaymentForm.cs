using ReaLTaiizor.Forms;

namespace ClinicDesk.Forms;

public partial class PaymentForm : MaterialForm
{
    private decimal _maxAmount;
    public decimal PaymentAmount { get; private set; }

    public PaymentForm()
    {
        InitializeComponent();
        DialogResult = DialogResult.Cancel;
    }
    
    public void SetData(decimal maxAmount)
    {
        _maxAmount = maxAmount;
    }

    private void cancelBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void payBtn_Click(object sender, EventArgs e)
    {
        if (!decimal.TryParse(amountTxt.Text, out decimal amount))
            return;
        
        PaymentAmount = amount;

        PaymentAmount = amount;

        DialogResult = DialogResult.OK;
        Close();
    }
    
    private void amountTxt_TextChanged(object sender, EventArgs e)
    {
        if (decimal.Parse(amountTxt.Text) > _maxAmount)
            amountTxt.Text = _maxAmount.ToString("0.00");
    }
    
    private void amountTxt_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            payBtn.PerformClick();
            e.Handled = true;
        }
    }
}
