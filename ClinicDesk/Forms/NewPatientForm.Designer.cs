namespace ClinicDesk.Forms
{
    partial class NewPatientForm
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
            groupBox1 = new GroupBox();
            maritalCbo = new ComboBox();
            label5 = new Label();
            sexCbo = new ComboBox();
            label3 = new Label();
            dobPkr = new DateTimePicker();
            label2 = new Label();
            nameTxt = new TextBox();
            label1 = new Label();
            phoneTxt = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            bloodTypeCbo = new ComboBox();
            disOtherTxt = new TextBox();
            disOtherChk = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            notesTxt = new TextBox();
            groupBox4 = new GroupBox();
            saveBtn = new Button();
            cancelBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(maritalCbo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(sexCbo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dobPkr);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nameTxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(677, 170);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patient Data";
            // 
            // maritalCbo
            // 
            maritalCbo.DropDownStyle = ComboBoxStyle.DropDownList;
            maritalCbo.FormattingEnabled = true;
            maritalCbo.Items.AddRange(new object[] { "Single", "Maried", "Divorced", "Widowed" });
            maritalCbo.Location = new Point(132, 125);
            maritalCbo.Name = "maritalCbo";
            maritalCbo.Size = new Size(330, 28);
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
            sexCbo.DropDownStyle = ComboBoxStyle.DropDownList;
            sexCbo.FormattingEnabled = true;
            sexCbo.Items.AddRange(new object[] { "Male", "Female" });
            sexCbo.Location = new Point(132, 59);
            sexCbo.Name = "sexCbo";
            sexCbo.Size = new Size(330, 28);
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
            // dobPkr
            // 
            dobPkr.Location = new Point(132, 92);
            dobPkr.Name = "dobPkr";
            dobPkr.Size = new Size(330, 27);
            dobPkr.TabIndex = 9;
            dobPkr.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 97);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 8;
            label2.Text = "Date of Birth";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(132, 26);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(330, 27);
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
            // phoneTxt
            // 
            phoneTxt.Location = new Point(132, 26);
            phoneTxt.Name = "phoneTxt";
            phoneTxt.Size = new Size(330, 27);
            phoneTxt.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 29);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 6;
            label4.Text = "Phone Number";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(phoneTxt);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 188);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(677, 76);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Contact Info";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(bloodTypeCbo);
            groupBox3.Controls.Add(disOtherTxt);
            groupBox3.Controls.Add(disOtherChk);
            groupBox3.Controls.Add(checkBox7);
            groupBox3.Controls.Add(checkBox6);
            groupBox3.Controls.Add(checkBox5);
            groupBox3.Controls.Add(checkBox4);
            groupBox3.Controls.Add(checkBox3);
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(12, 270);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(677, 248);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Medical Info";
            // 
            // bloodTypeCbo
            // 
            bloodTypeCbo.DropDownStyle = ComboBoxStyle.DropDownList;
            bloodTypeCbo.FormattingEnabled = true;
            bloodTypeCbo.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            bloodTypeCbo.Location = new Point(132, 26);
            bloodTypeCbo.Name = "bloodTypeCbo";
            bloodTypeCbo.Size = new Size(330, 28);
            bloodTypeCbo.TabIndex = 14;
            // 
            // disOtherTxt
            // 
            disOtherTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            disOtherTxt.Enabled = false;
            disOtherTxt.Location = new Point(355, 152);
            disOtherTxt.Multiline = true;
            disOtherTxt.Name = "disOtherTxt";
            disOtherTxt.Size = new Size(316, 81);
            disOtherTxt.TabIndex = 17;
            // 
            // disOtherChk
            // 
            disOtherChk.AutoSize = true;
            disOtherChk.Location = new Point(281, 152);
            disOtherChk.Name = "disOtherChk";
            disOtherChk.Size = new Size(68, 24);
            disOtherChk.TabIndex = 16;
            disOtherChk.Text = "Other";
            disOtherChk.UseVisualStyleBackColor = true;
            disOtherChk.CheckedChanged += disOtherChk_CheckedChanged;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(281, 122);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(117, 24);
            checkBox7.TabIndex = 15;
            checkBox7.Text = "Liver Disease";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += chronicDiseasesChk_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(281, 92);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(82, 24);
            checkBox6.TabIndex = 14;
            checkBox6.Text = "Anemia";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += chronicDiseasesChk_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(281, 62);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(81, 24);
            checkBox5.TabIndex = 13;
            checkBox5.Text = "Asthma";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += chronicDiseasesChk_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(132, 152);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(123, 24);
            checkBox4.TabIndex = 12;
            checkBox4.Text = "Heart Disease";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += chronicDiseasesChk_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(132, 122);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(119, 24);
            checkBox3.TabIndex = 11;
            checkBox3.Text = "Hypertension";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += chronicDiseasesChk_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(132, 92);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(115, 24);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Hypotension";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += chronicDiseasesChk_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(132, 62);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(90, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Diabetes";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += chronicDiseasesChk_CheckedChanged;
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
            // notesTxt
            // 
            notesTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            notesTxt.Location = new Point(6, 26);
            notesTxt.Multiline = true;
            notesTxt.Name = "notesTxt";
            notesTxt.Size = new Size(665, 93);
            notesTxt.TabIndex = 18;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(notesTxt);
            groupBox4.Location = new Point(12, 524);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(677, 125);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            groupBox4.Text = "Notes";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(595, 655);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 20;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(495, 655);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 21;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // NewPatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 700);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "NewPatientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Patient";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dobPkr;
        private Label label2;
        private TextBox phoneTxt;
        private Label label4;
        private TextBox nameTxt;
        private Label label1;
        private Label label3;
        private ComboBox maritalCbo;
        private Label label5;
        private ComboBox sexCbo;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label6;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label7;
        private TextBox disOtherTxt;
        private CheckBox disOtherChk;
        private CheckBox checkBox7;
        private TextBox notesTxt;
        private GroupBox groupBox4;
        private Button saveBtn;
        private Button cancelBtn;
        private ComboBox bloodTypeCbo;
    }
}