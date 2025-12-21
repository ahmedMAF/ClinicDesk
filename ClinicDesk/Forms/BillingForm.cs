using System.Data;
using Microsoft.EntityFrameworkCore;
using ClinicDesk.Database;
using ClinicDesk.Database.Dto;
using ClinicDesk.Database.Models;
using ReaLTaiizor.Forms;
using ClinicDesk.ControlHelpers;

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
            .AsNoTracking()
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

        decimal paymentAmount = 0;

        if (AppContext.ShowDialog<PaymentForm>(form => form.SetData(invoice.RemainingAmount), (form, _) => paymentAmount = form.PaymentAmount) == DialogResult.Cancel)
            return;

        await PerformPayment(invoice, paymentAmount);
    }

    private async void payFullBtn_Click(int rowIndex)
    {
        InvoiceDto invoice = _invoices[rowIndex];

        if (IsPayButtonDisabled(invoice) ||
            MessageBox.Show($"Are you sure you want to fully pay this invoice with a value of \"{invoice.RemainingAmount:0.00}\"?", "Payment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            return;

        await PerformPayment(invoice, invoice.RemainingAmount);
    }

    private async Task PerformPayment(InvoiceDto invoice, decimal amount)
    {
        Payment payment = new()
        {
            InvoiceId = invoice.Id,
            Amount = amount
        };

        ClinicDb.Instance.Payments.Add(payment);
        await ClinicDb.Instance.SaveChangesAsync();

        await RefreshList();
    }

    protected void ButtonPaint(PaintEventArgs pevent)
    {
        /*Graphics graphics = pevent.Graphics;
        graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;
        double progress = _hoverAnimationManager.GetProgress();
        double progress2 = _focusAnimationManager.GetProgress();
        graphics.Clear((!(base.Parent.BackColor == Color.Transparent)) ? base.Parent.BackColor : ((base.Parent.Parent == null || (base.Parent.Parent != null && base.Parent.Parent.BackColor == Color.Transparent)) ? SkinManager.BackgroundColor : base.Parent.Parent.BackColor));
        RectangleF rect = new RectangleF(base.ClientRectangle.Location, base.ClientRectangle.Size);
        rect.X -= 0.5f;
        rect.Y -= 0.5f;
        GraphicsPath path = MaterialDrawHelper.CreateRoundRect(rect, 4f);
        MaterialDrawHelper.DrawSquareShadow(graphics, base.ClientRectangle);
        if (Type == MaterialButtonType.Contained)
        {
            if (!base.Enabled)
            {
                using SolidBrush brush = new SolidBrush(MaterialDrawHelper.BlendColor(base.Parent.BackColor, SkinManager.BackgroundDisabledColor, (int)SkinManager.BackgroundDisabledColor.A));
                graphics.FillPath(brush, path);
            }
            else if (HighEmphasis)
            {
                graphics.FillPath(UseAccentColor ? SkinManager.ColorScheme.AccentBrush : SkinManager.ColorScheme.PrimaryBrush, path);
            }
            else
            {
                using SolidBrush brush2 = new SolidBrush(SkinManager.BackgroundColor);
                graphics.FillPath(brush2, path);
            }
        }
        else
        {
            graphics.Clear(base.Parent.BackColor);
        }

        if (progress > 0.0)
        {
            using SolidBrush brush3 = new SolidBrush(Color.FromArgb((int)((HighEmphasis && Type == MaterialButtonType.Contained) ? (progress * 80.0) : (progress * (double)(int)SkinManager.BackgroundHoverColor.A)), ((!UseAccentColor) ? ((Type == MaterialButtonType.Contained && HighEmphasis) ? SkinManager.ColorScheme.LightPrimaryColor : SkinManager.ColorScheme.PrimaryColor) : ((HighEmphasis && Type == MaterialButtonType.Contained) ? SkinManager.ColorScheme.AccentColor.Lighten(0.5f) : SkinManager.ColorScheme.AccentColor)).RemoveAlpha()));
            graphics.FillPath(brush3, path);
        }

        if (progress2 > 0.0)
        {
            using SolidBrush brush4 = new SolidBrush(Color.FromArgb((int)((HighEmphasis && Type == MaterialButtonType.Contained) ? (progress2 * 80.0) : (progress2 * (double)(int)SkinManager.BackgroundFocusColor.A)), ((!UseAccentColor) ? ((Type == MaterialButtonType.Contained && HighEmphasis) ? SkinManager.ColorScheme.LightPrimaryColor : SkinManager.ColorScheme.PrimaryColor) : ((HighEmphasis && Type == MaterialButtonType.Contained) ? SkinManager.ColorScheme.AccentColor.Lighten(0.5f) : SkinManager.ColorScheme.AccentColor)).RemoveAlpha()));
            graphics.FillPath(brush4, path);
        }

        if (Type == MaterialButtonType.Outlined)
        {
            using Pen pen = new Pen(base.Enabled ? SkinManager.DividersAlternativeColor : SkinManager.DividersColor, 1f);
            rect.X += 0.5f;
            rect.Y += 0.5f;
            graphics.DrawPath(pen, path);
        }

        if (_animationManager.IsAnimating())
        {
            graphics.Clip = new Region(rect);
            for (int i = 0; i < _animationManager.GetAnimationCount(); i++)
            {
                double progress3 = _animationManager.GetProgress(i);
                Point source = _animationManager.GetSource(i);
                using Brush brush5 = new SolidBrush(Color.FromArgb((int)(100.0 - progress3 * 100.0), (Type != MaterialButtonType.Contained || !HighEmphasis) ? (UseAccentColor ? SkinManager.ColorScheme.AccentColor : ((SkinManager.Theme == MaterialSkinManager.Themes.LIGHT) ? SkinManager.ColorScheme.PrimaryColor : SkinManager.ColorScheme.LightPrimaryColor)) : (UseAccentColor ? SkinManager.ColorScheme.AccentColor.Lighten(0.5f) : SkinManager.ColorScheme.LightPrimaryColor)));
                int num = (int)(progress3 * (double)base.Width * 2.0);
                graphics.FillEllipse(brush5, new Rectangle(source.X - num / 2, source.Y - num / 2, num, num));
            }

            graphics.ResetClip();
        }

        Rectangle clientRectangle = base.ClientRectangle;
        if (Icon != null)
        {
            clientRectangle.Width -= 44;
            clientRectangle.X += 36;
        }

        Color color2;
        if (base.Enabled)
        {
            Color color;
            if (HighEmphasis)
            {
                MaterialButtonType type = Type;
                bool flag = (uint)type <= 1u;
                color = ((!flag) ? SkinManager.ColorScheme.TextColor : (UseAccentColor ? SkinManager.ColorScheme.AccentColor : ((NoAccentTextColor == Color.Empty) ? SkinManager.ColorScheme.PrimaryColor : NoAccentTextColor)));
            }
            else
            {
                color = SkinManager.TextHighEmphasisColor;
            }

            color2 = color;
        }
        else
        {
            color2 = SkinManager.TextDisabledOrHintColor;
        }

        Color color3 = color2;
        using (MaterialNativeTextRenderer materialNativeTextRenderer = new MaterialNativeTextRenderer(graphics))
        {
            materialNativeTextRenderer.DrawMultilineTransparentText((CharacterCasing == CharacterCasingEnum.Upper) ? base.Text.ToUpper() : ((CharacterCasing == CharacterCasingEnum.Lower) ? base.Text.ToLower() : ((CharacterCasing == CharacterCasingEnum.Title) ? CultureInfo.CurrentCulture.TextInfo.ToTitleCase(base.Text.ToLower()) : base.Text)), SkinManager.GetLogFontByType(MaterialSkinManager.FontType.Button), color3, clientRectangle.Location, clientRectangle.Size, MaterialNativeTextRenderer.TextAlignFlags.Center | MaterialNativeTextRenderer.TextAlignFlags.Middle);
        }

        Rectangle rect2 = new Rectangle(8, base.Height / 2 - 12, 24, 24);
        if (string.IsNullOrEmpty(Text))
        {
            rect2.X += 2;
        }

        if (Icon != null)
        {
            if (IconType == MaterialIconType.Rebase)
            {
                graphics.FillRectangle(iconsBrushes, rect2);
            }
            else
            {
                graphics.DrawImage(Icon, rect2);
            }
        }*/
    }

    private void invoicesGrd_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
    {
        if (invoicesGrd.Rows[e.RowIndex].DataBoundItem is not InvoiceDto invoice)
            return;

       invoicesGrd.Rows[e.RowIndex].DefaultCellStyle.BackColor = invoice.RemainingAmount == 0 ? Color.LightGray : Color.White;
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
}
