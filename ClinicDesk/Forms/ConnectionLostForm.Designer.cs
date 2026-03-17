namespace ClinicDesk.Forms
{
    partial class ConnectionLostForm
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
            pictureBox1 = new PictureBox();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            exitBtn = new ReaLTaiizor.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.DisconnectedLarge;
            pictureBox1.Location = new Point(6, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            materialLabel1.Location = new Point(153, 6);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(394, 41);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "No Connection!";
            materialLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(153, 47);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(394, 71);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "The connection to the server is lost, it will be restored automatically when the server is availiable again, try to check the internet connection.";
            // 
            // exitBtn
            // 
            exitBtn.AutoSize = false;
            exitBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            exitBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            exitBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            exitBtn.Depth = 0;
            exitBtn.HighEmphasis = true;
            exitBtn.Icon = null;
            exitBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            exitBtn.Location = new Point(153, 124);
            exitBtn.Margin = new Padding(4, 6, 4, 6);
            exitBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            exitBtn.Name = "exitBtn";
            exitBtn.NoAccentTextColor = Color.Empty;
            exitBtn.Size = new Size(198, 45);
            exitBtn.TabIndex = 18;
            exitBtn.Text = "Close the App";
            exitBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            exitBtn.UseAccentColor = false;
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // ConnectionLostForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(553, 186);
            ControlBox = false;
            Controls.Add(exitBtn);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(pictureBox1);
            Name = "ConnectionLostForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Sizable = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Connection Lost";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialButton exitBtn;
    }
}