using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Material;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using static ClinicDesk.Controls.MaterialAnimations;

namespace ClinicDesk.Controls;

public class MaterialMessage : MaterialForm
{
    private const int LeftRightPadding = 24;
    private const int ButtonPadding = 8;
    private const int ButtonHeight = 36;
    private const int TextTopPadding = 17;
    private const int TextBottomPadding = 28;

    private int _headerHeight = 40;
    private Rectangle _textRect;
    private Rectangle _titleRect;

    private MaterialButton _validationButton;
    private MaterialButton _cancelButton;
    private PictureBox _iconBox;
    private AnimationManager _animationManager;
    private bool _closeAnimation;
    private string _text;
    private string _title;

    private MaterialMessage(string text, string title, string mainButtonText, string? secondaryButtonText, MessageBoxIcon icon, bool useAccentColor)
    {
        _title = title;
        _text = text;

        if (string.IsNullOrWhiteSpace(title))
            _headerHeight = 0;

        _animationManager = new AnimationManager
        {
            AnimationType = AnimationType.EaseOut,
            Increment = 0.03
        };

        _animationManager.OnAnimationProgress += animationManager_OnAnimationProgress;
        _animationManager.OnAnimationFinished += animationManager_OnAnimationFinished;

        // Controls

        // ((System.ComponentModel.ISupportInitialize)_iconBox).BeginInit();
        SuspendLayout();

        Name = "Dialog";
        ShowInTaskbar = false;
        Sizable = false;
        BackColor = SkinManager.BackgroundColor;
        FormStyle = FormStyles.StatusAndActionBar_None;
        Width = 560;

        _validationButton = new MaterialButton
        {
            Name = "validationButton",
            AutoSize = false,
            DialogResult = DialogResult.OK,
            DrawShadows = false,
            Type = MaterialButton.MaterialButtonType.Text,
            UseAccentColor = useAccentColor,
            Text = mainButtonText
        };

        _validationButton.Click += CloseDialog;

        AcceptButton = _validationButton;
        Controls.Add(_validationButton);

        if (secondaryButtonText != null)
        {
            _cancelButton = new MaterialButton
            {
                Name = "cancelButton",
                AutoSize = false,
                DialogResult = DialogResult.Cancel,
                DrawShadows = false,
                Type = MaterialButton.MaterialButtonType.Text,
                UseAccentColor = useAccentColor,
                Text = secondaryButtonText
            };

            _cancelButton.Click += CloseDialog;

            CancelButton = _cancelButton;
            Controls.Add(_cancelButton);
        }

        int textWidth = TextRenderer.MeasureText(_text, SkinManager.GetFontByType(MaterialSkinManager.FontType.Body1)).Width;
        int rectWidth = Width - (2 * LeftRightPadding) - ButtonPadding;
        int rectHeight = ((textWidth / rectWidth) + 1) * 19;

        if (icon != MessageBoxIcon.None)
        {
            _iconBox = new PictureBox
            {
                BackColor = Color.Transparent,
                Location = new Point(12, 12),
                Name = "iconBox",
                Size = new Size(32, 32),
                SizeMode = PictureBoxSizeMode.Zoom,
                TabStop = false
            };

            _iconBox.Image = icon switch
            {
                MessageBoxIcon.Asterisk => SystemIcons.Information.ToBitmap(),
                MessageBoxIcon.Exclamation => SystemIcons.Warning.ToBitmap(),
                MessageBoxIcon.Hand => SystemIcons.Error.ToBitmap(),
                MessageBoxIcon.Question => SystemIcons.Question.ToBitmap(),
                _ => null
            };

            Controls.Add(_iconBox);

            rectWidth -= _iconBox.Left * 2 + _iconBox.Width;
        }

        _titleRect = new Rectangle(
            LeftRightPadding,
            0,
            Width - (2 * LeftRightPadding),
            _headerHeight);

        _textRect = new Rectangle(
            LeftRightPadding,
            _headerHeight + TextTopPadding,
            rectWidth,
            rectHeight + 19);

        Height = _headerHeight + TextTopPadding + _textRect.Height + TextBottomPadding + 52;
        Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 6, 6));

        int _buttonWidth = TextRenderer.MeasureText(mainButtonText, SkinManager.GetFontByType(MaterialSkinManager.FontType.Button)).Width + 32;
        Rectangle _validationbuttonBounds = new(Width - ButtonPadding - _buttonWidth, Height - ButtonPadding - ButtonHeight, _buttonWidth, ButtonHeight);
        _validationButton.Width = _validationbuttonBounds.Width;
        _validationButton.Height = _validationbuttonBounds.Height;
        _validationButton.Top = _validationbuttonBounds.Top;
        _validationButton.Left = _validationbuttonBounds.Left;

        if (secondaryButtonText != null)
        {
            _buttonWidth = TextRenderer.MeasureText(secondaryButtonText, SkinManager.GetFontByType(MaterialSkinManager.FontType.Button)).Width + 32;
            Rectangle _cancelbuttonBounds = new(_validationbuttonBounds.Left - ButtonPadding - _buttonWidth, Height - ButtonPadding - ButtonHeight, _buttonWidth, ButtonHeight);
            _cancelButton.Width = _cancelbuttonBounds.Width;
            _cancelButton.Height = _cancelbuttonBounds.Height;
            _cancelButton.Top = _cancelbuttonBounds.Top;
            _cancelButton.Left = _cancelbuttonBounds.Left;
        }

        // ((System.ComponentModel.ISupportInitialize)_iconBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    public static DialogResult Show(string text, string title, string mainButtonText = "OK", string? secondaryButtonText = null, MessageBoxIcon icon = default, bool useAccentColor = false)
    {
        MaterialMessage msg = new(text, title, mainButtonText, secondaryButtonText, icon, useAccentColor);
        DialogResult result = msg.ShowDialog();
        msg.Dispose();

        return result;
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        CenterToParent();
        _animationManager.StartNewAnimation(AnimationDirection.In);
    }

    private void animationManager_OnAnimationProgress(object sender)
    {
        Opacity = _animationManager.GetProgress();
    }

    private void animationManager_OnAnimationFinished(object sender)
    {
        if (_closeAnimation)
            Close();
    }

    private void CloseDialog(object sender, EventArgs e)
    {
        _closeAnimation = true;
        _animationManager.StartNewAnimation(AnimationDirection.Out);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        g.Clear(BackColor);

        // Draw title
        using MaterialNativeTextRenderer nativeText = new(g);

        nativeText.DrawTransparentText(
            _title,
            SkinManager.GetLogFontByType(MaterialSkinManager.FontType.H6),
            SkinManager.TextHighEmphasisColor,
            _titleRect.Location,
            _titleRect.Size,
            MaterialNativeTextRenderer.TextAlignFlags.Left | MaterialNativeTextRenderer.TextAlignFlags.Bottom);

        // Draw text
        nativeText.DrawMultilineTransparentText(
            _text,
            SkinManager.GetLogFontByType(MaterialSkinManager.FontType.Body1),
            SkinManager.TextHighEmphasisColor,
            _textRect.Location,
            _textRect.Size,
            MaterialNativeTextRenderer.TextAlignFlags.Left | MaterialNativeTextRenderer.TextAlignFlags.Middle);
    }

    protected override bool ProcessDialogKey(Keys keyData)
    {
        if (ModifierKeys == Keys.None && keyData == Keys.Escape)
        {
            // To prevent multiple clicks.
            if (_closeAnimation)
                return true;

            _cancelButton.PerformClick();
            return true;
        }

        return base.ProcessDialogKey(keyData);
    }

    protected override void WndProc(ref Message message)
    {
        const int WM_SYSCOMMAND = 0x0112;
        const int SC_MOVE = 0xF010;

        if (message.Msg == WM_SYSCOMMAND)
        {
            int command = message.WParam.ToInt32() & 0xFFF0;

            if (command == SC_MOVE)
                return;
        }

        base.WndProc(ref message);
    }

    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
    (
        // x-coordinate of upper-left corner
        int nLeftRect,
        // y-coordinate of upper-left corner
        int nTopRect,
        // x-coordinate of lower-right corner
        int nRightRect,
        // y-coordinate of lower-right corner
        int nBottomRect,
        // width of ellipse
        int nWidthEllipse,
        // height of ellipse
        int nHeightEllipse
    );
}
