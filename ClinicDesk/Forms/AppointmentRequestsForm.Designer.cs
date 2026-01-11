namespace ClinicDesk.Forms
{
    partial class AppointmentRequestsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentRequestsForm));
            requestsGrd = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)requestsGrd).BeginInit();
            SuspendLayout();
            // 
            // requestsGrd
            // 
            requestsGrd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            requestsGrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestsGrd.Location = new Point(6, 67);
            requestsGrd.Name = "requestsGrd";
            requestsGrd.RowHeadersWidth = 51;
            requestsGrd.Size = new Size(788, 377);
            requestsGrd.TabIndex = 0;
            // 
            // AppointmentRequestsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(requestsGrd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AppointmentRequestsForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointment Requests";
            Load += AppointmentRequestsForm_Load;
            ((System.ComponentModel.ISupportInitialize)requestsGrd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView requestsGrd;
    }
}