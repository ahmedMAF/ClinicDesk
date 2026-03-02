namespace ClinicDesk.Forms
{
    partial class StatsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatsForm));
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            numOfPatientsTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            numOfAppsTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            appointmentList = new ReaLTaiizor.Controls.MaterialListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            methodList = new ReaLTaiizor.Controls.MaterialListView();
            columnHeader1 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            numOfBillsTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel9 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel10 = new ReaLTaiizor.Controls.MaterialLabel();
            totalTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel12 = new ReaLTaiizor.Controls.MaterialLabel();
            paidTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            remainTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel14 = new ReaLTaiizor.Controls.MaterialLabel();
            dateFromPkr = new DateTimePicker();
            materialCard3 = new ReaLTaiizor.Controls.MaterialCard();
            allTimeChk = new ReaLTaiizor.Controls.MaterialCheckBox();
            showBtn = new ReaLTaiizor.Controls.MaterialButton();
            dateToPkr = new DateTimePicker();
            materialLabel17 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel18 = new ReaLTaiizor.Controls.MaterialLabel();
            materialCheckBox1 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox2 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox3 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox4 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox5 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox6 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox7 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard3.SuspendLayout();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(27, 17);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(138, 48);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Number of Patients";
            materialLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numOfPatientsTxt
            // 
            numOfPatientsTxt.AnimateReadOnly = false;
            numOfPatientsTxt.AutoCompleteMode = AutoCompleteMode.None;
            numOfPatientsTxt.AutoCompleteSource = AutoCompleteSource.None;
            numOfPatientsTxt.BackgroundImageLayout = ImageLayout.None;
            numOfPatientsTxt.CharacterCasing = CharacterCasing.Normal;
            numOfPatientsTxt.Depth = 0;
            numOfPatientsTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            numOfPatientsTxt.HideSelection = true;
            numOfPatientsTxt.LeadingIcon = null;
            numOfPatientsTxt.Location = new Point(212, 17);
            numOfPatientsTxt.MaxLength = 32767;
            numOfPatientsTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            numOfPatientsTxt.Name = "numOfPatientsTxt";
            numOfPatientsTxt.PasswordChar = '\0';
            numOfPatientsTxt.PrefixSuffixText = null;
            numOfPatientsTxt.ReadOnly = true;
            numOfPatientsTxt.RightToLeft = RightToLeft.No;
            numOfPatientsTxt.SelectedText = "";
            numOfPatientsTxt.SelectionLength = 0;
            numOfPatientsTxt.SelectionStart = 0;
            numOfPatientsTxt.ShortcutsEnabled = true;
            numOfPatientsTxt.Size = new Size(166, 48);
            numOfPatientsTxt.TabIndex = 1;
            numOfPatientsTxt.TabStop = false;
            numOfPatientsTxt.TextAlign = HorizontalAlignment.Left;
            numOfPatientsTxt.TrailingIcon = null;
            numOfPatientsTxt.UseSystemPasswordChar = false;
            // 
            // numOfAppsTxt
            // 
            numOfAppsTxt.AnimateReadOnly = false;
            numOfAppsTxt.AutoCompleteMode = AutoCompleteMode.None;
            numOfAppsTxt.AutoCompleteSource = AutoCompleteSource.None;
            numOfAppsTxt.BackgroundImageLayout = ImageLayout.None;
            numOfAppsTxt.CharacterCasing = CharacterCasing.Normal;
            numOfAppsTxt.Depth = 0;
            numOfAppsTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            numOfAppsTxt.HideSelection = true;
            numOfAppsTxt.LeadingIcon = null;
            numOfAppsTxt.Location = new Point(212, 71);
            numOfAppsTxt.MaxLength = 32767;
            numOfAppsTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            numOfAppsTxt.Name = "numOfAppsTxt";
            numOfAppsTxt.PasswordChar = '\0';
            numOfAppsTxt.PrefixSuffixText = null;
            numOfAppsTxt.ReadOnly = true;
            numOfAppsTxt.RightToLeft = RightToLeft.No;
            numOfAppsTxt.SelectedText = "";
            numOfAppsTxt.SelectionLength = 0;
            numOfAppsTxt.SelectionStart = 0;
            numOfAppsTxt.ShortcutsEnabled = true;
            numOfAppsTxt.Size = new Size(166, 48);
            numOfAppsTxt.TabIndex = 4;
            numOfAppsTxt.TabStop = false;
            numOfAppsTxt.TextAlign = HorizontalAlignment.Left;
            numOfAppsTxt.TrailingIcon = null;
            numOfAppsTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(27, 71);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(179, 48);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Number of Appointments";
            materialLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(appointmentList);
            materialCard1.Controls.Add(numOfPatientsTxt);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Controls.Add(numOfAppsTxt);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 246);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(407, 417);
            materialCard1.TabIndex = 14;
            // 
            // appointmentList
            // 
            appointmentList.AutoSizeTable = false;
            appointmentList.BackColor = Color.FromArgb(255, 255, 255);
            appointmentList.BorderStyle = BorderStyle.None;
            appointmentList.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            appointmentList.Depth = 0;
            appointmentList.FullRowSelect = true;
            appointmentList.Location = new Point(27, 138);
            appointmentList.MinimumSize = new Size(200, 100);
            appointmentList.MouseLocation = new Point(-1, -1);
            appointmentList.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            appointmentList.Name = "appointmentList";
            appointmentList.OwnerDraw = true;
            appointmentList.Size = new Size(351, 262);
            appointmentList.TabIndex = 11;
            appointmentList.UseCompatibleStateImageBehavior = false;
            appointmentList.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Status";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Count";
            columnHeader4.Width = 230;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(methodList);
            materialCard2.Controls.Add(numOfBillsTxt);
            materialCard2.Controls.Add(materialLabel9);
            materialCard2.Controls.Add(materialLabel10);
            materialCard2.Controls.Add(totalTxt);
            materialCard2.Controls.Add(materialLabel12);
            materialCard2.Controls.Add(paidTxt);
            materialCard2.Controls.Add(remainTxt);
            materialCard2.Controls.Add(materialLabel14);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(452, 246);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(400, 417);
            materialCard2.TabIndex = 15;
            // 
            // methodList
            // 
            methodList.AutoSizeTable = false;
            methodList.BackColor = Color.FromArgb(255, 255, 255);
            methodList.BorderStyle = BorderStyle.None;
            methodList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader5, columnHeader2 });
            methodList.Depth = 0;
            methodList.FullRowSelect = true;
            methodList.Location = new Point(27, 243);
            methodList.MinimumSize = new Size(200, 100);
            methodList.MouseLocation = new Point(-1, -1);
            methodList.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            methodList.Name = "methodList";
            methodList.OwnerDraw = true;
            methodList.Size = new Size(351, 157);
            methodList.TabIndex = 10;
            methodList.UseCompatibleStateImageBehavior = false;
            methodList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Method";
            columnHeader1.Width = 110;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Count";
            columnHeader5.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Amount";
            columnHeader2.Width = 140;
            // 
            // numOfBillsTxt
            // 
            numOfBillsTxt.AnimateReadOnly = false;
            numOfBillsTxt.AutoCompleteMode = AutoCompleteMode.None;
            numOfBillsTxt.AutoCompleteSource = AutoCompleteSource.None;
            numOfBillsTxt.BackgroundImageLayout = ImageLayout.None;
            numOfBillsTxt.CharacterCasing = CharacterCasing.Normal;
            numOfBillsTxt.Depth = 0;
            numOfBillsTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            numOfBillsTxt.HideSelection = true;
            numOfBillsTxt.LeadingIcon = null;
            numOfBillsTxt.Location = new Point(212, 17);
            numOfBillsTxt.MaxLength = 32767;
            numOfBillsTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            numOfBillsTxt.Name = "numOfBillsTxt";
            numOfBillsTxt.PasswordChar = '\0';
            numOfBillsTxt.PrefixSuffixText = null;
            numOfBillsTxt.ReadOnly = true;
            numOfBillsTxt.RightToLeft = RightToLeft.No;
            numOfBillsTxt.SelectedText = "";
            numOfBillsTxt.SelectionLength = 0;
            numOfBillsTxt.SelectionStart = 0;
            numOfBillsTxt.ShortcutsEnabled = true;
            numOfBillsTxt.Size = new Size(166, 48);
            numOfBillsTxt.TabIndex = 1;
            numOfBillsTxt.TabStop = false;
            numOfBillsTxt.TextAlign = HorizontalAlignment.Left;
            numOfBillsTxt.TrailingIcon = null;
            numOfBillsTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(27, 17);
            materialLabel9.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(179, 48);
            materialLabel9.TabIndex = 0;
            materialLabel9.Text = "Number of Bills";
            materialLabel9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel10
            // 
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(27, 71);
            materialLabel10.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(179, 48);
            materialLabel10.TabIndex = 3;
            materialLabel10.Text = "Total Amount";
            materialLabel10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // totalTxt
            // 
            totalTxt.AnimateReadOnly = false;
            totalTxt.AutoCompleteMode = AutoCompleteMode.None;
            totalTxt.AutoCompleteSource = AutoCompleteSource.None;
            totalTxt.BackgroundImageLayout = ImageLayout.None;
            totalTxt.CharacterCasing = CharacterCasing.Normal;
            totalTxt.Depth = 0;
            totalTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            totalTxt.HideSelection = true;
            totalTxt.LeadingIcon = null;
            totalTxt.Location = new Point(212, 71);
            totalTxt.MaxLength = 32767;
            totalTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            totalTxt.Name = "totalTxt";
            totalTxt.PasswordChar = '\0';
            totalTxt.PrefixSuffixText = null;
            totalTxt.ReadOnly = true;
            totalTxt.RightToLeft = RightToLeft.No;
            totalTxt.SelectedText = "";
            totalTxt.SelectionLength = 0;
            totalTxt.SelectionStart = 0;
            totalTxt.ShortcutsEnabled = true;
            totalTxt.Size = new Size(166, 48);
            totalTxt.TabIndex = 4;
            totalTxt.TabStop = false;
            totalTxt.TextAlign = HorizontalAlignment.Left;
            totalTxt.TrailingIcon = null;
            totalTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel12
            // 
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel12.Location = new Point(136, 125);
            materialLabel12.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(100, 48);
            materialLabel12.TabIndex = 5;
            materialLabel12.Text = "Paid";
            materialLabel12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // paidTxt
            // 
            paidTxt.AnimateReadOnly = false;
            paidTxt.AutoCompleteMode = AutoCompleteMode.None;
            paidTxt.AutoCompleteSource = AutoCompleteSource.None;
            paidTxt.BackgroundImageLayout = ImageLayout.None;
            paidTxt.CharacterCasing = CharacterCasing.Normal;
            paidTxt.Depth = 0;
            paidTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            paidTxt.HideSelection = true;
            paidTxt.LeadingIcon = null;
            paidTxt.Location = new Point(242, 125);
            paidTxt.MaxLength = 32767;
            paidTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            paidTxt.Name = "paidTxt";
            paidTxt.PasswordChar = '\0';
            paidTxt.PrefixSuffixText = null;
            paidTxt.ReadOnly = true;
            paidTxt.RightToLeft = RightToLeft.No;
            paidTxt.SelectedText = "";
            paidTxt.SelectionLength = 0;
            paidTxt.SelectionStart = 0;
            paidTxt.ShortcutsEnabled = true;
            paidTxt.Size = new Size(136, 48);
            paidTxt.TabIndex = 6;
            paidTxt.TabStop = false;
            paidTxt.TextAlign = HorizontalAlignment.Left;
            paidTxt.TrailingIcon = null;
            paidTxt.UseSystemPasswordChar = false;
            // 
            // remainTxt
            // 
            remainTxt.AnimateReadOnly = false;
            remainTxt.AutoCompleteMode = AutoCompleteMode.None;
            remainTxt.AutoCompleteSource = AutoCompleteSource.None;
            remainTxt.BackgroundImageLayout = ImageLayout.None;
            remainTxt.CharacterCasing = CharacterCasing.Normal;
            remainTxt.Depth = 0;
            remainTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            remainTxt.HideSelection = true;
            remainTxt.LeadingIcon = null;
            remainTxt.Location = new Point(242, 179);
            remainTxt.MaxLength = 32767;
            remainTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            remainTxt.Name = "remainTxt";
            remainTxt.PasswordChar = '\0';
            remainTxt.PrefixSuffixText = null;
            remainTxt.ReadOnly = true;
            remainTxt.RightToLeft = RightToLeft.No;
            remainTxt.SelectedText = "";
            remainTxt.SelectionLength = 0;
            remainTxt.SelectionStart = 0;
            remainTxt.ShortcutsEnabled = true;
            remainTxt.Size = new Size(136, 48);
            remainTxt.TabIndex = 8;
            remainTxt.TabStop = false;
            remainTxt.TextAlign = HorizontalAlignment.Left;
            remainTxt.TrailingIcon = null;
            remainTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel14
            // 
            materialLabel14.Depth = 0;
            materialLabel14.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel14.Location = new Point(136, 179);
            materialLabel14.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel14.Name = "materialLabel14";
            materialLabel14.Size = new Size(100, 48);
            materialLabel14.TabIndex = 7;
            materialLabel14.Text = "Remaining";
            materialLabel14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateFromPkr
            // 
            dateFromPkr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateFromPkr.CustomFormat = "  dd/MM/yyyy";
            dateFromPkr.Enabled = false;
            dateFromPkr.Format = DateTimePickerFormat.Custom;
            dateFromPkr.Location = new Point(136, 25);
            dateFromPkr.Name = "dateFromPkr";
            dateFromPkr.Size = new Size(206, 27);
            dateFromPkr.TabIndex = 16;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(allTimeChk);
            materialCard3.Controls.Add(showBtn);
            materialCard3.Controls.Add(dateToPkr);
            materialCard3.Controls.Add(dateFromPkr);
            materialCard3.Controls.Add(materialLabel17);
            materialCard3.Controls.Add(materialLabel18);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(17, 78);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(835, 140);
            materialCard3.TabIndex = 16;
            // 
            // allTimeChk
            // 
            allTimeChk.AutoSize = true;
            allTimeChk.Checked = true;
            allTimeChk.CheckState = CheckState.Checked;
            allTimeChk.Depth = 0;
            allTimeChk.Location = new Point(493, 23);
            allTimeChk.Margin = new Padding(0);
            allTimeChk.MouseLocation = new Point(-1, -1);
            allTimeChk.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            allTimeChk.Name = "allTimeChk";
            allTimeChk.ReadOnly = false;
            allTimeChk.Ripple = true;
            allTimeChk.Size = new Size(93, 37);
            allTimeChk.TabIndex = 37;
            allTimeChk.Text = "All Time";
            allTimeChk.UseAccentColor = false;
            allTimeChk.UseVisualStyleBackColor = true;
            allTimeChk.CheckedChanged += allTimeChk_CheckedChanged;
            // 
            // showBtn
            // 
            showBtn.AutoSize = false;
            showBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            showBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            showBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            showBtn.Depth = 0;
            showBtn.HighEmphasis = true;
            showBtn.Icon = null;
            showBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            showBtn.Location = new Point(493, 76);
            showBtn.Margin = new Padding(4, 6, 4, 6);
            showBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            showBtn.Name = "showBtn";
            showBtn.NoAccentTextColor = Color.Empty;
            showBtn.Size = new Size(158, 36);
            showBtn.TabIndex = 36;
            showBtn.Text = "Show";
            showBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            showBtn.UseAccentColor = false;
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
            // 
            // dateToPkr
            // 
            dateToPkr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateToPkr.CustomFormat = "  dd/MM/yyyy";
            dateToPkr.Enabled = false;
            dateToPkr.Format = DateTimePickerFormat.Custom;
            dateToPkr.Location = new Point(136, 79);
            dateToPkr.Name = "dateToPkr";
            dateToPkr.Size = new Size(206, 27);
            dateToPkr.TabIndex = 17;
            // 
            // materialLabel17
            // 
            materialLabel17.Depth = 0;
            materialLabel17.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel17.Location = new Point(27, 17);
            materialLabel17.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel17.Name = "materialLabel17";
            materialLabel17.Size = new Size(103, 48);
            materialLabel17.TabIndex = 0;
            materialLabel17.Text = "From Date";
            materialLabel17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel18
            // 
            materialLabel18.Depth = 0;
            materialLabel18.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel18.Location = new Point(27, 71);
            materialLabel18.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel18.Name = "materialLabel18";
            materialLabel18.Size = new Size(103, 48);
            materialLabel18.TabIndex = 3;
            materialLabel18.Text = "To Date";
            materialLabel18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialCheckBox1
            // 
            materialCheckBox1.AutoSize = true;
            materialCheckBox1.Depth = 0;
            materialCheckBox1.Location = new Point(0, 0);
            materialCheckBox1.Margin = new Padding(0);
            materialCheckBox1.MouseLocation = new Point(-1, -1);
            materialCheckBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox1.Name = "materialCheckBox1";
            materialCheckBox1.ReadOnly = false;
            materialCheckBox1.Ripple = true;
            materialCheckBox1.Size = new Size(10, 10);
            materialCheckBox1.TabIndex = 0;
            materialCheckBox1.Text = "materialCheckBox1";
            materialCheckBox1.UseAccentColor = false;
            materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox2
            // 
            materialCheckBox2.AutoSize = true;
            materialCheckBox2.Depth = 0;
            materialCheckBox2.Location = new Point(0, 0);
            materialCheckBox2.Margin = new Padding(0);
            materialCheckBox2.MouseLocation = new Point(-1, -1);
            materialCheckBox2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox2.Name = "materialCheckBox2";
            materialCheckBox2.ReadOnly = false;
            materialCheckBox2.Ripple = true;
            materialCheckBox2.Size = new Size(10, 10);
            materialCheckBox2.TabIndex = 0;
            materialCheckBox2.Text = "materialCheckBox2";
            materialCheckBox2.UseAccentColor = false;
            materialCheckBox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox3
            // 
            materialCheckBox3.AutoSize = true;
            materialCheckBox3.Depth = 0;
            materialCheckBox3.Location = new Point(0, 0);
            materialCheckBox3.Margin = new Padding(0);
            materialCheckBox3.MouseLocation = new Point(-1, -1);
            materialCheckBox3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox3.Name = "materialCheckBox3";
            materialCheckBox3.ReadOnly = false;
            materialCheckBox3.Ripple = true;
            materialCheckBox3.Size = new Size(10, 10);
            materialCheckBox3.TabIndex = 0;
            materialCheckBox3.Text = "materialCheckBox3";
            materialCheckBox3.UseAccentColor = false;
            materialCheckBox3.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox4
            // 
            materialCheckBox4.AutoSize = true;
            materialCheckBox4.Depth = 0;
            materialCheckBox4.Location = new Point(0, 0);
            materialCheckBox4.Margin = new Padding(0);
            materialCheckBox4.MouseLocation = new Point(-1, -1);
            materialCheckBox4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox4.Name = "materialCheckBox4";
            materialCheckBox4.ReadOnly = false;
            materialCheckBox4.Ripple = true;
            materialCheckBox4.Size = new Size(10, 10);
            materialCheckBox4.TabIndex = 0;
            materialCheckBox4.Text = "materialCheckBox4";
            materialCheckBox4.UseAccentColor = false;
            materialCheckBox4.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox5
            // 
            materialCheckBox5.AutoSize = true;
            materialCheckBox5.Depth = 0;
            materialCheckBox5.Location = new Point(0, 0);
            materialCheckBox5.Margin = new Padding(0);
            materialCheckBox5.MouseLocation = new Point(-1, -1);
            materialCheckBox5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox5.Name = "materialCheckBox5";
            materialCheckBox5.ReadOnly = false;
            materialCheckBox5.Ripple = true;
            materialCheckBox5.Size = new Size(10, 10);
            materialCheckBox5.TabIndex = 0;
            materialCheckBox5.Text = "materialCheckBox5";
            materialCheckBox5.UseAccentColor = false;
            materialCheckBox5.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox6
            // 
            materialCheckBox6.AutoSize = true;
            materialCheckBox6.Depth = 0;
            materialCheckBox6.Location = new Point(0, 0);
            materialCheckBox6.Margin = new Padding(0);
            materialCheckBox6.MouseLocation = new Point(-1, -1);
            materialCheckBox6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox6.Name = "materialCheckBox6";
            materialCheckBox6.ReadOnly = false;
            materialCheckBox6.Ripple = true;
            materialCheckBox6.Size = new Size(10, 10);
            materialCheckBox6.TabIndex = 0;
            materialCheckBox6.Text = "materialCheckBox6";
            materialCheckBox6.UseAccentColor = false;
            materialCheckBox6.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox7
            // 
            materialCheckBox7.AutoSize = true;
            materialCheckBox7.Depth = 0;
            materialCheckBox7.Location = new Point(0, 0);
            materialCheckBox7.Margin = new Padding(0);
            materialCheckBox7.MouseLocation = new Point(-1, -1);
            materialCheckBox7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox7.Name = "materialCheckBox7";
            materialCheckBox7.ReadOnly = false;
            materialCheckBox7.Ripple = true;
            materialCheckBox7.Size = new Size(10, 10);
            materialCheckBox7.TabIndex = 0;
            materialCheckBox7.Text = "materialCheckBox7";
            materialCheckBox7.UseAccentColor = false;
            materialCheckBox7.UseVisualStyleBackColor = true;
            // 
            // StatsForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(875, 688);
            Controls.Add(materialCard3);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StatsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stats";
            Load += StatsForm_Load;
            materialCard1.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit numOfPatientsTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit numOfAppsTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit numOfBillsTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel9;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel10;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit totalTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel12;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit paidTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit remainTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel14;
        private DateTimePicker dateFromPkr;
        private ReaLTaiizor.Controls.MaterialCard materialCard3;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel17;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel18;
        private DateTimePicker dateToPkr;
        private ReaLTaiizor.Controls.MaterialButton showBtn;
        private ReaLTaiizor.Controls.MaterialCheckBox allTimeChk;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox1;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox2;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox3;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox4;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox5;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox6;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox7;
        private ReaLTaiizor.Controls.MaterialListView methodList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ReaLTaiizor.Controls.MaterialListView appointmentList;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}