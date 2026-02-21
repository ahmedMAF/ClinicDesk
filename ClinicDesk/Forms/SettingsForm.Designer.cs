namespace ClinicDesk.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            isDarkSwt = new ReaLTaiizor.Controls.MaterialSwitch();
            materialLabel11 = new ReaLTaiizor.Controls.MaterialLabel();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            backupCustomBtn = new ReaLTaiizor.Controls.MaterialButton();
            backupBtn = new ReaLTaiizor.Controls.MaterialButton();
            browseBtn = new ReaLTaiizor.Controls.MaterialButton();
            daysSld = new ReaLTaiizor.Controls.MaterialSlider();
            materialLabel10 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel13 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            backupTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dbServerTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            dbPortTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            dbNameTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            dbUserTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dbPasswordTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            saveBtn = new ReaLTaiizor.Controls.MaterialButton();
            folderBrowser = new FolderBrowserDialog();
            materialCard2.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(isDarkSwt);
            materialCard2.Controls.Add(materialLabel11);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(532, 78);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(487, 106);
            materialCard2.TabIndex = 25;
            // 
            // isDarkSwt
            // 
            isDarkSwt.AutoSize = true;
            isDarkSwt.Depth = 0;
            isDarkSwt.Location = new Point(14, 54);
            isDarkSwt.Margin = new Padding(0);
            isDarkSwt.MouseLocation = new Point(-1, -1);
            isDarkSwt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            isDarkSwt.Name = "isDarkSwt";
            isDarkSwt.Ripple = true;
            isDarkSwt.Size = new Size(144, 37);
            isDarkSwt.TabIndex = 14;
            isDarkSwt.Text = "Dark Theme";
            isDarkSwt.UseAccentColor = false;
            isDarkSwt.UseVisualStyleBackColor = true;
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel11.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            materialLabel11.Location = new Point(17, 14);
            materialLabel11.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(44, 24);
            materialLabel11.TabIndex = 13;
            materialLabel11.Text = "Misc";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(backupCustomBtn);
            materialCard1.Controls.Add(backupBtn);
            materialCard1.Controls.Add(browseBtn);
            materialCard1.Controls.Add(daysSld);
            materialCard1.Controls.Add(materialLabel10);
            materialCard1.Controls.Add(materialLabel13);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Controls.Add(backupTxt);
            materialCard1.Controls.Add(dbServerTxt);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Controls.Add(dbPortTxt);
            materialCard1.Controls.Add(materialLabel3);
            materialCard1.Controls.Add(dbNameTxt);
            materialCard1.Controls.Add(materialLabel4);
            materialCard1.Controls.Add(dbUserTxt);
            materialCard1.Controls.Add(dbPasswordTxt);
            materialCard1.Controls.Add(materialLabel5);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 78);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(487, 528);
            materialCard1.TabIndex = 24;
            // 
            // backupCustomBtn
            // 
            backupCustomBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            backupCustomBtn.AutoSize = false;
            backupCustomBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            backupCustomBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            backupCustomBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            backupCustomBtn.Depth = 0;
            backupCustomBtn.HighEmphasis = true;
            backupCustomBtn.Icon = null;
            backupCustomBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            backupCustomBtn.Location = new Point(20, 465);
            backupCustomBtn.Margin = new Padding(4, 6, 4, 6);
            backupCustomBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            backupCustomBtn.Name = "backupCustomBtn";
            backupCustomBtn.NoAccentTextColor = Color.Empty;
            backupCustomBtn.Size = new Size(449, 36);
            backupCustomBtn.TabIndex = 27;
            backupCustomBtn.Text = "Backup to Custom Path";
            backupCustomBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            backupCustomBtn.UseAccentColor = false;
            backupCustomBtn.UseVisualStyleBackColor = true;
            backupCustomBtn.Click += backupCustomBtn_Click;
            // 
            // backupBtn
            // 
            backupBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            backupBtn.AutoSize = false;
            backupBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            backupBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            backupBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            backupBtn.Depth = 0;
            backupBtn.HighEmphasis = true;
            backupBtn.Icon = null;
            backupBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            backupBtn.Location = new Point(20, 417);
            backupBtn.Margin = new Padding(4, 6, 4, 6);
            backupBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            backupBtn.Name = "backupBtn";
            backupBtn.NoAccentTextColor = Color.Empty;
            backupBtn.Size = new Size(449, 36);
            backupBtn.TabIndex = 26;
            backupBtn.Text = "Backup Now";
            backupBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            backupBtn.UseAccentColor = false;
            backupBtn.UseVisualStyleBackColor = true;
            backupBtn.Click += backupBtn_Click;
            // 
            // browseBtn
            // 
            browseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            browseBtn.AutoSize = false;
            browseBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            browseBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            browseBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            browseBtn.Depth = 0;
            browseBtn.HighEmphasis = true;
            browseBtn.Icon = null;
            browseBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            browseBtn.Location = new Point(422, 311);
            browseBtn.Margin = new Padding(4, 6, 4, 6);
            browseBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            browseBtn.Name = "browseBtn";
            browseBtn.NoAccentTextColor = Color.Empty;
            browseBtn.Size = new Size(48, 48);
            browseBtn.TabIndex = 24;
            browseBtn.Text = "...";
            browseBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            browseBtn.UseAccentColor = false;
            browseBtn.UseVisualStyleBackColor = true;
            browseBtn.Click += browseBtn_Click;
            // 
            // daysSld
            // 
            daysSld.Depth = 0;
            daysSld.ForeColor = Color.FromArgb(222, 0, 0, 0);
            daysSld.Location = new Point(20, 368);
            daysSld.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            daysSld.Name = "daysSld";
            daysSld.RangeMax = 7;
            daysSld.RangeMin = 1;
            daysSld.Size = new Size(450, 40);
            daysSld.StepChange = 1;
            daysSld.TabIndex = 16;
            daysSld.Text = "Backup Frequency";
            daysSld.Value = 2;
            daysSld.ValueSuffix = " Days";
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel10.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            materialLabel10.Location = new Point(17, 14);
            materialLabel10.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(86, 24);
            materialLabel10.TabIndex = 13;
            materialLabel10.Text = "Database";
            // 
            // materialLabel13
            // 
            materialLabel13.AutoSize = true;
            materialLabel13.Depth = 0;
            materialLabel13.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel13.Location = new Point(20, 324);
            materialLabel13.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(91, 19);
            materialLabel13.TabIndex = 5;
            materialLabel13.Text = "Backup Path";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(20, 54);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(45, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Server";
            // 
            // backupTxt
            // 
            backupTxt.AnimateReadOnly = false;
            backupTxt.AutoCompleteMode = AutoCompleteMode.None;
            backupTxt.AutoCompleteSource = AutoCompleteSource.None;
            backupTxt.BackgroundImageLayout = ImageLayout.None;
            backupTxt.CharacterCasing = CharacterCasing.Normal;
            backupTxt.Depth = 0;
            backupTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            backupTxt.HideSelection = true;
            backupTxt.LeadingIcon = null;
            backupTxt.Location = new Point(158, 311);
            backupTxt.MaxLength = 32767;
            backupTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            backupTxt.Name = "backupTxt";
            backupTxt.PasswordChar = '\0';
            backupTxt.PrefixSuffixText = null;
            backupTxt.ReadOnly = false;
            backupTxt.RightToLeft = RightToLeft.No;
            backupTxt.SelectedText = "";
            backupTxt.SelectionLength = 0;
            backupTxt.SelectionStart = 0;
            backupTxt.ShortcutsEnabled = true;
            backupTxt.Size = new Size(257, 48);
            backupTxt.TabIndex = 6;
            backupTxt.TabStop = false;
            backupTxt.TextAlign = HorizontalAlignment.Left;
            backupTxt.TrailingIcon = null;
            backupTxt.UseSystemPasswordChar = false;
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
            dbServerTxt.Location = new Point(158, 41);
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
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(20, 108);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(30, 19);
            materialLabel2.TabIndex = 5;
            materialLabel2.Text = "Port";
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
            dbPortTxt.Location = new Point(158, 95);
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
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(20, 162);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(69, 19);
            materialLabel3.TabIndex = 7;
            materialLabel3.Text = "Database";
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
            dbNameTxt.Location = new Point(158, 149);
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
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(20, 216);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(32, 19);
            materialLabel4.TabIndex = 9;
            materialLabel4.Text = "User";
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
            dbUserTxt.Location = new Point(158, 203);
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
            dbPasswordTxt.Location = new Point(158, 257);
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
            materialLabel5.Location = new Point(20, 270);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(71, 19);
            materialLabel5.TabIndex = 11;
            materialLabel5.Text = "Password";
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveBtn.AutoSize = false;
            saveBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            saveBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            saveBtn.Depth = 0;
            saveBtn.HighEmphasis = true;
            saveBtn.Icon = null;
            saveBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            saveBtn.Location = new Point(861, 570);
            saveBtn.Margin = new Padding(4, 6, 4, 6);
            saveBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            saveBtn.Name = "saveBtn";
            saveBtn.NoAccentTextColor = Color.Empty;
            saveBtn.Size = new Size(158, 36);
            saveBtn.TabIndex = 23;
            saveBtn.Text = "Save";
            saveBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            saveBtn.UseAccentColor = false;
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // folderBrowser
            // 
            folderBrowser.Description = "Select a folder to store database backups in";
            // 
            // SettingsForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1040, 623);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Controls.Add(saveBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SettingsForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += SettingsForm_Load;
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private ReaLTaiizor.Controls.MaterialSwitch isDarkSwt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel11;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialSlider daysSld;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel10;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel13;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit backupTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit dbServerTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit dbPortTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit dbNameTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit dbUserTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit dbPasswordTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private ReaLTaiizor.Controls.MaterialButton saveBtn;
        private ReaLTaiizor.Controls.MaterialButton browseBtn;
        private ReaLTaiizor.Controls.MaterialButton backupBtn;
        private ReaLTaiizor.Controls.MaterialButton backupCustomBtn;
        private FolderBrowserDialog folderBrowser;
    }
}