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
            monthCalendar1 = new MonthCalendar();
            appointmentsGrd = new DataGridView();
            newAppointmentBtn = new ReaLTaiizor.Controls.MaterialButton();
            billingBtn = new ReaLTaiizor.Controls.MaterialButton();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
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
            appointmentsGrd.Location = new Point(12, 292);
            appointmentsGrd.Name = "appointmentsGrd";
            appointmentsGrd.ReadOnly = true;
            appointmentsGrd.RowHeadersWidth = 51;
            appointmentsGrd.Size = new Size(702, 404);
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
            newAppointmentBtn.Location = new Point(516, 73);
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
            billingBtn.Location = new Point(516, 130);
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
            // SecretaryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 708);
            Controls.Add(materialLabel1);
            Controls.Add(billingBtn);
            Controls.Add(newAppointmentBtn);
            Controls.Add(appointmentsGrd);
            Controls.Add(monthCalendar1);
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
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
    }
}