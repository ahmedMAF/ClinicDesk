namespace QliniqRec.Forms
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
            label1 = new Label();
            appointmentsGrd = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)appointmentsGrd).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(700, 61);
            label1.TabIndex = 3;
            label1.Text = "Today's Patients";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // appointmentsGrd
            // 
            appointmentsGrd.AllowUserToAddRows = false;
            appointmentsGrd.AllowUserToDeleteRows = false;
            appointmentsGrd.AllowUserToOrderColumns = true;
            appointmentsGrd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            appointmentsGrd.BackgroundColor = Color.White;
            appointmentsGrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentsGrd.Location = new Point(12, 86);
            appointmentsGrd.Name = "appointmentsGrd";
            appointmentsGrd.ReadOnly = true;
            appointmentsGrd.RowHeadersWidth = 51;
            appointmentsGrd.Size = new Size(702, 446);
            appointmentsGrd.TabIndex = 5;
            appointmentsGrd.CellMouseClick += appointmentsGrd_CellMouseClick;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 544);
            Controls.Add(appointmentsGrd);
            Controls.Add(label1);
            Name = "DoctorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctor Form";
            WindowState = FormWindowState.Maximized;
            Load += DoctorForm_Load;
            ((System.ComponentModel.ISupportInitialize)appointmentsGrd).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private DataGridView appointmentsGrd;
    }
}