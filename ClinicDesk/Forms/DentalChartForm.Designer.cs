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
            SuspendLayout();
            // 
            // toothChart1
            // 
            toothChart1.Location = new Point(6, 67);
            toothChart1.Name = "toothChart1";
            toothChart1.NumbersFont = new Font("Segoe UI", 10F);
            toothChart1.Size = new Size(750, 250);
            toothChart1.TabIndex = 0;
            toothChart1.Text = "toothChart1";
            // 
            // DentalChartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 743);
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
    }
}