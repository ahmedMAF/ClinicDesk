namespace ClinicDesk.Forms
{
    partial class InstallForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallForm));
            installBtn = new ReaLTaiizor.Controls.MaterialButton();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            dbServerTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            accountCbo = new ReaLTaiizor.Controls.MaterialComboBox();
            dbPortTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            dbNameTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            dbUserTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            dbPasswordTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            licenseServerUrlTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel8 = new ReaLTaiizor.Controls.MaterialLabel();
            nameTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel7 = new ReaLTaiizor.Controls.MaterialLabel();
            emailTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel9 = new ReaLTaiizor.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // installBtn
            // 
            installBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            installBtn.AutoSize = false;
            installBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            installBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            installBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            installBtn.Depth = 0;
            installBtn.HighEmphasis = true;
            installBtn.Icon = null;
            installBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            installBtn.Location = new Point(525, 696);
            installBtn.Margin = new Padding(4, 6, 4, 6);
            installBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            installBtn.Name = "installBtn";
            installBtn.NoAccentTextColor = Color.Empty;
            installBtn.Size = new Size(158, 36);
            installBtn.TabIndex = 0;
            installBtn.Text = "Install";
            installBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            installBtn.UseAccentColor = false;
            installBtn.UseVisualStyleBackColor = true;
            installBtn.Click += installBtn_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(6, 88);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(45, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Server";
            // 
            // dbServerTxt
            // 
            dbServerTxt.AnimateReadOnly = false;
            dbServerTxt.AutoCompleteMode = AutoCompleteMode.None;
            dbServerTxt.AutoCompleteSource = AutoCompleteSource.None;
            dbServerTxt.BackgroundImageLayout = ImageLayout.None;
            dbServerTxt.CharacterCasing = CharacterCasing.Normal;
            dbServerTxt.Depth = 0;
            dbServerTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dbServerTxt.HideSelection = true;
            dbServerTxt.LeadingIcon = null;
            dbServerTxt.Location = new Point(144, 75);
            dbServerTxt.MaxLength = 32767;
            dbServerTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            dbServerTxt.Name = "dbServerTxt";
            dbServerTxt.PasswordChar = '\0';
            dbServerTxt.PrefixSuffixText = null;
            dbServerTxt.ReadOnly = false;
            dbServerTxt.RightToLeft = RightToLeft.No;
            dbServerTxt.SelectedText = "";
            dbServerTxt.SelectionLength = 0;
            dbServerTxt.SelectionStart = 0;
            dbServerTxt.ShortcutsEnabled = true;
            dbServerTxt.Size = new Size(312, 48);
            dbServerTxt.TabIndex = 2;
            dbServerTxt.TabStop = false;
            dbServerTxt.TextAlign = HorizontalAlignment.Left;
            dbServerTxt.TrailingIcon = null;
            dbServerTxt.UseSystemPasswordChar = false;
            // 
            // accountCbo
            // 
            accountCbo.AutoResize = false;
            accountCbo.BackColor = Color.FromArgb(255, 255, 255);
            accountCbo.Depth = 0;
            accountCbo.DrawMode = DrawMode.OwnerDrawVariable;
            accountCbo.DropDownHeight = 174;
            accountCbo.DropDownStyle = ComboBoxStyle.DropDownList;
            accountCbo.DropDownWidth = 121;
            accountCbo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            accountCbo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            accountCbo.FormattingEnabled = true;
            accountCbo.IntegralHeight = false;
            accountCbo.ItemHeight = 43;
            accountCbo.Items.AddRange(new object[] { "Choose Type...", "Doctor", "Secretary", "All-In-One" });
            accountCbo.Location = new Point(144, 397);
            accountCbo.MaxDropDownItems = 4;
            accountCbo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            accountCbo.Name = "accountCbo";
            accountCbo.Size = new Size(312, 49);
            accountCbo.StartIndex = 0;
            accountCbo.TabIndex = 3;
            // 
            // dbPortTxt
            // 
            dbPortTxt.AnimateReadOnly = false;
            dbPortTxt.AutoCompleteMode = AutoCompleteMode.None;
            dbPortTxt.AutoCompleteSource = AutoCompleteSource.None;
            dbPortTxt.BackgroundImageLayout = ImageLayout.None;
            dbPortTxt.CharacterCasing = CharacterCasing.Normal;
            dbPortTxt.Depth = 0;
            dbPortTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dbPortTxt.HideSelection = true;
            dbPortTxt.LeadingIcon = null;
            dbPortTxt.Location = new Point(144, 129);
            dbPortTxt.MaxLength = 32767;
            dbPortTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            dbPortTxt.Name = "dbPortTxt";
            dbPortTxt.PasswordChar = '\0';
            dbPortTxt.PrefixSuffixText = null;
            dbPortTxt.ReadOnly = false;
            dbPortTxt.RightToLeft = RightToLeft.No;
            dbPortTxt.SelectedText = "";
            dbPortTxt.SelectionLength = 0;
            dbPortTxt.SelectionStart = 0;
            dbPortTxt.ShortcutsEnabled = true;
            dbPortTxt.Size = new Size(312, 48);
            dbPortTxt.TabIndex = 6;
            dbPortTxt.TabStop = false;
            dbPortTxt.TextAlign = HorizontalAlignment.Left;
            dbPortTxt.TrailingIcon = null;
            dbPortTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(6, 142);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(30, 19);
            materialLabel2.TabIndex = 5;
            materialLabel2.Text = "Port";
            // 
            // dbNameTxt
            // 
            dbNameTxt.AnimateReadOnly = false;
            dbNameTxt.AutoCompleteMode = AutoCompleteMode.None;
            dbNameTxt.AutoCompleteSource = AutoCompleteSource.None;
            dbNameTxt.BackgroundImageLayout = ImageLayout.None;
            dbNameTxt.CharacterCasing = CharacterCasing.Normal;
            dbNameTxt.Depth = 0;
            dbNameTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dbNameTxt.HideSelection = true;
            dbNameTxt.LeadingIcon = null;
            dbNameTxt.Location = new Point(144, 183);
            dbNameTxt.MaxLength = 32767;
            dbNameTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            dbNameTxt.Name = "dbNameTxt";
            dbNameTxt.PasswordChar = '\0';
            dbNameTxt.PrefixSuffixText = null;
            dbNameTxt.ReadOnly = false;
            dbNameTxt.RightToLeft = RightToLeft.No;
            dbNameTxt.SelectedText = "";
            dbNameTxt.SelectionLength = 0;
            dbNameTxt.SelectionStart = 0;
            dbNameTxt.ShortcutsEnabled = true;
            dbNameTxt.Size = new Size(312, 48);
            dbNameTxt.TabIndex = 8;
            dbNameTxt.TabStop = false;
            dbNameTxt.TextAlign = HorizontalAlignment.Left;
            dbNameTxt.TrailingIcon = null;
            dbNameTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(6, 196);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(69, 19);
            materialLabel3.TabIndex = 7;
            materialLabel3.Text = "Database";
            // 
            // dbUserTxt
            // 
            dbUserTxt.AnimateReadOnly = false;
            dbUserTxt.AutoCompleteMode = AutoCompleteMode.None;
            dbUserTxt.AutoCompleteSource = AutoCompleteSource.None;
            dbUserTxt.BackgroundImageLayout = ImageLayout.None;
            dbUserTxt.CharacterCasing = CharacterCasing.Normal;
            dbUserTxt.Depth = 0;
            dbUserTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dbUserTxt.HideSelection = true;
            dbUserTxt.LeadingIcon = null;
            dbUserTxt.Location = new Point(144, 237);
            dbUserTxt.MaxLength = 32767;
            dbUserTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            dbUserTxt.Name = "dbUserTxt";
            dbUserTxt.PasswordChar = '\0';
            dbUserTxt.PrefixSuffixText = null;
            dbUserTxt.ReadOnly = false;
            dbUserTxt.RightToLeft = RightToLeft.No;
            dbUserTxt.SelectedText = "";
            dbUserTxt.SelectionLength = 0;
            dbUserTxt.SelectionStart = 0;
            dbUserTxt.ShortcutsEnabled = true;
            dbUserTxt.Size = new Size(312, 48);
            dbUserTxt.TabIndex = 10;
            dbUserTxt.TabStop = false;
            dbUserTxt.TextAlign = HorizontalAlignment.Left;
            dbUserTxt.TrailingIcon = null;
            dbUserTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(6, 250);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(32, 19);
            materialLabel4.TabIndex = 9;
            materialLabel4.Text = "User";
            // 
            // dbPasswordTxt
            // 
            dbPasswordTxt.AnimateReadOnly = false;
            dbPasswordTxt.AutoCompleteMode = AutoCompleteMode.None;
            dbPasswordTxt.AutoCompleteSource = AutoCompleteSource.None;
            dbPasswordTxt.BackgroundImageLayout = ImageLayout.None;
            dbPasswordTxt.CharacterCasing = CharacterCasing.Normal;
            dbPasswordTxt.Depth = 0;
            dbPasswordTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dbPasswordTxt.HideSelection = true;
            dbPasswordTxt.LeadingIcon = null;
            dbPasswordTxt.Location = new Point(144, 291);
            dbPasswordTxt.MaxLength = 32767;
            dbPasswordTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            dbPasswordTxt.Name = "dbPasswordTxt";
            dbPasswordTxt.PasswordChar = '\0';
            dbPasswordTxt.PrefixSuffixText = null;
            dbPasswordTxt.ReadOnly = false;
            dbPasswordTxt.RightToLeft = RightToLeft.No;
            dbPasswordTxt.SelectedText = "";
            dbPasswordTxt.SelectionLength = 0;
            dbPasswordTxt.SelectionStart = 0;
            dbPasswordTxt.ShortcutsEnabled = true;
            dbPasswordTxt.Size = new Size(312, 48);
            dbPasswordTxt.TabIndex = 12;
            dbPasswordTxt.TabStop = false;
            dbPasswordTxt.TextAlign = HorizontalAlignment.Left;
            dbPasswordTxt.TrailingIcon = null;
            dbPasswordTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(6, 304);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(71, 19);
            materialLabel5.TabIndex = 11;
            materialLabel5.Text = "Password";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(6, 415);
            materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(98, 19);
            materialLabel6.TabIndex = 13;
            materialLabel6.Text = "Account Type";
            // 
            // licenseServerUrlTxt
            // 
            licenseServerUrlTxt.AnimateReadOnly = false;
            licenseServerUrlTxt.AutoCompleteMode = AutoCompleteMode.None;
            licenseServerUrlTxt.AutoCompleteSource = AutoCompleteSource.None;
            licenseServerUrlTxt.BackgroundImageLayout = ImageLayout.None;
            licenseServerUrlTxt.CharacterCasing = CharacterCasing.Normal;
            licenseServerUrlTxt.Depth = 0;
            licenseServerUrlTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            licenseServerUrlTxt.HideSelection = true;
            licenseServerUrlTxt.LeadingIcon = null;
            licenseServerUrlTxt.Location = new Point(144, 487);
            licenseServerUrlTxt.MaxLength = 32767;
            licenseServerUrlTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            licenseServerUrlTxt.Name = "licenseServerUrlTxt";
            licenseServerUrlTxt.PasswordChar = '\0';
            licenseServerUrlTxt.PrefixSuffixText = null;
            licenseServerUrlTxt.ReadOnly = false;
            licenseServerUrlTxt.RightToLeft = RightToLeft.No;
            licenseServerUrlTxt.SelectedText = "";
            licenseServerUrlTxt.SelectionLength = 0;
            licenseServerUrlTxt.SelectionStart = 0;
            licenseServerUrlTxt.ShortcutsEnabled = true;
            licenseServerUrlTxt.Size = new Size(312, 48);
            licenseServerUrlTxt.TabIndex = 15;
            licenseServerUrlTxt.TabStop = false;
            licenseServerUrlTxt.Text = "http://localhost/api/getlicense";
            licenseServerUrlTxt.TextAlign = HorizontalAlignment.Left;
            licenseServerUrlTxt.TrailingIcon = null;
            licenseServerUrlTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(6, 500);
            materialLabel8.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(136, 19);
            materialLabel8.TabIndex = 14;
            materialLabel8.Text = "License Server URL";
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
            nameTxt.Location = new Point(144, 541);
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
            nameTxt.TabIndex = 17;
            nameTxt.TabStop = false;
            nameTxt.TextAlign = HorizontalAlignment.Left;
            nameTxt.TrailingIcon = null;
            nameTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(6, 554);
            materialLabel7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(43, 19);
            materialLabel7.TabIndex = 16;
            materialLabel7.Text = "Name";
            // 
            // emailTxt
            // 
            emailTxt.AnimateReadOnly = false;
            emailTxt.AutoCompleteMode = AutoCompleteMode.None;
            emailTxt.AutoCompleteSource = AutoCompleteSource.None;
            emailTxt.BackgroundImageLayout = ImageLayout.None;
            emailTxt.CharacterCasing = CharacterCasing.Normal;
            emailTxt.Depth = 0;
            emailTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            emailTxt.HideSelection = true;
            emailTxt.LeadingIcon = null;
            emailTxt.Location = new Point(144, 595);
            emailTxt.MaxLength = 32767;
            emailTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            emailTxt.Name = "emailTxt";
            emailTxt.PasswordChar = '\0';
            emailTxt.PrefixSuffixText = null;
            emailTxt.ReadOnly = false;
            emailTxt.RightToLeft = RightToLeft.No;
            emailTxt.SelectedText = "";
            emailTxt.SelectionLength = 0;
            emailTxt.SelectionStart = 0;
            emailTxt.ShortcutsEnabled = true;
            emailTxt.Size = new Size(312, 48);
            emailTxt.TabIndex = 19;
            emailTxt.TabStop = false;
            emailTxt.TextAlign = HorizontalAlignment.Left;
            emailTxt.TrailingIcon = null;
            emailTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(6, 608);
            materialLabel9.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(41, 19);
            materialLabel9.TabIndex = 18;
            materialLabel9.Text = "Email";
            // 
            // InstallForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 741);
            Controls.Add(emailTxt);
            Controls.Add(materialLabel9);
            Controls.Add(nameTxt);
            Controls.Add(materialLabel7);
            Controls.Add(licenseServerUrlTxt);
            Controls.Add(materialLabel8);
            Controls.Add(materialLabel6);
            Controls.Add(dbPasswordTxt);
            Controls.Add(materialLabel5);
            Controls.Add(dbUserTxt);
            Controls.Add(materialLabel4);
            Controls.Add(dbNameTxt);
            Controls.Add(materialLabel3);
            Controls.Add(dbPortTxt);
            Controls.Add(materialLabel2);
            Controls.Add(accountCbo);
            Controls.Add(dbServerTxt);
            Controls.Add(materialLabel1);
            Controls.Add(installBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InstallForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Install ClinicDesk";
            Load += InstallForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialButton installBtn;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit dbServerTxt;
        private ReaLTaiizor.Controls.MaterialComboBox accountCbo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit dbPortTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit dbNameTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit dbUserTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit dbPasswordTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit licenseServerUrlTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel8;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit nameTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel7;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit emailTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel9;
    }
}