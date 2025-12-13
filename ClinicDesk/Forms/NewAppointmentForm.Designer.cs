namespace QliniqRec.Forms
{
    partial class NewAppointmentForm
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
            label1 = new Label();
            nameTxt = new TextBox();
            groupBox1 = new GroupBox();
            phoneTxt = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            timePkr = new DateTimePicker();
            label5 = new Label();
            datePkr = new DateTimePicker();
            label8 = new Label();
            saveBtn = new Button();
            cancelBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
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
            // nameTxt
            // 
            nameTxt.Location = new Point(120, 26);
            nameTxt.Name = "nameTxt";
            nameTxt.ReadOnly = true;
            nameTxt.Size = new Size(342, 27);
            nameTxt.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(phoneTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nameTxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patient Data";
            // 
            // phoneTxt
            // 
            phoneTxt.Location = new Point(120, 59);
            phoneTxt.Name = "phoneTxt";
            phoneTxt.ReadOnly = true;
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
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(timePkr);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(datePkr);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(6, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(496, 102);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Appointment Data";
            // 
            // timePkr
            // 
            timePkr.CustomFormat = "  hh:mm tt";
            timePkr.Format = DateTimePickerFormat.Custom;
            timePkr.Location = new Point(53, 59);
            timePkr.Name = "timePkr";
            timePkr.Size = new Size(290, 27);
            timePkr.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 64);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 2;
            label5.Text = "Time";
            // 
            // datePkr
            // 
            datePkr.CustomFormat = "  dd/MM/yyyy";
            datePkr.Format = DateTimePickerFormat.Custom;
            datePkr.Location = new Point(53, 26);
            datePkr.Name = "datePkr";
            datePkr.Size = new Size(290, 27);
            datePkr.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 31);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 0;
            label8.Text = "Date";
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveBtn.Enabled = false;
            saveBtn.Location = new Point(414, 290);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.Location = new Point(314, 290);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 5;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // NewAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 332);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewAppointmentForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Appointment";
            Load += NewAppointmentForm_Load;
            KeyPress += NewAppointmentForm_KeyPress;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox nameTxt;
        private GroupBox groupBox1;
        private TextBox phoneTxt;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private GroupBox groupBox2;
        private Label label8;
        private DateTimePicker datePkr;
        private Button saveBtn;
        private Button cancelBtn;
        private DateTimePicker timePkr;
        private Label label5;
    }
}