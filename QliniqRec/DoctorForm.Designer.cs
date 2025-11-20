namespace QliniqRec
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "", "1" }, -1);
            patientsLst = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label1 = new Label();
            SuspendLayout();
            // 
            // patientsLst
            // 
            patientsLst.Activation = ItemActivation.TwoClick;
            patientsLst.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            patientsLst.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            patientsLst.FullRowSelect = true;
            patientsLst.Items.AddRange(new ListViewItem[] { listViewItem1 });
            patientsLst.Location = new Point(12, 87);
            patientsLst.MultiSelect = false;
            patientsLst.Name = "patientsLst";
            patientsLst.Size = new Size(700, 445);
            patientsLst.TabIndex = 2;
            patientsLst.UseCompatibleStateImageBehavior = false;
            patientsLst.View = View.Details;
            patientsLst.MouseClick += patientsLst_MouseClick;
            patientsLst.MouseDoubleClick += patientsLst_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 480;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Time";
            columnHeader3.Width = 120;
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
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 544);
            Controls.Add(label1);
            Controls.Add(patientsLst);
            Name = "DoctorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctor Form";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private ListView patientsLst;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label1;
    }
}