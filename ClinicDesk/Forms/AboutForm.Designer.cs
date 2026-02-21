namespace ClinicDesk.Forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            pictureBox1 = new PictureBox();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            label2 = new ReaLTaiizor.Controls.MaterialLabel();
            novaLink = new LinkLabel();
            panel1 = new Panel();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.icon;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 318);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            materialLabel1.Location = new Point(17, 103);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(159, 41);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "ClinicDesk";
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(17, 179);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(292, 23);
            materialLabel2.TabIndex = 5;
            materialLabel2.Text = "Designed by:";
            // 
            // label2
            // 
            label2.Depth = 0;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.Location = new Point(3, 382);
            label2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            label2.Name = "label2";
            label2.Size = new Size(582, 30);
            label2.TabIndex = 3;
            label2.Text = "© 2025-2026 ClinicDesk. All rights reserved.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // novaLink
            // 
            novaLink.AutoSize = true;
            novaLink.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            novaLink.Location = new Point(17, 202);
            novaLink.Name = "novaLink";
            novaLink.Size = new Size(205, 18);
            novaLink.TabIndex = 6;
            novaLink.TabStop = true;
            novaLink.Text = "NOVA for Integrated Solutions";
            novaLink.LinkClicked += novaLink_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(321, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 318);
            panel1.TabIndex = 4;
            // 
            // materialLabel3
            // 
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(17, 351);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(90, 31);
            materialLabel3.TabIndex = 5;
            materialLabel3.Text = "v1.0.0";
            // 
            // AboutForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(588, 415);
            Controls.Add(materialLabel3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(novaLink);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About ClinicDesk";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialLabel label2;
        private LinkLabel novaLink;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
    }
}