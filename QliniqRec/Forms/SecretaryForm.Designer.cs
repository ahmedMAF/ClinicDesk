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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            monthCalendar1 = new MonthCalendar();
            billingBtn = new Button();
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
            // listView1
            // 
            listView1.Activation = ItemActivation.OneClick;
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.FullRowSelect = true;
            listView1.HotTracking = true;
            listView1.HoverSelection = true;
            listView1.Location = new Point(18, 237);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(696, 280);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            billingBtn.Click += billingBtn_Click;
            // 
            // SecretaryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 529);
            Controls.Add(billingBtn);
            Controls.Add(monthCalendar1);
            Controls.Add(listView1);
            Controls.Add(newAppBtn);
            Name = "SecretaryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SecretaryForm";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button newAppBtn;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private MonthCalendar monthCalendar1;
        private Button billingBtn;
    }
}