using ReaLTaiizor.Controls;

namespace ClinicDesk.Forms
{
    partial class AppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            visitsGrd = new DataGridView();
            materialCard1 = new MaterialCard();
            materialLabel4 = new MaterialLabel();
            maritalTxt = new MaterialTextBoxEdit();
            materialLabel3 = new MaterialLabel();
            materialLabel2 = new MaterialLabel();
            ageTxt = new MaterialTextBoxEdit();
            sexTxt = new MaterialTextBoxEdit();
            nameTxt = new MaterialTextBoxEdit();
            materialLabel1 = new MaterialLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            materialCard2 = new MaterialCard();
            chronicDiseasesLst = new MaterialListBox();
            materialLabel7 = new MaterialLabel();
            bloodTypeTxt = new MaterialTextBoxEdit();
            materialLabel8 = new MaterialLabel();
            notesTxt = new MaterialMultiLineTextBoxEdit();
            materialLabel5 = new MaterialLabel();
            materialLabel6 = new MaterialLabel();
            materialLabel9 = new MaterialLabel();
            diagnosisTxt = new MaterialMultiLineTextBoxEdit();
            materialLabel10 = new MaterialLabel();
            treatmentTxt = new MaterialMultiLineTextBoxEdit();
            billTxt = new MaterialTextBoxEdit();
            materialLabel11 = new MaterialLabel();
            materialButton1 = new MaterialButton();
            materialCard3 = new MaterialCard();
            ((System.ComponentModel.ISupportInitialize)visitsGrd).BeginInit();
            materialCard1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard3.SuspendLayout();
            SuspendLayout();
            // 
            // visitsGrd
            // 
            visitsGrd.AllowUserToAddRows = false;
            visitsGrd.AllowUserToDeleteRows = false;
            visitsGrd.AllowUserToOrderColumns = true;
            visitsGrd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            visitsGrd.BackgroundColor = Color.White;
            visitsGrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visitsGrd.Location = new Point(17, 499);
            visitsGrd.Name = "visitsGrd";
            visitsGrd.ReadOnly = true;
            visitsGrd.RowHeadersWidth = 51;
            visitsGrd.Size = new Size(1058, 101);
            visitsGrd.TabIndex = 6;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialLabel4);
            materialCard1.Controls.Add(maritalTxt);
            materialCard1.Controls.Add(materialLabel3);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Controls.Add(ageTxt);
            materialCard1.Controls.Add(sexTxt);
            materialCard1.Controls.Add(nameTxt);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(14, 14);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(515, 247);
            materialCard1.TabIndex = 32;
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
            // maritalTxt
            // 
            maritalTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maritalTxt.AnimateReadOnly = false;
            maritalTxt.AutoCompleteMode = AutoCompleteMode.None;
            maritalTxt.AutoCompleteSource = AutoCompleteSource.None;
            maritalTxt.BackgroundImageLayout = ImageLayout.None;
            maritalTxt.CharacterCasing = CharacterCasing.Normal;
            maritalTxt.Depth = 0;
            maritalTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            maritalTxt.HideSelection = true;
            maritalTxt.LeadingIcon = null;
            maritalTxt.Location = new Point(127, 179);
            maritalTxt.MaxLength = 32767;
            maritalTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            maritalTxt.Name = "maritalTxt";
            maritalTxt.PasswordChar = '\0';
            maritalTxt.PrefixSuffixText = null;
            maritalTxt.ReadOnly = true;
            maritalTxt.RightToLeft = RightToLeft.No;
            maritalTxt.SelectedText = "";
            maritalTxt.SelectionLength = 0;
            maritalTxt.SelectionStart = 0;
            maritalTxt.ShortcutsEnabled = true;
            maritalTxt.Size = new Size(371, 48);
            maritalTxt.TabIndex = 8;
            maritalTxt.TabStop = false;
            maritalTxt.Text = "materialTextBoxEdit4";
            maritalTxt.TextAlign = HorizontalAlignment.Left;
            maritalTxt.TrailingIcon = null;
            maritalTxt.UseSystemPasswordChar = false;
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
            materialLabel3.Text = "Age";
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
            // ageTxt
            // 
            ageTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ageTxt.AnimateReadOnly = false;
            ageTxt.AutoCompleteMode = AutoCompleteMode.None;
            ageTxt.AutoCompleteSource = AutoCompleteSource.None;
            ageTxt.BackgroundImageLayout = ImageLayout.None;
            ageTxt.CharacterCasing = CharacterCasing.Normal;
            ageTxt.Depth = 0;
            ageTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ageTxt.HideSelection = true;
            ageTxt.LeadingIcon = null;
            ageTxt.Location = new Point(127, 125);
            ageTxt.MaxLength = 32767;
            ageTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ageTxt.Name = "ageTxt";
            ageTxt.PasswordChar = '\0';
            ageTxt.PrefixSuffixText = null;
            ageTxt.ReadOnly = true;
            ageTxt.RightToLeft = RightToLeft.No;
            ageTxt.SelectedText = "";
            ageTxt.SelectionLength = 0;
            ageTxt.SelectionStart = 0;
            ageTxt.ShortcutsEnabled = true;
            ageTxt.Size = new Size(371, 48);
            ageTxt.TabIndex = 5;
            ageTxt.TabStop = false;
            ageTxt.Text = "materialTextBoxEdit3";
            ageTxt.TextAlign = HorizontalAlignment.Left;
            ageTxt.TrailingIcon = null;
            ageTxt.UseSystemPasswordChar = false;
            // 
            // sexTxt
            // 
            sexTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sexTxt.AnimateReadOnly = false;
            sexTxt.AutoCompleteMode = AutoCompleteMode.None;
            sexTxt.AutoCompleteSource = AutoCompleteSource.None;
            sexTxt.BackgroundImageLayout = ImageLayout.None;
            sexTxt.CharacterCasing = CharacterCasing.Normal;
            sexTxt.Depth = 0;
            sexTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            sexTxt.HideSelection = true;
            sexTxt.LeadingIcon = null;
            sexTxt.Location = new Point(127, 71);
            sexTxt.MaxLength = 32767;
            sexTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            sexTxt.Name = "sexTxt";
            sexTxt.PasswordChar = '\0';
            sexTxt.PrefixSuffixText = null;
            sexTxt.ReadOnly = true;
            sexTxt.RightToLeft = RightToLeft.No;
            sexTxt.SelectedText = "";
            sexTxt.SelectionLength = 0;
            sexTxt.SelectionStart = 0;
            sexTxt.ShortcutsEnabled = true;
            sexTxt.Size = new Size(371, 48);
            sexTxt.TabIndex = 3;
            sexTxt.TabStop = false;
            sexTxt.Text = "materialTextBoxEdit2";
            sexTxt.TextAlign = HorizontalAlignment.Left;
            sexTxt.TrailingIcon = null;
            sexTxt.UseSystemPasswordChar = false;
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
            nameTxt.ReadOnly = true;
            nameTxt.RightToLeft = RightToLeft.No;
            nameTxt.SelectedText = "";
            nameTxt.SelectionLength = 0;
            nameTxt.SelectionStart = 0;
            nameTxt.ShortcutsEnabled = true;
            nameTxt.Size = new Size(371, 48);
            nameTxt.TabIndex = 1;
            nameTxt.TabStop = false;
            nameTxt.Text = "materialTextBoxEdit1";
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(materialCard2, 1, 0);
            tableLayoutPanel1.Controls.Add(materialCard1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1086, 275);
            tableLayoutPanel1.TabIndex = 33;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(chronicDiseasesLst);
            materialCard2.Controls.Add(materialLabel7);
            materialCard2.Controls.Add(bloodTypeTxt);
            materialCard2.Controls.Add(materialLabel8);
            materialCard2.Depth = 0;
            materialCard2.Dock = DockStyle.Fill;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(557, 14);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(515, 247);
            materialCard2.TabIndex = 33;
            // 
            // chronicDiseasesLst
            // 
            chronicDiseasesLst.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chronicDiseasesLst.BackColor = Color.White;
            chronicDiseasesLst.BorderColor = Color.LightGray;
            chronicDiseasesLst.Depth = 0;
            chronicDiseasesLst.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            chronicDiseasesLst.Location = new Point(127, 71);
            chronicDiseasesLst.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            chronicDiseasesLst.Name = "chronicDiseasesLst";
            chronicDiseasesLst.SelectedIndex = -1;
            chronicDiseasesLst.SelectedItem = null;
            chronicDiseasesLst.Size = new Size(371, 159);
            chronicDiseasesLst.TabIndex = 8;
            // 
            // materialLabel7
            // 
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(17, 71);
            materialLabel7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(104, 48);
            materialLabel7.TabIndex = 6;
            materialLabel7.Text = "Chronic Diseases";
            materialLabel7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bloodTypeTxt
            // 
            bloodTypeTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bloodTypeTxt.AnimateReadOnly = false;
            bloodTypeTxt.AutoCompleteMode = AutoCompleteMode.None;
            bloodTypeTxt.AutoCompleteSource = AutoCompleteSource.None;
            bloodTypeTxt.BackgroundImageLayout = ImageLayout.None;
            bloodTypeTxt.CharacterCasing = CharacterCasing.Normal;
            bloodTypeTxt.Depth = 0;
            bloodTypeTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            bloodTypeTxt.HideSelection = true;
            bloodTypeTxt.LeadingIcon = null;
            bloodTypeTxt.Location = new Point(127, 17);
            bloodTypeTxt.MaxLength = 32767;
            bloodTypeTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            bloodTypeTxt.Name = "bloodTypeTxt";
            bloodTypeTxt.PasswordChar = '\0';
            bloodTypeTxt.PrefixSuffixText = null;
            bloodTypeTxt.ReadOnly = true;
            bloodTypeTxt.RightToLeft = RightToLeft.No;
            bloodTypeTxt.SelectedText = "";
            bloodTypeTxt.SelectionLength = 0;
            bloodTypeTxt.SelectionStart = 0;
            bloodTypeTxt.ShortcutsEnabled = true;
            bloodTypeTxt.Size = new Size(371, 48);
            bloodTypeTxt.TabIndex = 1;
            bloodTypeTxt.TabStop = false;
            bloodTypeTxt.Text = "materialTextBoxEdit8";
            bloodTypeTxt.TextAlign = HorizontalAlignment.Left;
            bloodTypeTxt.TrailingIcon = null;
            bloodTypeTxt.UseSystemPasswordChar = false;
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
            materialLabel8.Text = "Blood Type";
            materialLabel8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // notesTxt
            // 
            notesTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            notesTxt.AnimateReadOnly = false;
            notesTxt.BackgroundImageLayout = ImageLayout.None;
            notesTxt.CharacterCasing = CharacterCasing.Normal;
            notesTxt.Depth = 0;
            notesTxt.HideSelection = true;
            notesTxt.Location = new Point(144, 345);
            notesTxt.MaxLength = 32767;
            notesTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            notesTxt.Name = "notesTxt";
            notesTxt.PasswordChar = '\0';
            notesTxt.ReadOnly = true;
            notesTxt.ScrollBars = ScrollBars.None;
            notesTxt.SelectedText = "";
            notesTxt.SelectionLength = 0;
            notesTxt.SelectionStart = 0;
            notesTxt.ShortcutsEnabled = true;
            notesTxt.Size = new Size(931, 125);
            notesTxt.TabIndex = 34;
            notesTxt.TabStop = false;
            notesTxt.TextAlign = HorizontalAlignment.Left;
            notesTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(17, 345);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(121, 48);
            materialLabel5.TabIndex = 10;
            materialLabel5.Text = "Notes";
            materialLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel6
            // 
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(17, 471);
            materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(121, 25);
            materialLabel6.TabIndex = 35;
            materialLabel6.Text = "Past Visits";
            materialLabel6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel9
            // 
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(17, 14);
            materialLabel9.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(121, 48);
            materialLabel9.TabIndex = 36;
            materialLabel9.Text = "Diagnosis";
            materialLabel9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // diagnosisTxt
            // 
            diagnosisTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            diagnosisTxt.AnimateReadOnly = false;
            diagnosisTxt.BackgroundImageLayout = ImageLayout.None;
            diagnosisTxt.CharacterCasing = CharacterCasing.Normal;
            diagnosisTxt.Depth = 0;
            diagnosisTxt.HideSelection = true;
            diagnosisTxt.Location = new Point(144, 14);
            diagnosisTxt.MaxLength = 32767;
            diagnosisTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            diagnosisTxt.Name = "diagnosisTxt";
            diagnosisTxt.PasswordChar = '\0';
            diagnosisTxt.ReadOnly = false;
            diagnosisTxt.ScrollBars = ScrollBars.None;
            diagnosisTxt.SelectedText = "";
            diagnosisTxt.SelectionLength = 0;
            diagnosisTxt.SelectionStart = 0;
            diagnosisTxt.ShortcutsEnabled = true;
            diagnosisTxt.Size = new Size(897, 125);
            diagnosisTxt.TabIndex = 37;
            diagnosisTxt.TabStop = false;
            diagnosisTxt.TextAlign = HorizontalAlignment.Left;
            diagnosisTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel10
            // 
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(17, 145);
            materialLabel10.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(121, 48);
            materialLabel10.TabIndex = 38;
            materialLabel10.Text = "Treatment";
            materialLabel10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // treatmentTxt
            // 
            treatmentTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            treatmentTxt.AnimateReadOnly = false;
            treatmentTxt.BackgroundImageLayout = ImageLayout.None;
            treatmentTxt.CharacterCasing = CharacterCasing.Normal;
            treatmentTxt.Depth = 0;
            treatmentTxt.HideSelection = true;
            treatmentTxt.Location = new Point(144, 145);
            treatmentTxt.MaxLength = 32767;
            treatmentTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            treatmentTxt.Name = "treatmentTxt";
            treatmentTxt.PasswordChar = '\0';
            treatmentTxt.ReadOnly = false;
            treatmentTxt.ScrollBars = ScrollBars.None;
            treatmentTxt.SelectedText = "";
            treatmentTxt.SelectionLength = 0;
            treatmentTxt.SelectionStart = 0;
            treatmentTxt.ShortcutsEnabled = true;
            treatmentTxt.Size = new Size(897, 125);
            treatmentTxt.TabIndex = 39;
            treatmentTxt.TabStop = false;
            treatmentTxt.TextAlign = HorizontalAlignment.Left;
            treatmentTxt.UseSystemPasswordChar = false;
            // 
            // billTxt
            // 
            billTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            billTxt.AnimateReadOnly = false;
            billTxt.AutoCompleteMode = AutoCompleteMode.None;
            billTxt.AutoCompleteSource = AutoCompleteSource.None;
            billTxt.BackgroundImageLayout = ImageLayout.None;
            billTxt.CharacterCasing = CharacterCasing.Normal;
            billTxt.Depth = 0;
            billTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            billTxt.HideSelection = true;
            billTxt.LeadingIcon = null;
            billTxt.Location = new Point(144, 276);
            billTxt.MaxLength = 32767;
            billTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            billTxt.Name = "billTxt";
            billTxt.PasswordChar = '\0';
            billTxt.PrefixSuffixText = null;
            billTxt.ReadOnly = false;
            billTxt.RightToLeft = RightToLeft.No;
            billTxt.SelectedText = "";
            billTxt.SelectionLength = 0;
            billTxt.SelectionStart = 0;
            billTxt.ShortcutsEnabled = true;
            billTxt.Size = new Size(371, 48);
            billTxt.TabIndex = 41;
            billTxt.TabStop = false;
            billTxt.Text = "0";
            billTxt.TextAlign = HorizontalAlignment.Left;
            billTxt.TrailingIcon = null;
            billTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel11
            // 
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel11.Location = new Point(17, 276);
            materialLabel11.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(121, 48);
            materialLabel11.TabIndex = 40;
            materialLabel11.Text = "Bill";
            materialLabel11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialButton1
            // 
            materialButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.CharacterCasing = MaterialButton.CharacterCasingEnum.Normal;
            materialButton1.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(917, 968);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(158, 36);
            materialButton1.TabIndex = 42;
            materialButton1.Text = "Save";
            materialButton1.Type = MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += saveBtn_Click;
            // 
            // materialCard3
            // 
            materialCard3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(materialLabel9);
            materialCard3.Controls.Add(diagnosisTxt);
            materialCard3.Controls.Add(billTxt);
            materialCard3.Controls.Add(materialLabel11);
            materialCard3.Controls.Add(treatmentTxt);
            materialCard3.Controls.Add(materialLabel10);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(17, 613);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(1058, 335);
            materialCard3.TabIndex = 43;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 1013);
            Controls.Add(materialCard3);
            Controls.Add(materialButton1);
            Controls.Add(materialLabel6);
            Controls.Add(visitsGrd);
            Controls.Add(materialLabel5);
            Controls.Add(notesTxt);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointment";
            WindowState = FormWindowState.Maximized;
            Load += AppointmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)visitsGrd).EndInit();
            materialCard1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ComboBox bloodTypeCbo;
        private System.Windows.Forms.GroupBox groupBox3;
        private Label label7;
        private Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialTextBoxEdit ageTxt;
        private Label label4;
        private TextBox dobTxt;
        private ComboBox maritalCbo;
        private Label label5;
        private ComboBox sexCbo;
        private Label label3;
        private Label label2;
        private MaterialTextBoxEdit nameTxt;
        private MaterialTextBoxEdit sexTxt;
        private Label label1;
        private DataGridView visitsGrd;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit billTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit3;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private MaterialTextBoxEdit maritalTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit4;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel7;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit bloodTypeTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel8;
        private ReaLTaiizor.Controls.MaterialListBox chronicDiseasesLst;
        private MaterialMultiLineTextBoxEdit notesTxt;
        private MaterialLabel materialLabel5;
        private MaterialLabel materialLabel6;
        private MaterialLabel materialLabel9;
        private MaterialMultiLineTextBoxEdit diagnosisTxt;
        private MaterialLabel materialLabel10;
        private MaterialMultiLineTextBoxEdit treatmentTxt;
        private MaterialLabel materialLabel11;
        private MaterialButton materialButton1;
        private MaterialCard materialCard3;
    }
}