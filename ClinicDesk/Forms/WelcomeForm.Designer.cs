namespace ClinicDesk.Forms
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            docBtn = new Button();
            secretBtn = new Button();
            allBtn = new Button();
            SuspendLayout();
            // 
            // docBtn
            // 
            docBtn.Location = new Point(6, 67);
            docBtn.Name = "docBtn";
            docBtn.Size = new Size(159, 29);
            docBtn.TabIndex = 0;
            docBtn.Text = "Doctor";
            docBtn.UseVisualStyleBackColor = true;
            docBtn.Click += docBtn_Click;
            // 
            // secretBtn
            // 
            secretBtn.Location = new Point(6, 102);
            secretBtn.Name = "secretBtn";
            secretBtn.Size = new Size(159, 29);
            secretBtn.TabIndex = 1;
            secretBtn.Text = "Secretary";
            secretBtn.UseVisualStyleBackColor = true;
            secretBtn.Click += secretBtn_Click;
            // 
            // allBtn
            // 
            allBtn.Location = new Point(6, 137);
            allBtn.Name = "allBtn";
            allBtn.Size = new Size(159, 29);
            allBtn.TabIndex = 3;
            allBtn.Text = "All In One";
            allBtn.UseVisualStyleBackColor = true;
            allBtn.Click += allBtn_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 528);
            Controls.Add(allBtn);
            Controls.Add(secretBtn);
            Controls.Add(docBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button docBtn;
        private Button secretBtn;
        private Button allBtn;
    }
}
