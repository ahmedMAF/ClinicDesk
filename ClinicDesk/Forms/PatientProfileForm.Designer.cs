namespace ClinicDesk.Forms
{
    partial class PatientProfileForm
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
            groupBox4 = new GroupBox();
            notesTxt = new TextBox();
            bloodTypeCbo = new ComboBox();
            groupBox3 = new GroupBox();
            chronicDiseasesLst = new ListBox();
            label7 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            ageTxt = new TextBox();
            label4 = new Label();
            dobTxt = new TextBox();
            maritalCbo = new ComboBox();
            label5 = new Label();
            sexCbo = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            nameTxt = new TextBox();
            label1 = new Label();
            groupBox6 = new GroupBox();
            editBtn = new Button();
            cancelBtn = new Button();
            visitsGrd = new DataGridView();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visitsGrd).BeginInit();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(notesTxt);
            groupBox4.Location = new Point(12, 188);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1068, 125);
            groupBox4.TabIndex = 25;
            groupBox4.TabStop = false;
            groupBox4.Text = "Notes";
            // 
            // notesTxt
            // 
            notesTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            notesTxt.Location = new Point(6, 26);
            notesTxt.Multiline = true;
            notesTxt.Name = "notesTxt";
            notesTxt.Size = new Size(1056, 93);
            notesTxt.TabIndex = 18;
            // 
            // bloodTypeCbo
            // 
            bloodTypeCbo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bloodTypeCbo.DropDownStyle = ComboBoxStyle.DropDownList;
            bloodTypeCbo.Enabled = false;
            bloodTypeCbo.FormattingEnabled = true;
            bloodTypeCbo.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            bloodTypeCbo.Location = new Point(132, 26);
            bloodTypeCbo.Name = "bloodTypeCbo";
            bloodTypeCbo.Size = new Size(390, 28);
            bloodTypeCbo.TabIndex = 14;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(chronicDiseasesLst);
            groupBox3.Controls.Add(bloodTypeCbo);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(552, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(528, 170);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Medical Info";
            // 
            // chronicDiseasesLst
            // 
            chronicDiseasesLst.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chronicDiseasesLst.FormattingEnabled = true;
            chronicDiseasesLst.IntegralHeight = false;
            chronicDiseasesLst.Items.AddRange(new object[] { "Diabetes", "Hypertension", "Liver" });
            chronicDiseasesLst.Location = new Point(132, 60);
            chronicDiseasesLst.Name = "chronicDiseasesLst";
            chronicDiseasesLst.Size = new Size(390, 93);
            chronicDiseasesLst.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 62);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 8;
            label7.Text = "Chronic Diseases";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 29);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 6;
            label6.Text = "Blood Type";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(ageTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dobTxt);
            groupBox1.Controls.Add(maritalCbo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(sexCbo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nameTxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(534, 170);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Info";
            // 
            // ageTxt
            // 
            ageTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ageTxt.Location = new Point(411, 93);
            ageTxt.Name = "ageTxt";
            ageTxt.ReadOnly = true;
            ageTxt.Size = new Size(117, 27);
            ageTxt.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(369, 96);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 15;
            label4.Text = "Age";
            // 
            // dobTxt
            // 
            dobTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dobTxt.Location = new Point(132, 93);
            dobTxt.Name = "dobTxt";
            dobTxt.ReadOnly = true;
            dobTxt.Size = new Size(231, 27);
            dobTxt.TabIndex = 14;
            // 
            // maritalCbo
            // 
            maritalCbo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maritalCbo.DropDownStyle = ComboBoxStyle.DropDownList;
            maritalCbo.Enabled = false;
            maritalCbo.FormattingEnabled = true;
            maritalCbo.Items.AddRange(new object[] { "Single", "Maried", "Divorced", "Widowed" });
            maritalCbo.Location = new Point(132, 126);
            maritalCbo.Name = "maritalCbo";
            maritalCbo.Size = new Size(396, 28);
            maritalCbo.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 128);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 12;
            label5.Text = "Marital Status";
            // 
            // sexCbo
            // 
            sexCbo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sexCbo.DropDownStyle = ComboBoxStyle.DropDownList;
            sexCbo.Enabled = false;
            sexCbo.FormattingEnabled = true;
            sexCbo.Items.AddRange(new object[] { "Male", "Female" });
            sexCbo.Location = new Point(132, 59);
            sexCbo.Name = "sexCbo";
            sexCbo.Size = new Size(396, 28);
            sexCbo.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 62);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 10;
            label3.Text = "Sex";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 96);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 8;
            label2.Text = "Date of Birth";
            // 
            // nameTxt
            // 
            nameTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTxt.Location = new Point(132, 26);
            nameTxt.Name = "nameTxt";
            nameTxt.ReadOnly = true;
            nameTxt.Size = new Size(396, 27);
            nameTxt.TabIndex = 1;
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
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox6.Controls.Add(visitsGrd);
            groupBox6.Location = new Point(12, 319);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1068, 315);
            groupBox6.TabIndex = 22;
            groupBox6.TabStop = false;
            groupBox6.Text = "Past Visits";
            // 
            // editBtn
            // 
            editBtn.Location = new Point(986, 640);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(94, 29);
            editBtn.TabIndex = 27;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(886, 640);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 28;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // visitsGrd
            // 
            visitsGrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visitsGrd.Location = new Point(6, 26);
            visitsGrd.Name = "visitsGrd";
            visitsGrd.RowHeadersWidth = 51;
            visitsGrd.Size = new Size(1056, 283);
            visitsGrd.TabIndex = 29;
            // 
            // PatientProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 682);
            Controls.Add(cancelBtn);
            Controls.Add(editBtn);
            Controls.Add(groupBox6);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "PatientProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient Profile";
            WindowState = FormWindowState.Maximized;
            Load += PatientProfileForm_Load;
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)visitsGrd).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox4;
        private TextBox notesTxt;
        private ComboBox bloodTypeCbo;
        private GroupBox groupBox3;
        private Label label7;
        private Label label6;
        private GroupBox groupBox1;
        private ComboBox maritalCbo;
        private Label label5;
        private ComboBox sexCbo;
        private Label label3;
        private Label label2;
        private TextBox nameTxt;
        private Label label1;
        private GroupBox groupBox6;
        private ListBox chronicDiseasesLst;
        private Button editBtn;
        private Button cancelBtn;
        private TextBox dobTxt;
        private TextBox ageTxt;
        private Label label4;
        private DataGridView visitsGrd;
    }
}