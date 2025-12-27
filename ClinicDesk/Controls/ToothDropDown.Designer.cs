namespace ClinicDesk.Controls
{
    partial class ToothDropDown
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusCbo = new ReaLTaiizor.Controls.MaterialComboBox();
            noteTxt = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            saveBtn = new ReaLTaiizor.Controls.MaterialButton();
            crownCbo = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            fillingCbo = new ReaLTaiizor.Controls.MaterialComboBox();
            SuspendLayout();
            // 
            // statusCbo
            // 
            statusCbo.AutoResize = false;
            statusCbo.BackColor = Color.FromArgb(255, 255, 255);
            statusCbo.Depth = 0;
            statusCbo.DrawMode = DrawMode.OwnerDrawVariable;
            statusCbo.DropDownHeight = 174;
            statusCbo.DropDownStyle = ComboBoxStyle.DropDownList;
            statusCbo.DropDownWidth = 121;
            statusCbo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            statusCbo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            statusCbo.FormattingEnabled = true;
            statusCbo.IntegralHeight = false;
            statusCbo.ItemHeight = 43;
            statusCbo.Items.AddRange(new object[] { "Normal", "Missing", "Filled", "Crown", "Implant", "Root Canal" });
            statusCbo.Location = new Point(4, 3);
            statusCbo.MaxDropDownItems = 4;
            statusCbo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            statusCbo.Name = "statusCbo";
            statusCbo.Size = new Size(321, 49);
            statusCbo.StartIndex = 0;
            statusCbo.TabIndex = 0;
            // 
            // noteTxt
            // 
            noteTxt.AnimateReadOnly = false;
            noteTxt.BackgroundImageLayout = ImageLayout.None;
            noteTxt.CharacterCasing = CharacterCasing.Normal;
            noteTxt.Depth = 0;
            noteTxt.HideSelection = true;
            noteTxt.Hint = "Notes";
            noteTxt.Location = new Point(3, 168);
            noteTxt.MaxLength = 32767;
            noteTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            noteTxt.Name = "noteTxt";
            noteTxt.PasswordChar = '\0';
            noteTxt.ReadOnly = false;
            noteTxt.ScrollBars = ScrollBars.None;
            noteTxt.SelectedText = "";
            noteTxt.SelectionLength = 0;
            noteTxt.SelectionStart = 0;
            noteTxt.ShortcutsEnabled = true;
            noteTxt.Size = new Size(322, 125);
            noteTxt.TabIndex = 1;
            noteTxt.TabStop = false;
            noteTxt.TextAlign = HorizontalAlignment.Left;
            noteTxt.UseSystemPasswordChar = false;
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
            saveBtn.Location = new Point(4, 302);
            saveBtn.Margin = new Padding(4, 6, 4, 6);
            saveBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            saveBtn.Name = "saveBtn";
            saveBtn.NoAccentTextColor = Color.Empty;
            saveBtn.Size = new Size(320, 36);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Save";
            saveBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            saveBtn.UseAccentColor = false;
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // crownCbo
            // 
            crownCbo.AutoResize = false;
            crownCbo.BackColor = Color.FromArgb(255, 255, 255);
            crownCbo.Depth = 0;
            crownCbo.DrawMode = DrawMode.OwnerDrawVariable;
            crownCbo.DropDownHeight = 174;
            crownCbo.DropDownStyle = ComboBoxStyle.DropDownList;
            crownCbo.DropDownWidth = 121;
            crownCbo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            crownCbo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            crownCbo.FormattingEnabled = true;
            crownCbo.IntegralHeight = false;
            crownCbo.ItemHeight = 43;
            crownCbo.Items.AddRange(new object[] { "No Crown", "Porcelain Crown", "Metal Crown", "Zirconia Crown" });
            crownCbo.Location = new Point(4, 58);
            crownCbo.MaxDropDownItems = 4;
            crownCbo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            crownCbo.Name = "crownCbo";
            crownCbo.Size = new Size(322, 49);
            crownCbo.StartIndex = 0;
            crownCbo.TabIndex = 3;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(4, 74);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(1, 0);
            materialLabel1.TabIndex = 4;
            // 
            // fillingCbo
            // 
            fillingCbo.AutoResize = false;
            fillingCbo.BackColor = Color.FromArgb(255, 255, 255);
            fillingCbo.Depth = 0;
            fillingCbo.DrawMode = DrawMode.OwnerDrawVariable;
            fillingCbo.DropDownHeight = 174;
            fillingCbo.DropDownStyle = ComboBoxStyle.DropDownList;
            fillingCbo.DropDownWidth = 121;
            fillingCbo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            fillingCbo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            fillingCbo.FormattingEnabled = true;
            fillingCbo.IntegralHeight = false;
            fillingCbo.ItemHeight = 43;
            fillingCbo.Items.AddRange(new object[] { "No Filling", "Amalgam Filling", "Composite Filling", "GlassIonomer Filling", "ResinIonomer Filling", "Gold, Filling", "Ceramic Filling", "Temporary Filling", "Indirect Composite Filling", "Compomer Filling" });
            fillingCbo.Location = new Point(3, 113);
            fillingCbo.MaxDropDownItems = 4;
            fillingCbo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            fillingCbo.Name = "fillingCbo";
            fillingCbo.Size = new Size(322, 49);
            fillingCbo.StartIndex = 0;
            fillingCbo.TabIndex = 5;
            // 
            // ToothDropDown
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(fillingCbo);
            Controls.Add(materialLabel1);
            Controls.Add(crownCbo);
            Controls.Add(saveBtn);
            Controls.Add(noteTxt);
            Controls.Add(statusCbo);
            Name = "ToothDropDown";
            Size = new Size(328, 346);
            Load += ToothDropDown_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox statusCbo;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit noteTxt;
        private ReaLTaiizor.Controls.MaterialButton saveBtn;
        private ReaLTaiizor.Controls.MaterialComboBox crownCbo;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialComboBox fillingCbo;
    }
}
