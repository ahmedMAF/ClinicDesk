namespace ClinicDesk.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAppointmentForm));
            timePkr = new DateTimePicker();
            datePkr = new DateTimePicker();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            phoneTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            nameTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            saveBtn = new ReaLTaiizor.Controls.MaterialButton();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            SuspendLayout();
            // 
            // timePkr
            // 
            timePkr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            timePkr.CustomFormat = "  hh:mm tt";
            timePkr.Format = DateTimePickerFormat.Custom;
            timePkr.Location = new Point(127, 79);
            timePkr.Name = "timePkr";
            timePkr.Size = new Size(432, 27);
            timePkr.TabIndex = 3;
            // 
            // datePkr
            // 
            datePkr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datePkr.CustomFormat = "  dd/MM/yyyy";
            datePkr.Format = DateTimePickerFormat.Custom;
            datePkr.Location = new Point(127, 25);
            datePkr.Name = "datePkr";
            datePkr.Size = new Size(432, 27);
            datePkr.TabIndex = 1;
            // 
            // materialCard1
            // 
            materialCard1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Controls.Add(phoneTxt);
            materialCard1.Controls.Add(nameTxt);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 78);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(576, 135);
            materialCard1.TabIndex = 33;
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
            materialLabel2.Text = "Phone";
            materialLabel2.TextAlign = ContentAlignment.MiddleLeft;
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
            phoneTxt.Location = new Point(127, 71);
            phoneTxt.MaxLength = 32767;
            phoneTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            phoneTxt.Name = "phoneTxt";
            phoneTxt.PasswordChar = '\0';
            phoneTxt.PrefixSuffixText = null;
            phoneTxt.ReadOnly = true;
            phoneTxt.RightToLeft = RightToLeft.No;
            phoneTxt.SelectedText = "";
            phoneTxt.SelectionLength = 0;
            phoneTxt.SelectionStart = 0;
            phoneTxt.ShortcutsEnabled = true;
            phoneTxt.Size = new Size(432, 48);
            phoneTxt.TabIndex = 3;
            phoneTxt.TabStop = false;
            phoneTxt.Text = "materialTextBoxEdit2";
            phoneTxt.TextAlign = HorizontalAlignment.Left;
            phoneTxt.TrailingIcon = null;
            phoneTxt.UseSystemPasswordChar = false;
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
            nameTxt.Size = new Size(432, 48);
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
            // materialCard2
            // 
            materialCard2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(timePkr);
            materialCard2.Controls.Add(materialLabel3);
            materialCard2.Controls.Add(datePkr);
            materialCard2.Controls.Add(materialLabel4);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(17, 233);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(576, 135);
            materialCard2.TabIndex = 34;
            // 
            // materialLabel3
            // 
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(17, 71);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(104, 48);
            materialLabel3.TabIndex = 6;
            materialLabel3.Text = "Time";
            materialLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel4
            // 
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(17, 17);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(104, 48);
            materialLabel4.TabIndex = 0;
            materialLabel4.Text = "Date";
            materialLabel4.TextAlign = ContentAlignment.MiddleLeft;
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
            saveBtn.Location = new Point(435, 388);
            saveBtn.Margin = new Padding(4, 6, 4, 6);
            saveBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            saveBtn.Name = "saveBtn";
            saveBtn.NoAccentTextColor = Color.Empty;
            saveBtn.Size = new Size(158, 36);
            saveBtn.TabIndex = 35;
            saveBtn.Text = "Save";
            saveBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            saveBtn.UseAccentColor = false;
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // NewAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 440);
            Controls.Add(saveBtn);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewAppointmentForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Appointment";
            Load += NewAppointmentForm_Load;
            KeyPress += Utilities.Utils.CloseForm_KeyPress;
            materialCard1.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit phoneTxt;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private DateTimePicker datePkr;
        private Button cancelBtn;
        private DateTimePicker timePkr;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit sexTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit nameTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ReaLTaiizor.Controls.MaterialButton saveBtn;
    }
}