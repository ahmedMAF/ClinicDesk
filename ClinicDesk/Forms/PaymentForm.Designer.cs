namespace ClinicDesk.Forms
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            amountTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            payBtn = new ReaLTaiizor.Controls.MaterialButton();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            cancelBtn = new ReaLTaiizor.Controls.MaterialButton();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            methodCbo = new ReaLTaiizor.Controls.MaterialComboBox();
            SuspendLayout();
            // 
            // amountTxt
            // 
            amountTxt.AnimateReadOnly = false;
            amountTxt.AutoCompleteMode = AutoCompleteMode.None;
            amountTxt.AutoCompleteSource = AutoCompleteSource.None;
            amountTxt.BackgroundImageLayout = ImageLayout.None;
            amountTxt.CharacterCasing = CharacterCasing.Normal;
            amountTxt.Depth = 0;
            amountTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            amountTxt.HideSelection = true;
            amountTxt.LeadingIcon = null;
            amountTxt.Location = new Point(122, 75);
            amountTxt.MaxLength = 32767;
            amountTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            amountTxt.Name = "amountTxt";
            amountTxt.PasswordChar = '\0';
            amountTxt.PrefixSuffixText = null;
            amountTxt.ReadOnly = false;
            amountTxt.RightToLeft = RightToLeft.No;
            amountTxt.SelectedText = "";
            amountTxt.SelectionLength = 0;
            amountTxt.SelectionStart = 0;
            amountTxt.ShortcutsEnabled = true;
            amountTxt.Size = new Size(308, 48);
            amountTxt.TabIndex = 0;
            amountTxt.TabStop = false;
            amountTxt.Text = "0";
            amountTxt.TextAlign = HorizontalAlignment.Left;
            amountTxt.TrailingIcon = null;
            amountTxt.UseSystemPasswordChar = false;
            amountTxt.KeyPress += amountTxt_KeyPress;
            amountTxt.TextChanged += amountTxt_TextChanged;
            // 
            // payBtn
            // 
            payBtn.AutoSize = false;
            payBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            payBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            payBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            payBtn.Depth = 0;
            payBtn.HighEmphasis = true;
            payBtn.Icon = null;
            payBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            payBtn.Location = new Point(280, 187);
            payBtn.Margin = new Padding(4, 6, 4, 6);
            payBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            payBtn.Name = "payBtn";
            payBtn.NoAccentTextColor = Color.Empty;
            payBtn.Size = new Size(150, 36);
            payBtn.TabIndex = 1;
            payBtn.Text = "Pay";
            payBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            payBtn.UseAccentColor = false;
            payBtn.UseVisualStyleBackColor = true;
            payBtn.Click += payBtn_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(6, 75);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(110, 48);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Amount";
            materialLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cancelBtn
            // 
            cancelBtn.AutoSize = false;
            cancelBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            cancelBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            cancelBtn.Depth = 0;
            cancelBtn.HighEmphasis = true;
            cancelBtn.Icon = null;
            cancelBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            cancelBtn.Location = new Point(122, 187);
            cancelBtn.Margin = new Padding(4, 6, 4, 6);
            cancelBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            cancelBtn.Name = "cancelBtn";
            cancelBtn.NoAccentTextColor = Color.Empty;
            cancelBtn.Size = new Size(150, 36);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancel";
            cancelBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            cancelBtn.UseAccentColor = false;
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(6, 129);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(110, 48);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "Method";
            materialLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // methodCbo
            // 
            methodCbo.AutoResize = false;
            methodCbo.BackColor = Color.FromArgb(255, 255, 255);
            methodCbo.Depth = 0;
            methodCbo.DrawMode = DrawMode.OwnerDrawVariable;
            methodCbo.DropDownHeight = 174;
            methodCbo.DropDownStyle = ComboBoxStyle.DropDownList;
            methodCbo.DropDownWidth = 121;
            methodCbo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            methodCbo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            methodCbo.FormattingEnabled = true;
            methodCbo.IntegralHeight = false;
            methodCbo.ItemHeight = 43;
            methodCbo.Items.AddRange(new object[] { "Cash", "Credit Card", "Cheque", "Bank Transfer", "Mobile Payment" });
            methodCbo.Location = new Point(122, 129);
            methodCbo.MaxDropDownItems = 4;
            methodCbo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            methodCbo.Name = "methodCbo";
            methodCbo.Size = new Size(308, 49);
            methodCbo.StartIndex = 0;
            methodCbo.TabIndex = 5;
            // 
            // PaymentForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(445, 242);
            Controls.Add(methodCbo);
            Controls.Add(materialLabel2);
            Controls.Add(cancelBtn);
            Controls.Add(materialLabel1);
            Controls.Add(payBtn);
            Controls.Add(amountTxt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PaymentForm";
            ShowInTaskbar = false;
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit amountTxt;
        private ReaLTaiizor.Controls.MaterialButton payBtn;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialButton cancelBtn;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialComboBox methodCbo;
    }
}