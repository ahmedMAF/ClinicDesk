namespace ClinicDesk.Forms
{
    partial class PatientSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientSearchForm));
            searchNameBtn = new ReaLTaiizor.Controls.MaterialButton();
            nameTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            phoneTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            searchPhoneBtn = new ReaLTaiizor.Controls.MaterialButton();
            patientsGrd = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)patientsGrd).BeginInit();
            SuspendLayout();
            // 
            // searchNameBtn
            // 
            searchNameBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchNameBtn.AutoSize = false;
            searchNameBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchNameBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            searchNameBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            searchNameBtn.Depth = 0;
            searchNameBtn.HighEmphasis = true;
            searchNameBtn.Icon = null;
            searchNameBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            searchNameBtn.Location = new Point(526, 81);
            searchNameBtn.Margin = new Padding(4, 6, 4, 6);
            searchNameBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            searchNameBtn.Name = "searchNameBtn";
            searchNameBtn.NoAccentTextColor = Color.Empty;
            searchNameBtn.Size = new Size(167, 36);
            searchNameBtn.TabIndex = 1;
            searchNameBtn.Text = "Search by Name";
            searchNameBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            searchNameBtn.UseAccentColor = false;
            searchNameBtn.UseVisualStyleBackColor = true;
            searchNameBtn.Click += searchNameBtn_Click;
            // 
            // nameTxt
            // 
            nameTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTxt.AnimateReadOnly = false;
            nameTxt.AutoCompleteMode = AutoCompleteMode.None;
            nameTxt.AutoCompleteSource = AutoCompleteSource.None;
            nameTxt.BackgroundImageLayout = ImageLayout.None;
            nameTxt.CharacterCasing = CharacterCasing.Normal;
            nameTxt.Depth = 0;
            nameTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nameTxt.HideSelection = true;
            nameTxt.LeadingIcon = null;
            nameTxt.Location = new Point(85, 75);
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
            nameTxt.Size = new Size(434, 48);
            nameTxt.TabIndex = 0;
            nameTxt.TabStop = false;
            nameTxt.TextAlign = HorizontalAlignment.Left;
            nameTxt.TrailingIcon = null;
            nameTxt.UseSystemPasswordChar = false;
            nameTxt.KeyPress += nameTxt_KeyPress;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(6, 92);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(73, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Full Name";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(6, 146);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(46, 19);
            materialLabel2.TabIndex = 5;
            materialLabel2.Text = "Phone";
            // 
            // phoneTxt
            // 
            phoneTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            phoneTxt.AnimateReadOnly = false;
            phoneTxt.AutoCompleteMode = AutoCompleteMode.None;
            phoneTxt.AutoCompleteSource = AutoCompleteSource.None;
            phoneTxt.BackgroundImageLayout = ImageLayout.None;
            phoneTxt.CharacterCasing = CharacterCasing.Normal;
            phoneTxt.Depth = 0;
            phoneTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            phoneTxt.HideSelection = true;
            phoneTxt.LeadingIcon = null;
            phoneTxt.Location = new Point(85, 129);
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
            phoneTxt.Size = new Size(434, 48);
            phoneTxt.TabIndex = 2;
            phoneTxt.TabStop = false;
            phoneTxt.TextAlign = HorizontalAlignment.Left;
            phoneTxt.TrailingIcon = null;
            phoneTxt.UseSystemPasswordChar = false;
            phoneTxt.KeyPress += phoneTxt_KeyPress;
            // 
            // searchPhoneBtn
            // 
            searchPhoneBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchPhoneBtn.AutoSize = false;
            searchPhoneBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchPhoneBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            searchPhoneBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            searchPhoneBtn.Depth = 0;
            searchPhoneBtn.HighEmphasis = true;
            searchPhoneBtn.Icon = null;
            searchPhoneBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            searchPhoneBtn.Location = new Point(526, 135);
            searchPhoneBtn.Margin = new Padding(4, 6, 4, 6);
            searchPhoneBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            searchPhoneBtn.Name = "searchPhoneBtn";
            searchPhoneBtn.NoAccentTextColor = Color.Empty;
            searchPhoneBtn.Size = new Size(167, 36);
            searchPhoneBtn.TabIndex = 4;
            searchPhoneBtn.Text = "Search by Phone";
            searchPhoneBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            searchPhoneBtn.UseAccentColor = false;
            searchPhoneBtn.UseVisualStyleBackColor = true;
            searchPhoneBtn.Click += searchPhoneBtn_Click;
            // 
            // patientsGrd
            // 
            patientsGrd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            patientsGrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientsGrd.Location = new Point(6, 211);
            patientsGrd.Name = "patientsGrd";
            patientsGrd.RowHeadersWidth = 51;
            patientsGrd.Size = new Size(687, 253);
            patientsGrd.TabIndex = 6;
            // 
            // PatientSearchForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(700, 470);
            Controls.Add(patientsGrd);
            Controls.Add(materialLabel2);
            Controls.Add(phoneTxt);
            Controls.Add(searchPhoneBtn);
            Controls.Add(materialLabel1);
            Controls.Add(nameTxt);
            Controls.Add(searchNameBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PatientSearchForm";
            ShowInTaskbar = false;
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient Search";
            Load += PatientSearchForm_Load;
            ((System.ComponentModel.ISupportInitialize)patientsGrd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialButton searchNameBtn;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit nameTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit phoneTxt;
        private ReaLTaiizor.Controls.MaterialButton searchPhoneBtn;
        private DataGridView patientsGrd;
    }
}