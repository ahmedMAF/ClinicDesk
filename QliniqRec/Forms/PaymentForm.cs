using ReaLTaiizor.Forms;

namespace QliniqRec.Forms;

public partial class PaymentForm : MaterialForm
{
    public decimal PaymentAmount { get; private set; }

    public PaymentForm()
    {
        InitializeComponent();
        DialogResult = DialogResult.Cancel;
    }

    private void cancelBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void payBtn_Click(object sender, EventArgs e)
    {
        PaymentAmount = decimal.Parse(amountTxt.Text);

        DialogResult = DialogResult.OK;
        Close();
    }
}
