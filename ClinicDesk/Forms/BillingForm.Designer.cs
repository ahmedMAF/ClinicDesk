namespace QliniqRec.Forms
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
            invoicesGrd = new DataGridView();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            phoneTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            nameTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            invoicesGrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            invoicesGrd.Location = new Point(12, 183);
            invoicesGrd.Name = "invoicesGrd";
            invoicesGrd.ReadOnly = true;
            invoicesGrd.RowHeadersWidth = 51;
            invoicesGrd.Size = new Size(1131, 787);
            invoicesGrd.TabIndex = 5;
            invoicesGrd.RowPrePaint += invoicesGrd_RowPrePaint;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(12, 142);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(46, 19);
            materialLabel2.TabIndex = 9;
            materialLabel2.Text = "Phone";
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
            phoneTxt.Location = new Point(91, 129);
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
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(12, 85);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(73, 19);
            materialLabel1.TabIndex = 7;
            materialLabel1.Text = "Full Name";
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
            nameTxt.Location = new Point(91, 75);
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
            // BillingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 976);
            Controls.Add(materialLabel2);
            Controls.Add(phoneTxt);
            Controls.Add(materialLabel1);
            Controls.Add(nameTxt);
            Controls.Add(invoicesGrd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BillingForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            Load += BillingForm_Load;
            ((System.ComponentModel.ISupportInitialize)invoicesGrd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView invoicesGrd;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit phoneTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit nameTxt;
    }
}