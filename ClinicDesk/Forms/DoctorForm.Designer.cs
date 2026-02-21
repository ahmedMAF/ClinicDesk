namespace ClinicDesk.Forms
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            appointmentsGrd = new DataGridView();
            settingsBtn = new ReaLTaiizor.Controls.MaterialButton();
            searchBtn = new ReaLTaiizor.Controls.MaterialButton();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            monthCalendar1 = new MonthCalendar();
            aboutBtn = new ReaLTaiizor.Controls.MaterialButton();
            statsBtn = new ReaLTaiizor.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)appointmentsGrd).BeginInit();
            SuspendLayout();
            // 
            // appointmentsGrd
            // 
            appointmentsGrd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            appointmentsGrd.ColumnHeadersHeight = 29;
            appointmentsGrd.Location = new Point(12, 292);
            appointmentsGrd.Name = "appointmentsGrd";
            appointmentsGrd.RowHeadersWidth = 51;
            appointmentsGrd.Size = new Size(912, 397);
            appointmentsGrd.TabIndex = 5;
            // 
            // settingsBtn
            // 
            settingsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            settingsBtn.AutoSize = false;
            settingsBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            settingsBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            settingsBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            settingsBtn.Depth = 0;
            settingsBtn.HighEmphasis = true;
            settingsBtn.Icon = null;
            settingsBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            settingsBtn.Location = new Point(726, 73);
            settingsBtn.Margin = new Padding(4, 6, 4, 6);
            settingsBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            settingsBtn.Name = "settingsBtn";
            settingsBtn.NoAccentTextColor = Color.Empty;
            settingsBtn.Size = new Size(198, 45);
            settingsBtn.TabIndex = 10;
            settingsBtn.Text = "Settings";
            settingsBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            settingsBtn.UseAccentColor = false;
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchBtn.AutoSize = false;
            searchBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            searchBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            searchBtn.Depth = 0;
            searchBtn.HighEmphasis = true;
            searchBtn.Icon = null;
            searchBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            searchBtn.Location = new Point(520, 73);
            searchBtn.Margin = new Padding(4, 6, 4, 6);
            searchBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            searchBtn.Name = "searchBtn";
            searchBtn.NoAccentTextColor = Color.Empty;
            searchBtn.Size = new Size(198, 45);
            searchBtn.TabIndex = 11;
            searchBtn.Text = "Search for Patient";
            searchBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            searchBtn.UseAccentColor = false;
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(17, 88);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(185, 19);
            materialLabel1.TabIndex = 13;
            materialLabel1.Text = "Show Appointments From";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(214, 73);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 12;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // aboutBtn
            // 
            aboutBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            aboutBtn.AutoSize = false;
            aboutBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            aboutBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            aboutBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            aboutBtn.Depth = 0;
            aboutBtn.HighEmphasis = true;
            aboutBtn.Icon = null;
            aboutBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            aboutBtn.Location = new Point(726, 130);
            aboutBtn.Margin = new Padding(4, 6, 4, 6);
            aboutBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            aboutBtn.Name = "aboutBtn";
            aboutBtn.NoAccentTextColor = Color.Empty;
            aboutBtn.Size = new Size(198, 45);
            aboutBtn.TabIndex = 15;
            aboutBtn.Text = "About";
            aboutBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            aboutBtn.UseAccentColor = false;
            aboutBtn.UseVisualStyleBackColor = true;
            aboutBtn.Click += aboutBtn_Click;
            // 
            // statsBtn
            // 
            statsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            statsBtn.AutoSize = false;
            statsBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            statsBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            statsBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            statsBtn.Depth = 0;
            statsBtn.HighEmphasis = true;
            statsBtn.Icon = null;
            statsBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            statsBtn.Location = new Point(520, 130);
            statsBtn.Margin = new Padding(4, 6, 4, 6);
            statsBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            statsBtn.Name = "statsBtn";
            statsBtn.NoAccentTextColor = Color.Empty;
            statsBtn.Size = new Size(198, 45);
            statsBtn.TabIndex = 14;
            statsBtn.Text = "Statistics";
            statsBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            statsBtn.UseAccentColor = false;
            statsBtn.UseVisualStyleBackColor = true;
            statsBtn.Click += statsBtn_Click;
            // 
            // DoctorForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(934, 701);
            Controls.Add(aboutBtn);
            Controls.Add(statsBtn);
            Controls.Add(materialLabel1);
            Controls.Add(monthCalendar1);
            Controls.Add(searchBtn);
            Controls.Add(settingsBtn);
            Controls.Add(appointmentsGrd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DoctorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctor";
            WindowState = FormWindowState.Maximized;
            Load += DoctorForm_Load;
            ((System.ComponentModel.ISupportInitialize)appointmentsGrd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView appointmentsGrd;
        private ReaLTaiizor.Controls.MaterialButton settingsBtn;
        private ReaLTaiizor.Controls.MaterialButton searchBtn;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private MonthCalendar monthCalendar1;
        private ReaLTaiizor.Controls.MaterialButton aboutBtn;
        private ReaLTaiizor.Controls.MaterialButton statsBtn;
    }
}