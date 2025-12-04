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
            groupBox1 = new GroupBox();
            searchPhoneBtn = new Button();
            searchNameBtn = new Button();
            phoneTxt = new TextBox();
            label4 = new Label();
            nameTxt = new TextBox();
            label1 = new Label();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            invoicesGrd = new DataGridView();
            materialTextBoxEdit1 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)invoicesGrd).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(searchPhoneBtn);
            groupBox1.Controls.Add(searchNameBtn);
            groupBox1.Controls.Add(phoneTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nameTxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1083, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patient Data";
            // 
            // searchPhoneBtn
            // 
            searchPhoneBtn.Location = new Point(468, 58);
            searchPhoneBtn.Name = "searchPhoneBtn";
            searchPhoneBtn.Size = new Size(142, 29);
            searchPhoneBtn.TabIndex = 8;
            searchPhoneBtn.Text = "Search By Phone";
            searchPhoneBtn.UseVisualStyleBackColor = true;
            // 
            // searchNameBtn
            // 
            searchNameBtn.Location = new Point(468, 24);
            searchNameBtn.Name = "searchNameBtn";
            searchNameBtn.Size = new Size(142, 29);
            searchNameBtn.TabIndex = 6;
            searchNameBtn.Text = "Search By Name";
            searchNameBtn.UseVisualStyleBackColor = true;
            // 
            // phoneTxt
            // 
            phoneTxt.Location = new Point(120, 59);
            phoneTxt.Name = "phoneTxt";
            phoneTxt.Size = new Size(342, 27);
            phoneTxt.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 62);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 6;
            label4.Text = "Phone Number";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(120, 26);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(342, 27);
            nameTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(12, 176);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(158, 36);
            materialButton1.TabIndex = 4;
            materialButton1.Text = "materialButton1";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // invoicesGrd
            // 
            invoicesGrd.AllowUserToAddRows = false;
            invoicesGrd.AllowUserToDeleteRows = false;
            invoicesGrd.AllowUserToOrderColumns = true;
            invoicesGrd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            invoicesGrd.BackgroundColor = Color.White;
            invoicesGrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            invoicesGrd.Location = new Point(12, 221);
            invoicesGrd.Name = "invoicesGrd";
            invoicesGrd.ReadOnly = true;
            invoicesGrd.RowHeadersWidth = 51;
            invoicesGrd.Size = new Size(1077, 608);
            invoicesGrd.TabIndex = 5;
            invoicesGrd.CellClick += invoicesGrd_CellClick;
            // 
            // materialTextBoxEdit1
            // 
            materialTextBoxEdit1.AnimateReadOnly = false;
            materialTextBoxEdit1.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit1.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit1.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit1.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit1.Depth = 0;
            materialTextBoxEdit1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit1.HideSelection = true;
            materialTextBoxEdit1.LeadingIcon = null;
            materialTextBoxEdit1.Location = new Point(177, 173);
            materialTextBoxEdit1.MaxLength = 32767;
            materialTextBoxEdit1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit1.Name = "materialTextBoxEdit1";
            materialTextBoxEdit1.PasswordChar = '\0';
            materialTextBoxEdit1.PrefixSuffixText = null;
            materialTextBoxEdit1.ReadOnly = false;
            materialTextBoxEdit1.RightToLeft = RightToLeft.No;
            materialTextBoxEdit1.SelectedText = "";
            materialTextBoxEdit1.SelectionLength = 0;
            materialTextBoxEdit1.SelectionStart = 0;
            materialTextBoxEdit1.ShortcutsEnabled = true;
            materialTextBoxEdit1.Size = new Size(312, 48);
            materialTextBoxEdit1.TabIndex = 6;
            materialTextBoxEdit1.TabStop = false;
            materialTextBoxEdit1.Text = "materialTextBoxEdit1";
            materialTextBoxEdit1.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit1.TrailingIcon = null;
            materialTextBoxEdit1.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(509, 199);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(107, 19);
            materialLabel1.TabIndex = 7;
            materialLabel1.Text = "materialLabel1";
            // 
            // BillingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 835);
            Controls.Add(materialLabel1);
            Controls.Add(materialTextBoxEdit1);
            Controls.Add(invoicesGrd);
            Controls.Add(materialButton1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BillingForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BillingForm";
            Load += BillingForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)invoicesGrd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button searchPhoneBtn;
        private Button searchNameBtn;
        private TextBox phoneTxt;
        private Label label4;
        private TextBox nameTxt;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private DataGridView invoicesGrd;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
    }
}