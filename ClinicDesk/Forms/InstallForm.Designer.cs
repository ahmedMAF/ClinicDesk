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
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            browseBtn = new ReaLTaiizor.Controls.MaterialButton();
            daysSld = new ReaLTaiizor.Controls.MaterialSlider();
            materialLabel10 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel13 = new ReaLTaiizor.Controls.MaterialLabel();
            backupTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            apiUrltxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel14 = new ReaLTaiizor.Controls.MaterialLabel();
            apiSwt = new ReaLTaiizor.Controls.MaterialSwitch();
            isDentalSwt = new ReaLTaiizor.Controls.MaterialSwitch();
            materialLabel11 = new ReaLTaiizor.Controls.MaterialLabel();
            materialCard3 = new ReaLTaiizor.Controls.MaterialCard();
            passwordTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel15 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel12 = new ReaLTaiizor.Controls.MaterialLabel();
            folderBrowser = new FolderBrowserDialog();
            usernameTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel16 = new ReaLTaiizor.Controls.MaterialLabel();
            progressBar = new ReaLTaiizor.Controls.MaterialProgressBar();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard3.SuspendLayout();
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
            installBtn.Location = new Point(984, 711);
            installBtn.Margin = new Padding(5, 8, 5, 8);
            installBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            installBtn.Name = "installBtn";
            installBtn.NoAccentTextColor = Color.Empty;
            installBtn.Size = new Size(181, 48);
            installBtn.TabIndex = 0;
            installBtn.Text = "Install";
            installBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            installBtn.UseAccentColor = false;
            installBtn.UseVisualStyleBackColor = true;
            installBtn.Click += installBtn_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(23, 55);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(152, 48);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Server";
            materialLabel1.TextAlign = ContentAlignment.MiddleLeft;
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
            dbServerTxt.Location = new Point(181, 55);
            dbServerTxt.Margin = new Padding(3, 4, 3, 4);
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
            dbServerTxt.Size = new Size(357, 48);
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
            accountCbo.Location = new Point(181, 335);
            accountCbo.Margin = new Padding(3, 4, 3, 4);
            accountCbo.MaxDropDownItems = 4;
            accountCbo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            accountCbo.Name = "accountCbo";
            accountCbo.Size = new Size(357, 49);
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
            dbPortTxt.Location = new Point(181, 111);
            dbPortTxt.Margin = new Padding(3, 4, 3, 4);
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
            dbPortTxt.Size = new Size(357, 48);
            dbPortTxt.TabIndex = 6;
            dbPortTxt.TabStop = false;
            dbPortTxt.TextAlign = HorizontalAlignment.Left;
            dbPortTxt.TrailingIcon = null;
            dbPortTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(23, 111);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(152, 48);
            materialLabel2.TabIndex = 5;
            materialLabel2.Text = "Port";
            materialLabel2.TextAlign = ContentAlignment.MiddleLeft;
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
            dbNameTxt.Location = new Point(180, 167);
            dbNameTxt.Margin = new Padding(3, 4, 3, 4);
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
            dbNameTxt.Size = new Size(357, 48);
            dbNameTxt.TabIndex = 8;
            dbNameTxt.TabStop = false;
            dbNameTxt.TextAlign = HorizontalAlignment.Left;
            dbNameTxt.TrailingIcon = null;
            dbNameTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(23, 167);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(151, 48);
            materialLabel3.TabIndex = 7;
            materialLabel3.Text = "Database";
            materialLabel3.TextAlign = ContentAlignment.MiddleLeft;
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
            dbUserTxt.Location = new Point(180, 223);
            dbUserTxt.Margin = new Padding(3, 4, 3, 4);
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
            dbUserTxt.Size = new Size(357, 48);
            dbUserTxt.TabIndex = 10;
            dbUserTxt.TabStop = false;
            dbUserTxt.TextAlign = HorizontalAlignment.Left;
            dbUserTxt.TrailingIcon = null;
            dbUserTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(23, 223);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(151, 48);
            materialLabel4.TabIndex = 9;
            materialLabel4.Text = "User";
            materialLabel4.TextAlign = ContentAlignment.MiddleLeft;
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
            dbPasswordTxt.Location = new Point(180, 279);
            dbPasswordTxt.Margin = new Padding(3, 4, 3, 4);
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
            dbPasswordTxt.Size = new Size(357, 48);
            dbPasswordTxt.TabIndex = 12;
            dbPasswordTxt.TabStop = false;
            dbPasswordTxt.TextAlign = HorizontalAlignment.Left;
            dbPasswordTxt.TrailingIcon = null;
            dbPasswordTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(23, 279);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(151, 48);
            materialLabel5.TabIndex = 11;
            materialLabel5.Text = "Password";
            materialLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel6
            // 
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(23, 335);
            materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(152, 49);
            materialLabel6.TabIndex = 13;
            materialLabel6.Text = "Account Type";
            materialLabel6.TextAlign = ContentAlignment.MiddleLeft;
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
            licenseServerUrlTxt.Location = new Point(181, 55);
            licenseServerUrlTxt.Margin = new Padding(3, 4, 3, 4);
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
            licenseServerUrlTxt.Size = new Size(357, 48);
            licenseServerUrlTxt.TabIndex = 15;
            licenseServerUrlTxt.TabStop = false;
            licenseServerUrlTxt.Text = "http://localhost/api/getlicense";
            licenseServerUrlTxt.TextAlign = HorizontalAlignment.Left;
            licenseServerUrlTxt.TrailingIcon = null;
            licenseServerUrlTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(23, 55);
            materialLabel8.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(152, 48);
            materialLabel8.TabIndex = 14;
            materialLabel8.Text = "License Server URL";
            materialLabel8.TextAlign = ContentAlignment.MiddleLeft;
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
            nameTxt.Location = new Point(181, 111);
            nameTxt.Margin = new Padding(3, 4, 3, 4);
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
            nameTxt.Size = new Size(357, 48);
            nameTxt.TabIndex = 17;
            nameTxt.TabStop = false;
            nameTxt.TextAlign = HorizontalAlignment.Left;
            nameTxt.TrailingIcon = null;
            nameTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(23, 111);
            materialLabel7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(152, 48);
            materialLabel7.TabIndex = 16;
            materialLabel7.Text = "Name";
            materialLabel7.TextAlign = ContentAlignment.MiddleLeft;
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
            emailTxt.Location = new Point(181, 167);
            emailTxt.Margin = new Padding(3, 4, 3, 4);
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
            emailTxt.Size = new Size(357, 48);
            emailTxt.TabIndex = 19;
            emailTxt.TabStop = false;
            emailTxt.TextAlign = HorizontalAlignment.Left;
            emailTxt.TrailingIcon = null;
            emailTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(23, 167);
            materialLabel9.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(152, 48);
            materialLabel9.TabIndex = 18;
            materialLabel9.Text = "Email";
            materialLabel9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
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
            materialCard1.Location = new Point(608, 104);
            materialCard1.Margin = new Padding(16, 19, 16, 19);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(16, 19, 16, 19);
            materialCard1.Size = new Size(557, 450);
            materialCard1.TabIndex = 20;
            // 
            // browseBtn
            // 
            browseBtn.AutoSize = false;
            browseBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            browseBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            browseBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            browseBtn.Depth = 0;
            browseBtn.HighEmphasis = true;
            browseBtn.Icon = null;
            browseBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            browseBtn.Location = new Point(481, 335);
            browseBtn.Margin = new Padding(5, 8, 5, 8);
            browseBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            browseBtn.Name = "browseBtn";
            browseBtn.NoAccentTextColor = Color.Empty;
            browseBtn.Size = new Size(55, 48);
            browseBtn.TabIndex = 23;
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
            daysSld.Location = new Point(23, 395);
            daysSld.Margin = new Padding(3, 4, 3, 4);
            daysSld.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            daysSld.Name = "daysSld";
            daysSld.RangeMax = 7;
            daysSld.RangeMin = 1;
            daysSld.Size = new Size(515, 40);
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
            materialLabel10.Location = new Point(19, 19);
            materialLabel10.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(86, 24);
            materialLabel10.TabIndex = 13;
            materialLabel10.Text = "Database";
            // 
            // materialLabel13
            // 
            materialLabel13.Depth = 0;
            materialLabel13.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel13.Location = new Point(23, 335);
            materialLabel13.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(151, 48);
            materialLabel13.TabIndex = 5;
            materialLabel13.Text = "Backup Path";
            materialLabel13.TextAlign = ContentAlignment.MiddleLeft;
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
            backupTxt.Location = new Point(180, 335);
            backupTxt.Margin = new Padding(3, 4, 3, 4);
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
            backupTxt.Size = new Size(294, 48);
            backupTxt.TabIndex = 6;
            backupTxt.TabStop = false;
            backupTxt.TextAlign = HorizontalAlignment.Left;
            backupTxt.TrailingIcon = null;
            backupTxt.UseSystemPasswordChar = false;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(apiUrltxt);
            materialCard2.Controls.Add(materialLabel14);
            materialCard2.Controls.Add(apiSwt);
            materialCard2.Controls.Add(isDentalSwt);
            materialCard2.Controls.Add(materialLabel11);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(19, 550);
            materialCard2.Margin = new Padding(16, 19, 16, 19);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(16, 19, 16, 19);
            materialCard2.Size = new Size(557, 210);
            materialCard2.TabIndex = 21;
            // 
            // apiUrltxt
            // 
            apiUrltxt.AnimateReadOnly = false;
            apiUrltxt.AutoCompleteMode = AutoCompleteMode.None;
            apiUrltxt.AutoCompleteSource = AutoCompleteSource.None;
            apiUrltxt.BackgroundImageLayout = ImageLayout.None;
            apiUrltxt.CharacterCasing = CharacterCasing.Normal;
            apiUrltxt.Depth = 0;
            apiUrltxt.Enabled = false;
            apiUrltxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            apiUrltxt.HideSelection = true;
            apiUrltxt.LeadingIcon = null;
            apiUrltxt.Location = new Point(181, 139);
            apiUrltxt.Margin = new Padding(3, 4, 3, 4);
            apiUrltxt.MaxLength = 32767;
            apiUrltxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            apiUrltxt.Name = "apiUrltxt";
            apiUrltxt.PasswordChar = '\0';
            apiUrltxt.PrefixSuffixText = null;
            apiUrltxt.ReadOnly = false;
            apiUrltxt.RightToLeft = RightToLeft.No;
            apiUrltxt.SelectedText = "";
            apiUrltxt.SelectionLength = 0;
            apiUrltxt.SelectionStart = 0;
            apiUrltxt.ShortcutsEnabled = true;
            apiUrltxt.Size = new Size(357, 48);
            apiUrltxt.TabIndex = 17;
            apiUrltxt.TabStop = false;
            apiUrltxt.Text = "http://localhost/api/getlicense";
            apiUrltxt.TextAlign = HorizontalAlignment.Left;
            apiUrltxt.TrailingIcon = null;
            apiUrltxt.UseSystemPasswordChar = false;
            // 
            // materialLabel14
            // 
            materialLabel14.Depth = 0;
            materialLabel14.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel14.Location = new Point(23, 139);
            materialLabel14.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel14.Name = "materialLabel14";
            materialLabel14.Size = new Size(152, 48);
            materialLabel14.TabIndex = 16;
            materialLabel14.Text = "API URL";
            materialLabel14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // apiSwt
            // 
            apiSwt.AutoSize = true;
            apiSwt.Depth = 0;
            apiSwt.Location = new Point(23, 98);
            apiSwt.Margin = new Padding(0);
            apiSwt.MouseLocation = new Point(-1, -1);
            apiSwt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            apiSwt.Name = "apiSwt";
            apiSwt.Ripple = true;
            apiSwt.Size = new Size(215, 37);
            apiSwt.TabIndex = 15;
            apiSwt.Text = "Use Appointments API";
            apiSwt.UseAccentColor = false;
            apiSwt.UseVisualStyleBackColor = true;
            apiSwt.CheckedChanged += apiSwt_CheckedChanged;
            // 
            // isDentalSwt
            // 
            isDentalSwt.AutoSize = true;
            isDentalSwt.Depth = 0;
            isDentalSwt.Location = new Point(23, 61);
            isDentalSwt.Margin = new Padding(0);
            isDentalSwt.MouseLocation = new Point(-1, -1);
            isDentalSwt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            isDentalSwt.Name = "isDentalSwt";
            isDentalSwt.Ripple = true;
            isDentalSwt.Size = new Size(165, 37);
            isDentalSwt.TabIndex = 14;
            isDentalSwt.Text = "Dentist Version";
            isDentalSwt.UseAccentColor = false;
            isDentalSwt.UseVisualStyleBackColor = true;
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel11.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            materialLabel11.Location = new Point(19, 19);
            materialLabel11.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(115, 24);
            materialLabel11.TabIndex = 13;
            materialLabel11.Text = "App Settings";
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(usernameTxt);
            materialCard3.Controls.Add(materialLabel16);
            materialCard3.Controls.Add(passwordTxt);
            materialCard3.Controls.Add(materialLabel15);
            materialCard3.Controls.Add(materialLabel12);
            materialCard3.Controls.Add(emailTxt);
            materialCard3.Controls.Add(licenseServerUrlTxt);
            materialCard3.Controls.Add(accountCbo);
            materialCard3.Controls.Add(materialLabel6);
            materialCard3.Controls.Add(materialLabel9);
            materialCard3.Controls.Add(materialLabel8);
            materialCard3.Controls.Add(nameTxt);
            materialCard3.Controls.Add(materialLabel7);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(19, 104);
            materialCard3.Margin = new Padding(16, 19, 16, 19);
            materialCard3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(16, 19, 16, 19);
            materialCard3.Size = new Size(557, 408);
            materialCard3.TabIndex = 22;
            // 
            // passwordTxt
            // 
            passwordTxt.AnimateReadOnly = false;
            passwordTxt.AutoCompleteMode = AutoCompleteMode.None;
            passwordTxt.AutoCompleteSource = AutoCompleteSource.None;
            passwordTxt.BackgroundImageLayout = ImageLayout.None;
            passwordTxt.CharacterCasing = CharacterCasing.Normal;
            passwordTxt.Depth = 0;
            passwordTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordTxt.HideSelection = true;
            passwordTxt.Hint = "For Login";
            passwordTxt.LeadingIcon = null;
            passwordTxt.Location = new Point(181, 279);
            passwordTxt.Margin = new Padding(3, 4, 3, 4);
            passwordTxt.MaxLength = 32767;
            passwordTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '\0';
            passwordTxt.PrefixSuffixText = null;
            passwordTxt.ReadOnly = false;
            passwordTxt.RightToLeft = RightToLeft.No;
            passwordTxt.SelectedText = "";
            passwordTxt.SelectionLength = 0;
            passwordTxt.SelectionStart = 0;
            passwordTxt.ShortcutsEnabled = true;
            passwordTxt.Size = new Size(357, 48);
            passwordTxt.TabIndex = 21;
            passwordTxt.TabStop = false;
            passwordTxt.TextAlign = HorizontalAlignment.Left;
            passwordTxt.TrailingIcon = null;
            passwordTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel15
            // 
            materialLabel15.Depth = 0;
            materialLabel15.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel15.Location = new Point(23, 279);
            materialLabel15.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel15.Name = "materialLabel15";
            materialLabel15.Size = new Size(152, 48);
            materialLabel15.TabIndex = 20;
            materialLabel15.Text = "Password";
            materialLabel15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel12.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            materialLabel12.Location = new Point(19, 19);
            materialLabel12.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(89, 24);
            materialLabel12.TabIndex = 13;
            materialLabel12.Text = "User Data";
            // 
            // folderBrowser
            // 
            folderBrowser.Description = "Select a folder to store database backups in";
            // 
            // usernameTxt
            // 
            usernameTxt.AnimateReadOnly = false;
            usernameTxt.AutoCompleteMode = AutoCompleteMode.None;
            usernameTxt.AutoCompleteSource = AutoCompleteSource.None;
            usernameTxt.BackgroundImageLayout = ImageLayout.None;
            usernameTxt.CharacterCasing = CharacterCasing.Normal;
            usernameTxt.Depth = 0;
            usernameTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            usernameTxt.HideSelection = true;
            usernameTxt.Hint = "For Login";
            usernameTxt.LeadingIcon = null;
            usernameTxt.Location = new Point(181, 223);
            usernameTxt.Margin = new Padding(3, 4, 3, 4);
            usernameTxt.MaxLength = 32767;
            usernameTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            usernameTxt.Name = "usernameTxt";
            usernameTxt.PasswordChar = '\0';
            usernameTxt.PrefixSuffixText = null;
            usernameTxt.ReadOnly = false;
            usernameTxt.RightToLeft = RightToLeft.No;
            usernameTxt.SelectedText = "";
            usernameTxt.SelectionLength = 0;
            usernameTxt.SelectionStart = 0;
            usernameTxt.ShortcutsEnabled = true;
            usernameTxt.Size = new Size(357, 48);
            usernameTxt.TabIndex = 23;
            usernameTxt.TabStop = false;
            usernameTxt.TextAlign = HorizontalAlignment.Left;
            usernameTxt.TrailingIcon = null;
            usernameTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel16
            // 
            materialLabel16.Depth = 0;
            materialLabel16.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel16.Location = new Point(23, 223);
            materialLabel16.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel16.Name = "materialLabel16";
            materialLabel16.Size = new Size(152, 48);
            materialLabel16.TabIndex = 22;
            materialLabel16.Text = "Username";
            materialLabel16.TextAlign = ContentAlignment.MiddleLeft;
            //
            // progressBar
            // 
            progressBar.Depth = 0;
            progressBar.Location = new Point(532, 541);
            progressBar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(322, 36);
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 23;
            progressBar.UseAccentColor = false;
            progressBar.Value = 80;
            progressBar.Visible = false;
            // 
            // InstallForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1189, 787);
            Controls.Add(progressBar);
            Controls.Add(materialCard3);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Controls.Add(installBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InstallForm";
            Padding = new Padding(3, 85, 3, 4);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Install ClinicDesk";
            Load += InstallForm_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            ResumeLayout(false);
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
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel10;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel11;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel13;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit backupTxt;
        private ReaLTaiizor.Controls.MaterialSlider daysSld;
        private ReaLTaiizor.Controls.MaterialSwitch isDentalSwt;
        private ReaLTaiizor.Controls.MaterialCard materialCard3;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel12;
        private ReaLTaiizor.Controls.MaterialButton browseBtn;
        private FolderBrowserDialog folderBrowser;
        private ReaLTaiizor.Controls.MaterialSwitch apiSwt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit apiUrltxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel14;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit passwordTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel15;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit usernameTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel16;
        private ReaLTaiizor.Controls.MaterialProgressBar progressBar;
    }
}