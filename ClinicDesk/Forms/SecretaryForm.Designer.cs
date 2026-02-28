namespace ClinicDesk.Forms
{
    partial class SecretaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecretaryForm));
            monthCalendar1 = new MonthCalendar();
            appointmentsGrd = new DataGridView();
            newAppointmentBtn = new ReaLTaiizor.Controls.MaterialButton();
            billingBtn = new ReaLTaiizor.Controls.MaterialButton();
            settingsBtn = new ReaLTaiizor.Controls.MaterialButton();
            statsBtn = new ReaLTaiizor.Controls.MaterialButton();
            aboutBtn = new ReaLTaiizor.Controls.MaterialButton();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            requestsBtn = new ReaLTaiizor.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)appointmentsGrd).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(209, 73);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 2;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // appointmentsGrd
            // 
            appointmentsGrd.AllowUserToAddRows = false;
            appointmentsGrd.AllowUserToDeleteRows = false;
            appointmentsGrd.AllowUserToOrderColumns = true;
            appointmentsGrd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            appointmentsGrd.BackgroundColor = Color.White;
            appointmentsGrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentsGrd.Location = new Point(12, 298);
            appointmentsGrd.Name = "appointmentsGrd";
            appointmentsGrd.ReadOnly = true;
            appointmentsGrd.RowHeadersWidth = 51;
            appointmentsGrd.Size = new Size(879, 398);
            appointmentsGrd.TabIndex = 4;
            // 
            // newAppointmentBtn
            // 
            newAppointmentBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            newAppointmentBtn.AutoSize = false;
            newAppointmentBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            newAppointmentBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            newAppointmentBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            newAppointmentBtn.Depth = 0;
            newAppointmentBtn.HighEmphasis = true;
            newAppointmentBtn.Icon = null;
            newAppointmentBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            newAppointmentBtn.Location = new Point(487, 73);
            newAppointmentBtn.Margin = new Padding(4, 6, 4, 6);
            newAppointmentBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            newAppointmentBtn.Name = "newAppointmentBtn";
            newAppointmentBtn.NoAccentTextColor = Color.Empty;
            newAppointmentBtn.Size = new Size(198, 45);
            newAppointmentBtn.TabIndex = 5;
            newAppointmentBtn.Text = "New Appointment";
            newAppointmentBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            newAppointmentBtn.UseAccentColor = false;
            newAppointmentBtn.UseVisualStyleBackColor = true;
            newAppointmentBtn.Click += newAppointmentBtn_Click;
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
            billingBtn.Location = new Point(487, 130);
            billingBtn.Margin = new Padding(4, 6, 4, 6);
            billingBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            billingBtn.Name = "billingBtn";
            billingBtn.NoAccentTextColor = Color.Empty;
            billingBtn.Size = new Size(198, 45);
            billingBtn.TabIndex = 6;
            billingBtn.Text = "Billing";
            billingBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            billingBtn.UseAccentColor = false;
            billingBtn.UseVisualStyleBackColor = true;
            billingBtn.Click += billingSearchBtn_Click;
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
            settingsBtn.Location = new Point(693, 73);
            settingsBtn.Margin = new Padding(4, 6, 4, 6);
            settingsBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            settingsBtn.Name = "settingsBtn";
            settingsBtn.NoAccentTextColor = Color.Empty;
            settingsBtn.Size = new Size(198, 45);
            settingsBtn.TabIndex = 8;
            settingsBtn.Text = "Settings";
            settingsBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            settingsBtn.UseAccentColor = false;
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += settingsBtn_Click;
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
            statsBtn.Location = new Point(487, 187);
            statsBtn.Margin = new Padding(4, 6, 4, 6);
            statsBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            statsBtn.Name = "statsBtn";
            statsBtn.NoAccentTextColor = Color.Empty;
            statsBtn.Size = new Size(198, 45);
            statsBtn.TabIndex = 9;
            statsBtn.Text = "Statistics";
            statsBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            statsBtn.UseAccentColor = false;
            statsBtn.UseVisualStyleBackColor = true;
            statsBtn.Click += statsBtn_Click;
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
            aboutBtn.Location = new Point(693, 130);
            aboutBtn.Margin = new Padding(4, 6, 4, 6);
            aboutBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            aboutBtn.Name = "aboutBtn";
            aboutBtn.NoAccentTextColor = Color.Empty;
            aboutBtn.Size = new Size(198, 45);
            aboutBtn.TabIndex = 10;
            aboutBtn.Text = "About";
            aboutBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            aboutBtn.UseAccentColor = false;
            aboutBtn.UseVisualStyleBackColor = true;
            aboutBtn.Click += aboutBtn_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(12, 88);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(185, 19);
            materialLabel1.TabIndex = 7;
            materialLabel1.Text = "Show Appointments From";
            // 
            // requestsBtn
            // 
            requestsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            requestsBtn.AutoSize = false;
            requestsBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            requestsBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            requestsBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            requestsBtn.Depth = 0;
            requestsBtn.HighEmphasis = true;
            requestsBtn.Icon = null;
            requestsBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            requestsBtn.Location = new Point(487, 244);
            requestsBtn.Margin = new Padding(4, 6, 4, 6);
            requestsBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            requestsBtn.Name = "requestsBtn";
            requestsBtn.NoAccentTextColor = Color.Empty;
            requestsBtn.Size = new Size(198, 45);
            requestsBtn.TabIndex = 14;
            requestsBtn.Text = "Appointment Requests";
            requestsBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            requestsBtn.UseAccentColor = false;
            requestsBtn.UseVisualStyleBackColor = true;
            requestsBtn.Click += requestsBtn_Click;
            // 
            // SecretaryForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(903, 708);
            Controls.Add(requestsBtn);
            Controls.Add(aboutBtn);
            Controls.Add(statsBtn);
            Controls.Add(settingsBtn);
            Controls.Add(materialLabel1);
            Controls.Add(billingBtn);
            Controls.Add(newAppointmentBtn);
            Controls.Add(appointmentsGrd);
            Controls.Add(monthCalendar1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SecretaryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Secretary";
            WindowState = FormWindowState.Maximized;
            Load += SecretaryForm_Load;
            ((System.ComponentModel.ISupportInitialize)appointmentsGrd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MonthCalendar monthCalendar1;
        private DataGridView appointmentsGrd;
        private ReaLTaiizor.Controls.MaterialButton newAppointmentBtn;
        private ReaLTaiizor.Controls.MaterialButton billingBtn;
        private ReaLTaiizor.Controls.MaterialButton settingsBtn;
        private ReaLTaiizor.Controls.MaterialButton statsBtn;
        private ReaLTaiizor.Controls.MaterialButton aboutBtn;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialButton requestsBtn;
    }
}