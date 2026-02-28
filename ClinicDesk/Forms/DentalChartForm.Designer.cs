namespace ClinicDesk.Forms
{
    partial class DentalChartForm
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
            toothChart1 = new ClinicDesk.Controls.ToothChart();
            saveBtn = new ReaLTaiizor.Controls.MaterialButton();
            nameLbl = new ReaLTaiizor.Controls.MaterialLabel();
            contentLbl = new ReaLTaiizor.Controls.MaterialLabel();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // toothChart1
            // 
            toothChart1.IsReadonly = false;
            toothChart1.Location = new Point(6, 67);
            toothChart1.Name = "toothChart1";
            toothChart1.NumbersFont = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toothChart1.Size = new Size(500, 500);
            toothChart1.TabIndex = 0;
            toothChart1.HoveredToothChanged += toothChart1_HoveredToothChanged;
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
            saveBtn.Location = new Point(735, 577);
            saveBtn.Margin = new Padding(4, 6, 4, 6);
            saveBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            saveBtn.Name = "saveBtn";
            saveBtn.NoAccentTextColor = Color.Empty;
            saveBtn.Size = new Size(158, 36);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "Close";
            saveBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            saveBtn.UseAccentColor = false;
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // nameLbl
            // 
            nameLbl.Depth = 0;
            nameLbl.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            nameLbl.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            nameLbl.Location = new Point(17, 14);
            nameLbl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(348, 40);
            nameLbl.TabIndex = 2;
            nameLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // contentLbl
            // 
            contentLbl.Depth = 0;
            contentLbl.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            contentLbl.Location = new Point(17, 75);
            contentLbl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            contentLbl.Name = "contentLbl";
            contentLbl.Size = new Size(348, 390);
            contentLbl.TabIndex = 3;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(nameLbl);
            materialCard1.Controls.Add(contentLbl);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(511, 78);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(382, 479);
            materialCard1.TabIndex = 4;
            // 
            // DentalChartForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(900, 622);
            Controls.Add(materialCard1);
            Controls.Add(saveBtn);
            Controls.Add(toothChart1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DentalChartForm";
            ShowInTaskbar = false;
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dental Chart";
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Controls.ToothChart toothChart1;
        private ReaLTaiizor.Controls.MaterialButton saveBtn;
        private ReaLTaiizor.Controls.MaterialLabel nameLbl;
        private ReaLTaiizor.Controls.MaterialLabel contentLbl;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
    }
}