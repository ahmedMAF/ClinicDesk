namespace ClinicDesk.Forms
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            passwordTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            usernameTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            loginBtn = new ReaLTaiizor.Controls.MaterialButton();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(15, 125);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(73, 48);
            materialLabel2.TabIndex = 9;
            materialLabel2.Text = "Password";
            materialLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // passwordTxt
            // 
            passwordTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordTxt.AnimateReadOnly = false;
            passwordTxt.AutoCompleteMode = AutoCompleteMode.None;
            passwordTxt.AutoCompleteSource = AutoCompleteSource.None;
            passwordTxt.BackgroundImageLayout = ImageLayout.None;
            passwordTxt.CharacterCasing = CharacterCasing.Normal;
            passwordTxt.Depth = 0;
            passwordTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordTxt.HideSelection = true;
            passwordTxt.LeadingIcon = null;
            passwordTxt.Location = new Point(94, 125);
            passwordTxt.MaxLength = 32767;
            passwordTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '●';
            passwordTxt.PrefixSuffixText = null;
            passwordTxt.ReadOnly = false;
            passwordTxt.RightToLeft = RightToLeft.No;
            passwordTxt.SelectedText = "";
            passwordTxt.SelectionLength = 0;
            passwordTxt.SelectionStart = 0;
            passwordTxt.ShortcutsEnabled = true;
            passwordTxt.Size = new Size(439, 48);
            passwordTxt.TabIndex = 7;
            passwordTxt.TabStop = false;
            passwordTxt.TextAlign = HorizontalAlignment.Left;
            passwordTxt.TrailingIcon = null;
            passwordTxt.UseSystemPasswordChar = false;
            passwordTxt.TextChanged += passwordTxt_TextChanged;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(15, 71);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(73, 48);
            materialLabel1.TabIndex = 8;
            materialLabel1.Text = "Username";
            materialLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // usernameTxt
            // 
            usernameTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            usernameTxt.AnimateReadOnly = false;
            usernameTxt.AutoCompleteMode = AutoCompleteMode.None;
            usernameTxt.AutoCompleteSource = AutoCompleteSource.None;
            usernameTxt.BackgroundImageLayout = ImageLayout.None;
            usernameTxt.CharacterCasing = CharacterCasing.Normal;
            usernameTxt.Depth = 0;
            usernameTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            usernameTxt.HideSelection = true;
            usernameTxt.LeadingIcon = null;
            usernameTxt.Location = new Point(94, 71);
            usernameTxt.MaxLength = 32767;
            usernameTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            usernameTxt.Name = "usernameTxt";
            usernameTxt.PasswordChar = '\0';
            usernameTxt.PrefixSuffixText = null;
            usernameTxt.ReadOnly = false;
            usernameTxt.RightToLeft = RightToLeft.No;
            usernameTxt.SelectedText = "";
            usernameTxt.SelectionLength = 0;
            usernameTxt.SelectionStart = 0;
            usernameTxt.ShortcutsEnabled = true;
            usernameTxt.Size = new Size(439, 48);
            usernameTxt.TabIndex = 6;
            usernameTxt.TabStop = false;
            usernameTxt.TextAlign = HorizontalAlignment.Left;
            usernameTxt.TrailingIcon = null;
            usernameTxt.UseSystemPasswordChar = false;
            usernameTxt.TextChanged += usernameTxt_TextChanged;
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loginBtn.AutoSize = false;
            loginBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            loginBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            loginBtn.Depth = 0;
            loginBtn.HighEmphasis = true;
            loginBtn.Icon = null;
            loginBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            loginBtn.Location = new Point(366, 182);
            loginBtn.Margin = new Padding(4, 6, 4, 6);
            loginBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            loginBtn.Name = "loginBtn";
            loginBtn.NoAccentTextColor = Color.Empty;
            loginBtn.Size = new Size(167, 36);
            loginBtn.TabIndex = 10;
            loginBtn.Text = "Login";
            loginBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            loginBtn.UseAccentColor = false;
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_ClickAsync;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 235);
            Controls.Add(loginBtn);
            Controls.Add(materialLabel2);
            Controls.Add(passwordTxt);
            Controls.Add(materialLabel1);
            Controls.Add(usernameTxt);
            KeyPreview = true;
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Padding = new Padding(2, 68, 2, 3);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            KeyPress += LoginForm_KeyPress;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit passwordTxt;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit usernameTxt;
        private ReaLTaiizor.Controls.MaterialButton loginBtn;
        private ErrorProvider errorProvider;
    }
}