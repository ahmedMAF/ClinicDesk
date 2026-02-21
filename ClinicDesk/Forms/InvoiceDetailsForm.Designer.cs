namespace ClinicDesk.Forms
{
    partial class InvoiceDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceDetailsForm));
            paymentsGrd = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)paymentsGrd).BeginInit();
            SuspendLayout();
            // 
            // paymentsGrd
            // 
            paymentsGrd.AllowUserToAddRows = false;
            paymentsGrd.AllowUserToDeleteRows = false;
            paymentsGrd.AllowUserToOrderColumns = true;
            paymentsGrd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            paymentsGrd.BackgroundColor = Color.White;
            paymentsGrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paymentsGrd.Location = new Point(6, 67);
            paymentsGrd.Name = "paymentsGrd";
            paymentsGrd.ReadOnly = true;
            paymentsGrd.RowHeadersWidth = 51;
            paymentsGrd.Size = new Size(1030, 377);
            paymentsGrd.TabIndex = 6;
            paymentsGrd.CellMouseClick += appointmentsGrd_CellMouseClick;
            // 
            // InvoiceDetailsForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1042, 450);
            Controls.Add(paymentsGrd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InvoiceDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Details";
            ((System.ComponentModel.ISupportInitialize)paymentsGrd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView paymentsGrd;
    }
}