namespace QliniqRec.Forms
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
            newAppBtn = new Button();
            monthCalendar1 = new MonthCalendar();
            billingBtn = new Button();
            appointmentsGrd = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)appointmentsGrd).BeginInit();
            SuspendLayout();
            // 
            // newAppBtn
            // 
            newAppBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            newAppBtn.Location = new Point(546, 18);
            newAppBtn.Name = "newAppBtn";
            newAppBtn.Size = new Size(168, 44);
            newAppBtn.TabIndex = 0;
            newAppBtn.Text = "New Appointment";
            newAppBtn.UseVisualStyleBackColor = true;
            newAppBtn.Click += newAppBtn_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(111, 18);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 2;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // billingBtn
            // 
            billingBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            billingBtn.Location = new Point(546, 68);
            billingBtn.Name = "billingBtn";
            billingBtn.Size = new Size(168, 44);
            billingBtn.TabIndex = 3;
            billingBtn.Text = "Billing";
            billingBtn.UseVisualStyleBackColor = true;
            billingBtn.Click += billingSearchBtn_Click;
            // 
            // appointmentsGrd
            // 
            appointmentsGrd.AllowUserToAddRows = false;
            appointmentsGrd.AllowUserToDeleteRows = false;
            appointmentsGrd.AllowUserToOrderColumns = true;
            appointmentsGrd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            appointmentsGrd.BackgroundColor = Color.White;
            appointmentsGrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentsGrd.Location = new Point(12, 237);
            appointmentsGrd.Name = "appointmentsGrd";
            appointmentsGrd.ReadOnly = true;
            appointmentsGrd.RowHeadersWidth = 51;
            appointmentsGrd.Size = new Size(702, 280);
            appointmentsGrd.TabIndex = 4;
            appointmentsGrd.CellClick += appointmentsGrd_CellClick;
            // 
            // SecretaryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 529);
            Controls.Add(appointmentsGrd);
            Controls.Add(billingBtn);
            Controls.Add(monthCalendar1);
            Controls.Add(newAppBtn);
            Name = "SecretaryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SecretaryForm";
            WindowState = FormWindowState.Maximized;
            Load += SecretaryForm_Load;
            ((System.ComponentModel.ISupportInitialize)appointmentsGrd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button newAppBtn;
        private MonthCalendar monthCalendar1;
        private Button billingBtn;
        private DataGridView appointmentsGrd;
    }
}