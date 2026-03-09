namespace ClinicDesk.Forms
{
    partial class BillingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingForm));
            invoicesGrd = new DataGridView();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            phoneTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            nameTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            billingBtn = new ReaLTaiizor.Controls.MaterialButton();
            billTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ((System.ComponentModel.ISupportInitialize)invoicesGrd).BeginInit();
            SuspendLayout();
            // 
            // invoicesGrd
            // 
            invoicesGrd.AllowUserToAddRows = false;
            invoicesGrd.AllowUserToDeleteRows = false;
            invoicesGrd.AllowUserToOrderColumns = true;
            invoicesGrd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            invoicesGrd.BackgroundColor = Color.White;
            invoicesGrd.BorderStyle = BorderStyle.None;
            invoicesGrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            invoicesGrd.Location = new Point(12, 141);
            invoicesGrd.Name = "invoicesGrd";
            invoicesGrd.ReadOnly = true;
            invoicesGrd.RowHeadersWidth = 51;
            invoicesGrd.Size = new Size(1150, 500);
            invoicesGrd.TabIndex = 5;
            invoicesGrd.CellPainting += invoicesGrd_CellPainting;
            invoicesGrd.RowPrePaint += invoicesGrd_RowPrePaint;
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(438, 75);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(73, 48);
            materialLabel2.TabIndex = 9;
            materialLabel2.Text = "Phone";
            materialLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // phoneTxt
            // 
            phoneTxt.AnimateReadOnly = false;
            phoneTxt.AutoCompleteMode = AutoCompleteMode.None;
            phoneTxt.AutoCompleteSource = AutoCompleteSource.None;
            phoneTxt.BackgroundImageLayout = ImageLayout.None;
            phoneTxt.CharacterCasing = CharacterCasing.Normal;
            phoneTxt.Depth = 0;
            phoneTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            phoneTxt.HideSelection = true;
            phoneTxt.LeadingIcon = null;
            phoneTxt.Location = new Point(517, 75);
            phoneTxt.MaxLength = 32767;
            phoneTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            phoneTxt.Name = "phoneTxt";
            phoneTxt.PasswordChar = '\0';
            phoneTxt.PrefixSuffixText = null;
            phoneTxt.ReadOnly = false;
            phoneTxt.RightToLeft = RightToLeft.No;
            phoneTxt.SelectedText = "";
            phoneTxt.SelectionLength = 0;
            phoneTxt.SelectionStart = 0;
            phoneTxt.ShortcutsEnabled = true;
            phoneTxt.Size = new Size(312, 48);
            phoneTxt.TabIndex = 8;
            phoneTxt.TabStop = false;
            phoneTxt.TextAlign = HorizontalAlignment.Left;
            phoneTxt.TrailingIcon = null;
            phoneTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(12, 75);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(85, 48);
            materialLabel1.TabIndex = 7;
            materialLabel1.Text = "Full Name";
            materialLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nameTxt
            // 
            nameTxt.AnimateReadOnly = false;
            nameTxt.AutoCompleteMode = AutoCompleteMode.None;
            nameTxt.AutoCompleteSource = AutoCompleteSource.None;
            nameTxt.BackgroundImageLayout = ImageLayout.None;
            nameTxt.CharacterCasing = CharacterCasing.Normal;
            nameTxt.Depth = 0;
            nameTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nameTxt.HideSelection = true;
            nameTxt.LeadingIcon = null;
            nameTxt.Location = new Point(103, 75);
            nameTxt.MaxLength = 32767;
            nameTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            nameTxt.Name = "nameTxt";
            nameTxt.PasswordChar = '\0';
            nameTxt.PrefixSuffixText = null;
            nameTxt.ReadOnly = false;
            nameTxt.RightToLeft = RightToLeft.No;
            nameTxt.SelectedText = "";
            nameTxt.SelectionLength = 0;
            nameTxt.SelectionStart = 0;
            nameTxt.ShortcutsEnabled = true;
            nameTxt.Size = new Size(312, 48);
            nameTxt.TabIndex = 6;
            nameTxt.TabStop = false;
            nameTxt.TextAlign = HorizontalAlignment.Left;
            nameTxt.TrailingIcon = null;
            nameTxt.UseSystemPasswordChar = false;
            // 
            // billingBtn
            // 
            billingBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            billingBtn.AutoSize = false;
            billingBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            billingBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            billingBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            billingBtn.Depth = 0;
            billingBtn.HighEmphasis = true;
            billingBtn.Icon = null;
            billingBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            billingBtn.Location = new Point(1044, 75);
            billingBtn.Margin = new Padding(4, 6, 4, 6);
            billingBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            billingBtn.Name = "billingBtn";
            billingBtn.NoAccentTextColor = Color.Empty;
            billingBtn.Size = new Size(117, 45);
            billingBtn.TabIndex = 10;
            billingBtn.Text = "Add Bill";
            billingBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            billingBtn.UseAccentColor = false;
            billingBtn.UseVisualStyleBackColor = true;
            billingBtn.Click += billingBtn_Click;
            // 
            // billTxt
            // 
            billTxt.AnimateReadOnly = false;
            billTxt.AutoCompleteMode = AutoCompleteMode.None;
            billTxt.AutoCompleteSource = AutoCompleteSource.None;
            billTxt.BackgroundImageLayout = ImageLayout.None;
            billTxt.CharacterCasing = CharacterCasing.Normal;
            billTxt.Depth = 0;
            billTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            billTxt.HideSelection = true;
            billTxt.Hint = "Bill Amount";
            billTxt.LeadingIcon = null;
            billTxt.Location = new Point(925, 75);
            billTxt.MaxLength = 32767;
            billTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            billTxt.Name = "billTxt";
            billTxt.PasswordChar = '\0';
            billTxt.PrefixSuffixText = null;
            billTxt.ReadOnly = false;
            billTxt.RightToLeft = RightToLeft.No;
            billTxt.SelectedText = "";
            billTxt.SelectionLength = 0;
            billTxt.SelectionStart = 0;
            billTxt.ShortcutsEnabled = true;
            billTxt.Size = new Size(112, 48);
            billTxt.TabIndex = 11;
            billTxt.TabStop = false;
            billTxt.TextAlign = HorizontalAlignment.Left;
            billTxt.TrailingIcon = null;
            billTxt.UseSystemPasswordChar = false;
            // 
            // BillingForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1168, 647);
            Controls.Add(billTxt);
            Controls.Add(billingBtn);
            Controls.Add(materialLabel2);
            Controls.Add(phoneTxt);
            Controls.Add(materialLabel1);
            Controls.Add(nameTxt);
            Controls.Add(invoicesGrd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BillingForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            Load += BillingForm_Load;
            ((System.ComponentModel.ISupportInitialize)invoicesGrd).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView invoicesGrd;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit phoneTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit nameTxt;
        private ReaLTaiizor.Controls.MaterialButton billingBtn;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit billTxt;
    }
}