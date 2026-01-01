namespace ClinicDesk.Controls
{
    partial class Tutorial
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
            nextBtn = new ReaLTaiizor.Controls.MaterialButton();
            titleLbl = new ReaLTaiizor.Controls.MaterialLabel();
            layout = new FlowLayoutPanel();
            textLbl = new ReaLTaiizor.Controls.MaterialLabel();
            skipBtn = new LinkLabel();
            layout.SuspendLayout();
            SuspendLayout();
            // 
            // nextBtn
            // 
            nextBtn.AutoSize = false;
            nextBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nextBtn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            nextBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            nextBtn.Depth = 0;
            nextBtn.HighEmphasis = true;
            nextBtn.Icon = null;
            nextBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            nextBtn.Location = new Point(4, 49);
            nextBtn.Margin = new Padding(4, 6, 4, 6);
            nextBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            nextBtn.Name = "nextBtn";
            nextBtn.NoAccentTextColor = Color.Empty;
            nextBtn.Size = new Size(119, 36);
            nextBtn.TabIndex = 2;
            nextBtn.Text = "Next";
            nextBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            nextBtn.UseAccentColor = false;
            nextBtn.UseVisualStyleBackColor = true;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Depth = 0;
            titleLbl.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            titleLbl.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            titleLbl.Location = new Point(3, 0);
            titleLbl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(41, 24);
            titleLbl.TabIndex = 4;
            titleLbl.Text = "Title";
            // 
            // layout
            // 
            layout.Controls.Add(titleLbl);
            layout.Controls.Add(textLbl);
            layout.Controls.Add(nextBtn);
            layout.Controls.Add(skipBtn);
            layout.FlowDirection = FlowDirection.TopDown;
            layout.Location = new Point(234, 0);
            layout.Name = "layout";
            layout.Size = new Size(407, 346);
            layout.TabIndex = 5;
            // 
            // textLbl
            // 
            textLbl.AutoSize = true;
            textLbl.Depth = 0;
            textLbl.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            textLbl.Location = new Point(3, 24);
            textLbl.MaximumSize = new Size(400, 0);
            textLbl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            textLbl.Name = "textLbl";
            textLbl.Size = new Size(32, 19);
            textLbl.TabIndex = 5;
            textLbl.Text = "Text";
            // 
            // skipBtn
            // 
            skipBtn.AutoSize = true;
            skipBtn.Location = new Point(3, 91);
            skipBtn.Name = "skipBtn";
            skipBtn.Size = new Size(37, 20);
            skipBtn.TabIndex = 6;
            skipBtn.TabStop = true;
            skipBtn.Text = "Skip";
            // 
            // Tutorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(layout);
            Name = "Tutorial";
            Size = new Size(708, 346);
            layout.ResumeLayout(false);
            layout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialButton nextBtn;
        private ReaLTaiizor.Controls.MaterialLabel titleLbl;
        private FlowLayoutPanel layout;
        private ReaLTaiizor.Controls.MaterialLabel textLbl;
        private LinkLabel skipBtn;
    }
}
