namespace ClinicDesk.Forms
{
    partial class PatientDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientDataForm));
            dobPkr = new DateTimePicker();
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            phoneTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel8 = new ReaLTaiizor.Controls.MaterialLabel();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            maritalCbo = new ReaLTaiizor.Controls.MaterialComboBox();
            sexCbo = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            nameTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            materialCard3 = new ReaLTaiizor.Controls.MaterialCard();
            disOtherTxt = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            materialCard4 = new ReaLTaiizor.Controls.MaterialCard();
            chronicDiseasesGrp = new FlowLayoutPanel();
            materialCheckBox2 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox3 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox4 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox5 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox6 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox1 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox7 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialLabel7 = new ReaLTaiizor.Controls.MaterialLabel();
            bloodTypeCbo = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            notesTxt = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            saveBtn = new ReaLTaiizor.Controls.MaterialButton();
            materialCard2.SuspendLayout();
            materialCard1.SuspendLayout();
            materialCard3.SuspendLayout();
            materialCard4.SuspendLayout();
            chronicDiseasesGrp.SuspendLayout();
            SuspendLayout();
            // 
            // dobPkr
            // 
            dobPkr.Location = new Point(127, 133);
            dobPkr.Name = "dobPkr";
            dobPkr.Size = new Size(371, 27);
            dobPkr.TabIndex = 9;
            dobPkr.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(phoneTxt);
            materialCard2.Controls.Add(materialLabel8);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(18, 353);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(672, 79);
            materialCard2.TabIndex = 34;
            // 
            // phoneTxt
            // 
            phoneTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            phoneTxt.AnimateReadOnly = false;
            phoneTxt.AutoCompleteMode = AutoCompleteMode.None;
            phoneTxt.AutoCompleteSource = AutoCompleteSource.None;
            phoneTxt.BackgroundImageLayout = ImageLayout.None;
            phoneTxt.CharacterCasing = CharacterCasing.Normal;
            phoneTxt.Depth = 0;
            phoneTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            phoneTxt.HideSelection = true;
            phoneTxt.LeadingIcon = null;
            phoneTxt.Location = new Point(127, 17);
            phoneTxt.MaxLength = 32767;
            phoneTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            phoneTxt.Name = "phoneTxt";
            phoneTxt.PasswordChar = '\0';
            phoneTxt.PrefixSuffixText = null;
            phoneTxt.ReadOnly = false;
            phoneTxt.RightToLeft = RightToLeft.No;
            phoneTxt.SelectedText = "";
            phoneTxt.SelectionLength = 0;
            phoneTxt.SelectionStart = 0;
            phoneTxt.ShortcutsEnabled = true;
            phoneTxt.Size = new Size(370, 48);
            phoneTxt.TabIndex = 1;
            phoneTxt.TabStop = false;
            phoneTxt.TextAlign = HorizontalAlignment.Left;
            phoneTxt.TrailingIcon = null;
            phoneTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(17, 17);
            materialLabel8.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(104, 48);
            materialLabel8.TabIndex = 0;
            materialLabel8.Text = "Phone";
            materialLabel8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(maritalCbo);
            materialCard1.Controls.Add(sexCbo);
            materialCard1.Controls.Add(materialLabel4);
            materialCard1.Controls.Add(dobPkr);
            materialCard1.Controls.Add(materialLabel3);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Controls.Add(nameTxt);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 78);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(671, 247);
            materialCard1.TabIndex = 33;
            // 
            // maritalCbo
            // 
            maritalCbo.AutoResize = false;
            maritalCbo.BackColor = Color.FromArgb(255, 255, 255);
            maritalCbo.Depth = 0;
            maritalCbo.DrawMode = DrawMode.OwnerDrawVariable;
            maritalCbo.DropDownHeight = 174;
            maritalCbo.DropDownStyle = ComboBoxStyle.DropDownList;
            maritalCbo.DropDownWidth = 121;
            maritalCbo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            maritalCbo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            maritalCbo.FormattingEnabled = true;
            maritalCbo.IntegralHeight = false;
            maritalCbo.ItemHeight = 43;
            maritalCbo.Items.AddRange(new object[] { "Single", "Maried", "Divorced", "Widowed" });
            maritalCbo.Location = new Point(127, 179);
            maritalCbo.MaxDropDownItems = 4;
            maritalCbo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            maritalCbo.Name = "maritalCbo";
            maritalCbo.Size = new Size(371, 49);
            maritalCbo.StartIndex = 0;
            maritalCbo.TabIndex = 11;
            // 
            // sexCbo
            // 
            sexCbo.AutoResize = false;
            sexCbo.BackColor = Color.FromArgb(255, 255, 255);
            sexCbo.Depth = 0;
            sexCbo.DrawMode = DrawMode.OwnerDrawVariable;
            sexCbo.DropDownHeight = 174;
            sexCbo.DropDownStyle = ComboBoxStyle.DropDownList;
            sexCbo.DropDownWidth = 121;
            sexCbo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            sexCbo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sexCbo.FormattingEnabled = true;
            sexCbo.IntegralHeight = false;
            sexCbo.ItemHeight = 43;
            sexCbo.Items.AddRange(new object[] { "Male", "Female" });
            sexCbo.Location = new Point(127, 70);
            sexCbo.MaxDropDownItems = 4;
            sexCbo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            sexCbo.Name = "sexCbo";
            sexCbo.Size = new Size(371, 49);
            sexCbo.StartIndex = 0;
            sexCbo.TabIndex = 10;
            // 
            // materialLabel4
            // 
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(17, 179);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(104, 48);
            materialLabel4.TabIndex = 9;
            materialLabel4.Text = "Marital Status";
            materialLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel3
            // 
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(17, 125);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(104, 48);
            materialLabel3.TabIndex = 7;
            materialLabel3.Text = "Date of Birth";
            materialLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(17, 71);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(104, 48);
            materialLabel2.TabIndex = 6;
            materialLabel2.Text = "Sex";
            materialLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nameTxt
            // 
            nameTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTxt.AnimateReadOnly = false;
            nameTxt.AutoCompleteMode = AutoCompleteMode.None;
            nameTxt.AutoCompleteSource = AutoCompleteSource.None;
            nameTxt.BackgroundImageLayout = ImageLayout.None;
            nameTxt.CharacterCasing = CharacterCasing.Normal;
            nameTxt.Depth = 0;
            nameTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nameTxt.HideSelection = true;
            nameTxt.LeadingIcon = null;
            nameTxt.Location = new Point(127, 17);
            nameTxt.MaxLength = 32767;
            nameTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            nameTxt.Name = "nameTxt";
            nameTxt.PasswordChar = '\0';
            nameTxt.PrefixSuffixText = null;
            nameTxt.ReadOnly = false;
            nameTxt.RightToLeft = RightToLeft.No;
            nameTxt.SelectedText = "";
            nameTxt.SelectionLength = 0;
            nameTxt.SelectionStart = 0;
            nameTxt.ShortcutsEnabled = true;
            nameTxt.Size = new Size(371, 48);
            nameTxt.TabIndex = 1;
            nameTxt.TabStop = false;
            nameTxt.TextAlign = HorizontalAlignment.Left;
            nameTxt.TrailingIcon = null;
            nameTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(17, 17);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(104, 48);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Full Name";
            materialLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(disOtherTxt);
            materialCard3.Controls.Add(materialCard4);
            materialCard3.Controls.Add(materialLabel7);
            materialCard3.Controls.Add(bloodTypeCbo);
            materialCard3.Controls.Add(materialLabel6);
            materialCard3.Controls.Add(notesTxt);
            materialCard3.Controls.Add(materialLabel5);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(17, 460);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(671, 347);
            materialCard3.TabIndex = 35;
            // 
            // disOtherTxt
            // 
            disOtherTxt.AnimateReadOnly = false;
            disOtherTxt.BackgroundImageLayout = ImageLayout.None;
            disOtherTxt.CharacterCasing = CharacterCasing.Normal;
            disOtherTxt.Depth = 0;
            disOtherTxt.HideSelection = true;
            disOtherTxt.Hint = "Other Diseases...";
            disOtherTxt.Location = new Point(374, 83);
            disOtherTxt.MaxLength = 32767;
            disOtherTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            disOtherTxt.Name = "disOtherTxt";
            disOtherTxt.PasswordChar = '\0';
            disOtherTxt.ReadOnly = false;
            disOtherTxt.ScrollBars = ScrollBars.None;
            disOtherTxt.SelectedText = "";
            disOtherTxt.SelectionLength = 0;
            disOtherTxt.SelectionStart = 0;
            disOtherTxt.ShortcutsEnabled = true;
            disOtherTxt.Size = new Size(280, 103);
            disOtherTxt.TabIndex = 37;
            disOtherTxt.TabStop = false;
            disOtherTxt.TextAlign = HorizontalAlignment.Left;
            disOtherTxt.UseSystemPasswordChar = false;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(chronicDiseasesGrp);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(127, 83);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(230, 103);
            materialCard4.TabIndex = 36;
            // 
            // chronicDiseasesGrp
            // 
            chronicDiseasesGrp.AutoScroll = true;
            chronicDiseasesGrp.Controls.Add(materialCheckBox2);
            chronicDiseasesGrp.Controls.Add(materialCheckBox3);
            chronicDiseasesGrp.Controls.Add(materialCheckBox4);
            chronicDiseasesGrp.Controls.Add(materialCheckBox5);
            chronicDiseasesGrp.Controls.Add(materialCheckBox6);
            chronicDiseasesGrp.Controls.Add(materialCheckBox1);
            chronicDiseasesGrp.Controls.Add(materialCheckBox7);
            chronicDiseasesGrp.Dock = DockStyle.Fill;
            chronicDiseasesGrp.FlowDirection = FlowDirection.TopDown;
            chronicDiseasesGrp.Location = new Point(14, 14);
            chronicDiseasesGrp.Name = "chronicDiseasesGrp";
            chronicDiseasesGrp.Size = new Size(202, 75);
            chronicDiseasesGrp.TabIndex = 0;
            chronicDiseasesGrp.WrapContents = false;
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
            materialCheckBox2.Size = new Size(97, 37);
            materialCheckBox2.TabIndex = 14;
            materialCheckBox2.Text = "Diabetes";
            materialCheckBox2.UseAccentColor = false;
            materialCheckBox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox3
            // 
            materialCheckBox3.AutoSize = true;
            materialCheckBox3.Depth = 0;
            materialCheckBox3.Location = new Point(0, 37);
            materialCheckBox3.Margin = new Padding(0);
            materialCheckBox3.MouseLocation = new Point(-1, -1);
            materialCheckBox3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox3.Name = "materialCheckBox3";
            materialCheckBox3.ReadOnly = false;
            materialCheckBox3.Ripple = true;
            materialCheckBox3.Size = new Size(124, 37);
            materialCheckBox3.TabIndex = 15;
            materialCheckBox3.Text = "Hypotension";
            materialCheckBox3.UseAccentColor = false;
            materialCheckBox3.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox4
            // 
            materialCheckBox4.AutoSize = true;
            materialCheckBox4.Depth = 0;
            materialCheckBox4.Location = new Point(0, 74);
            materialCheckBox4.Margin = new Padding(0);
            materialCheckBox4.MouseLocation = new Point(-1, -1);
            materialCheckBox4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox4.Name = "materialCheckBox4";
            materialCheckBox4.ReadOnly = false;
            materialCheckBox4.Ripple = true;
            materialCheckBox4.Size = new Size(128, 37);
            materialCheckBox4.TabIndex = 16;
            materialCheckBox4.Text = "Hypertension";
            materialCheckBox4.UseAccentColor = false;
            materialCheckBox4.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox5
            // 
            materialCheckBox5.AutoSize = true;
            materialCheckBox5.Depth = 0;
            materialCheckBox5.Location = new Point(0, 111);
            materialCheckBox5.Margin = new Padding(0);
            materialCheckBox5.MouseLocation = new Point(-1, -1);
            materialCheckBox5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox5.Name = "materialCheckBox5";
            materialCheckBox5.ReadOnly = false;
            materialCheckBox5.Ripple = true;
            materialCheckBox5.Size = new Size(133, 37);
            materialCheckBox5.TabIndex = 17;
            materialCheckBox5.Text = "Heart Disease";
            materialCheckBox5.UseAccentColor = false;
            materialCheckBox5.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox6
            // 
            materialCheckBox6.AutoSize = true;
            materialCheckBox6.Depth = 0;
            materialCheckBox6.Location = new Point(0, 148);
            materialCheckBox6.Margin = new Padding(0);
            materialCheckBox6.MouseLocation = new Point(-1, -1);
            materialCheckBox6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox6.Name = "materialCheckBox6";
            materialCheckBox6.ReadOnly = false;
            materialCheckBox6.Ripple = true;
            materialCheckBox6.Size = new Size(90, 37);
            materialCheckBox6.TabIndex = 18;
            materialCheckBox6.Text = "Asthma";
            materialCheckBox6.UseAccentColor = false;
            materialCheckBox6.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox1
            // 
            materialCheckBox1.AutoSize = true;
            materialCheckBox1.Depth = 0;
            materialCheckBox1.Location = new Point(0, 185);
            materialCheckBox1.Margin = new Padding(0);
            materialCheckBox1.MouseLocation = new Point(-1, -1);
            materialCheckBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox1.Name = "materialCheckBox1";
            materialCheckBox1.ReadOnly = false;
            materialCheckBox1.Ripple = true;
            materialCheckBox1.Size = new Size(89, 37);
            materialCheckBox1.TabIndex = 19;
            materialCheckBox1.Text = "Anemia";
            materialCheckBox1.UseAccentColor = false;
            materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox7
            // 
            materialCheckBox7.AutoSize = true;
            materialCheckBox7.Depth = 0;
            materialCheckBox7.Location = new Point(0, 222);
            materialCheckBox7.Margin = new Padding(0);
            materialCheckBox7.MouseLocation = new Point(-1, -1);
            materialCheckBox7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox7.Name = "materialCheckBox7";
            materialCheckBox7.ReadOnly = false;
            materialCheckBox7.Ripple = true;
            materialCheckBox7.Size = new Size(129, 37);
            materialCheckBox7.TabIndex = 20;
            materialCheckBox7.Text = "Liver Disease";
            materialCheckBox7.UseAccentColor = false;
            materialCheckBox7.UseVisualStyleBackColor = true;
            // 
            // materialLabel7
            // 
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(17, 72);
            materialLabel7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(104, 48);
            materialLabel7.TabIndex = 12;
            materialLabel7.Text = "Chronic Diseases";
            materialLabel7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bloodTypeCbo
            // 
            bloodTypeCbo.AutoResize = false;
            bloodTypeCbo.BackColor = Color.FromArgb(255, 255, 255);
            bloodTypeCbo.Depth = 0;
            bloodTypeCbo.DrawMode = DrawMode.OwnerDrawVariable;
            bloodTypeCbo.DropDownHeight = 174;
            bloodTypeCbo.DropDownStyle = ComboBoxStyle.DropDownList;
            bloodTypeCbo.DropDownWidth = 121;
            bloodTypeCbo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            bloodTypeCbo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            bloodTypeCbo.FormattingEnabled = true;
            bloodTypeCbo.IntegralHeight = false;
            bloodTypeCbo.ItemHeight = 43;
            bloodTypeCbo.Items.AddRange(new object[] { "Choose Type...", "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            bloodTypeCbo.Location = new Point(127, 17);
            bloodTypeCbo.MaxDropDownItems = 4;
            bloodTypeCbo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            bloodTypeCbo.Name = "bloodTypeCbo";
            bloodTypeCbo.Size = new Size(371, 49);
            bloodTypeCbo.StartIndex = 0;
            bloodTypeCbo.TabIndex = 11;
            // 
            // materialLabel6
            // 
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(17, 203);
            materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(104, 48);
            materialLabel6.TabIndex = 2;
            materialLabel6.Text = "Notes";
            materialLabel6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // notesTxt
            // 
            notesTxt.AnimateReadOnly = false;
            notesTxt.BackgroundImageLayout = ImageLayout.None;
            notesTxt.CharacterCasing = CharacterCasing.Normal;
            notesTxt.Depth = 0;
            notesTxt.HideSelection = true;
            notesTxt.Location = new Point(127, 203);
            notesTxt.MaxLength = 32767;
            notesTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            notesTxt.Name = "notesTxt";
            notesTxt.PasswordChar = '\0';
            notesTxt.ReadOnly = false;
            notesTxt.ScrollBars = ScrollBars.None;
            notesTxt.SelectedText = "";
            notesTxt.SelectionLength = 0;
            notesTxt.SelectionStart = 0;
            notesTxt.ShortcutsEnabled = true;
            notesTxt.Size = new Size(371, 125);
            notesTxt.TabIndex = 1;
            notesTxt.TabStop = false;
            notesTxt.TextAlign = HorizontalAlignment.Left;
            notesTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(17, 17);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(104, 48);
            materialLabel5.TabIndex = 0;
            materialLabel5.Text = "Blood Type";
            materialLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // saveBtn
            // 
            saveBtn.AutoSize = false;
            saveBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            saveBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            saveBtn.Depth = 0;
            saveBtn.HighEmphasis = true;
            saveBtn.Icon = null;
            saveBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            saveBtn.Location = new Point(532, 827);
            saveBtn.Margin = new Padding(4, 6, 4, 6);
            saveBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            saveBtn.Name = "saveBtn";
            saveBtn.NoAccentTextColor = Color.Empty;
            saveBtn.Size = new Size(158, 36);
            saveBtn.TabIndex = 36;
            saveBtn.Text = "Save";
            saveBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            saveBtn.UseAccentColor = false;
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // PatientDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 874);
            Controls.Add(saveBtn);
            Controls.Add(materialCard2);
            Controls.Add(materialCard3);
            Controls.Add(materialCard1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PatientDataForm";
            ShowInTaskbar = false;
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Patient";
            materialCard2.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            materialCard4.ResumeLayout(false);
            chronicDiseasesGrp.ResumeLayout(false);
            chronicDiseasesGrp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dobPkr;
        private Label label4;
        private GroupBox groupBox2;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit nameTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialComboBox sexCbo;
        private ReaLTaiizor.Controls.MaterialComboBox maritalCbo;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit phoneTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel8;
        private ReaLTaiizor.Controls.MaterialCard materialCard3;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit notesTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private ReaLTaiizor.Controls.MaterialComboBox bloodTypeCbo;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel7;
        private ReaLTaiizor.Controls.MaterialCard materialCard4;
        private FlowLayoutPanel chronicDiseasesGrp;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox2;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox3;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox4;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox5;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox6;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox1;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox7;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit disOtherTxt;
        private ReaLTaiizor.Controls.MaterialButton saveBtn;
    }
}