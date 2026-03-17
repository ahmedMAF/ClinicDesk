namespace ClinicDesk.Forms
{
    partial class AllPaymentsForm
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
            materialCard3 = new ReaLTaiizor.Controls.MaterialCard();
            showBtn = new ReaLTaiizor.Controls.MaterialButton();
            dateToPkr = new DateTimePicker();
            dateFromPkr = new DateTimePicker();
            materialLabel17 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel18 = new ReaLTaiizor.Controls.MaterialLabel();
            paymentsGrd = new DataGridView();
            materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)paymentsGrd).BeginInit();
            SuspendLayout();
            // 
            // materialCard3
            // 
            materialCard3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(showBtn);
            materialCard3.Controls.Add(dateToPkr);
            materialCard3.Controls.Add(dateFromPkr);
            materialCard3.Controls.Add(materialLabel17);
            materialCard3.Controls.Add(materialLabel18);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(17, 78);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(829, 140);
            materialCard3.TabIndex = 17;
            // 
            // showBtn
            // 
            showBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            showBtn.AutoSize = false;
            showBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            showBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            showBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            showBtn.Depth = 0;
            showBtn.HighEmphasis = true;
            showBtn.Icon = null;
            showBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            showBtn.Location = new Point(653, 84);
            showBtn.Margin = new Padding(4, 6, 4, 6);
            showBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            showBtn.Name = "showBtn";
            showBtn.NoAccentTextColor = Color.Empty;
            showBtn.Size = new Size(158, 36);
            showBtn.TabIndex = 36;
            showBtn.Text = "Show";
            showBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            showBtn.UseAccentColor = false;
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
            // 
            // dateToPkr
            // 
            dateToPkr.CustomFormat = "  dd/MM/yyyy";
            dateToPkr.Format = DateTimePickerFormat.Custom;
            dateToPkr.Location = new Point(136, 79);
            dateToPkr.Name = "dateToPkr";
            dateToPkr.Size = new Size(206, 27);
            dateToPkr.TabIndex = 17;
            // 
            // dateFromPkr
            // 
            dateFromPkr.CustomFormat = "  dd/MM/yyyy";
            dateFromPkr.Format = DateTimePickerFormat.Custom;
            dateFromPkr.Location = new Point(136, 25);
            dateFromPkr.Name = "dateFromPkr";
            dateFromPkr.Size = new Size(206, 27);
            dateFromPkr.TabIndex = 16;
            // 
            // materialLabel17
            // 
            materialLabel17.Depth = 0;
            materialLabel17.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel17.Location = new Point(27, 17);
            materialLabel17.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel17.Name = "materialLabel17";
            materialLabel17.Size = new Size(103, 48);
            materialLabel17.TabIndex = 0;
            materialLabel17.Text = "From Date";
            materialLabel17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel18
            // 
            materialLabel18.Depth = 0;
            materialLabel18.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel18.Location = new Point(27, 71);
            materialLabel18.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel18.Name = "materialLabel18";
            materialLabel18.Size = new Size(103, 48);
            materialLabel18.TabIndex = 3;
            materialLabel18.Text = "To Date";
            materialLabel18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // paymentsGrd
            // 
            paymentsGrd.AllowUserToAddRows = false;
            paymentsGrd.AllowUserToDeleteRows = false;
            paymentsGrd.AllowUserToOrderColumns = true;
            paymentsGrd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            paymentsGrd.BackgroundColor = Color.White;
            paymentsGrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paymentsGrd.Location = new Point(17, 235);
            paymentsGrd.Name = "paymentsGrd";
            paymentsGrd.ReadOnly = true;
            paymentsGrd.RowHeadersWidth = 51;
            paymentsGrd.Size = new Size(829, 446);
            paymentsGrd.TabIndex = 18;
            // 
            // AllPaymentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 700);
            Controls.Add(paymentsGrd);
            Controls.Add(materialCard3);
            Name = "AllPaymentsForm";
            Text = "All Payments";
            Load += AllPaymentsForm_Load;
            materialCard3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)paymentsGrd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCard3;
        private ReaLTaiizor.Controls.MaterialButton showBtn;
        private DateTimePicker dateToPkr;
        private DateTimePicker dateFromPkr;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel17;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel18;
        private DataGridView paymentsGrd;
    }
}