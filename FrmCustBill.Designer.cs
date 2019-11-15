namespace CustomerBill
{
    partial class FrmCustBill
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.pnlCmbCustTyp = new System.Windows.Forms.Panel();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.CustomerListBox = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.TotalCustomersLabel = new System.Windows.Forms.Label();
            this.TotalCustomLabel = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblSumAll = new System.Windows.Forms.Label();
            this.pnlCmbCustTyp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Location = new System.Drawing.Point(305, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(243, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Customer Bill Application";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Items.AddRange(new object[] {
            "Residential",
            "Commercial",
            "Industrial"});
            this.cmbCustomers.Location = new System.Drawing.Point(20, 17);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(163, 21);
            this.cmbCustomers.TabIndex = 1;
            this.cmbCustomers.Text = "Select Customer Type";
            
            // 
            // pnlCmbCustTyp
            // 
            this.pnlCmbCustTyp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCmbCustTyp.Controls.Add(this.buttonAddCustomer);
            this.pnlCmbCustTyp.Controls.Add(this.cmbCustomers);
            this.pnlCmbCustTyp.Location = new System.Drawing.Point(12, 66);
            this.pnlCmbCustTyp.Name = "pnlCmbCustTyp";
            this.pnlCmbCustTyp.Size = new System.Drawing.Size(200, 100);
            this.pnlCmbCustTyp.TabIndex = 5;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Location = new System.Drawing.Point(75, 56);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(103, 23);
            this.buttonAddCustomer.TabIndex = 7;
            this.buttonAddCustomer.Text = "Add Customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.ButtonAddCustomer_Click);
            // 
            // CustomerListBox
            // 
            this.CustomerListBox.FormattingEnabled = true;
            this.CustomerListBox.Location = new System.Drawing.Point(258, 66);
            this.CustomerListBox.Name = "CustomerListBox";
            this.CustomerListBox.Size = new System.Drawing.Size(506, 121);
            this.CustomerListBox.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(267, 194);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Data";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(267, 224);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData.TabIndex = 8;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.BtnLoadData_Click);
            // 
            // TotalCustomersLabel
            // 
            this.TotalCustomersLabel.AutoSize = true;
            this.TotalCustomersLabel.Location = new System.Drawing.Point(416, 203);
            this.TotalCustomersLabel.Name = "TotalCustomersLabel";
            this.TotalCustomersLabel.Size = new System.Drawing.Size(83, 13);
            this.TotalCustomersLabel.TabIndex = 9;
            this.TotalCustomersLabel.Text = "Total Customers";
            // 
            // TotalCustomLabel
            // 
            this.TotalCustomLabel.AutoSize = true;
            this.TotalCustomLabel.Location = new System.Drawing.Point(515, 203);
            this.TotalCustomLabel.Name = "TotalCustomLabel";
            this.TotalCustomLabel.Size = new System.Drawing.Size(13, 13);
            this.TotalCustomLabel.TabIndex = 10;
            this.TotalCustomLabel.Text = "0";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(419, 234);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(90, 13);
            this.lblSum.TabIndex = 11;
            this.lblSum.Text = "Summ all charges";
            // 
            // lblSumAll
            // 
            this.lblSumAll.AutoSize = true;
            this.lblSumAll.Location = new System.Drawing.Point(515, 234);
            this.lblSumAll.Name = "lblSumAll";
            this.lblSumAll.Size = new System.Drawing.Size(13, 13);
            this.lblSumAll.TabIndex = 12;
            this.lblSumAll.Text = "0";
            // 
            // FrmCustBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 360);
            this.Controls.Add(this.lblSumAll);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.TotalCustomLabel);
            this.Controls.Add(this.TotalCustomersLabel);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.CustomerListBox);
            this.Controls.Add(this.pnlCmbCustTyp);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmCustBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Bill";
            this.pnlCmbCustTyp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Panel pnlCmbCustTyp;
        private System.Windows.Forms.ListBox CustomerListBox;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Label TotalCustomersLabel;
        private System.Windows.Forms.Label TotalCustomLabel;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblSumAll;
    }
}

