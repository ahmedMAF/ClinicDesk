namespace QliniqRec.Forms
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
            amountTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            payBtn = new ReaLTaiizor.Controls.MaterialButton();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            cancelBtn = new ReaLTaiizor.Controls.MaterialButton();
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
            amountTxt.Location = new Point(118, 75);
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
            amountTxt.Size = new Size(312, 48);
            amountTxt.TabIndex = 0;
            amountTxt.TabStop = false;
            amountTxt.Text = "0";
            amountTxt.TextAlign = HorizontalAlignment.Left;
            amountTxt.TrailingIcon = null;
            amountTxt.UseSystemPasswordChar = false;
            amountTxt.KeyPress += Utils.NumTxt_KeyPress;
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
            payBtn.Location = new Point(280, 132);
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
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(6, 91);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(106, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Amount to Pay";
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
            cancelBtn.Location = new Point(122, 132);
            cancelBtn.Margin = new Padding(4, 6, 4, 6);
            cancelBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            cancelBtn.Name = "cancelBtn";
            cancelBtn.NoAccentTextColor = Color.Empty;
            cancelBtn.Size = new Size(150, 36);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancel";
            cancelBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            cancelBtn.UseAccentColor = false;
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 181);
            Controls.Add(cancelBtn);
            Controls.Add(materialLabel1);
            Controls.Add(payBtn);
            Controls.Add(amountTxt);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PaymentForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit amountTxt;
        private ReaLTaiizor.Controls.MaterialButton payBtn;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialButton cancelBtn;
    }
}