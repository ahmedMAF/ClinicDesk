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
            SuspendLayout();
            // 
            // toothChart1
            // 
            toothChart1.Location = new Point(6, 67);
            toothChart1.Name = "toothChart1";
            toothChart1.NumbersFont = new Font("Segoe UI", 10F);
            toothChart1.Size = new Size(880, 520);
            toothChart1.TabIndex = 0;
            toothChart1.Text = "toothChart1";
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
            saveBtn.Location = new Point(735, 596);
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
            // DentalChartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 645);
            Controls.Add(saveBtn);
            Controls.Add(toothChart1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DentalChartForm";
            ShowInTaskbar = false;
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dental Chart";
            ResumeLayout(false);
        }

        #endregion

        private Controls.ToothChart toothChart1;
        private ReaLTaiizor.Controls.MaterialButton saveBtn;
    }
}