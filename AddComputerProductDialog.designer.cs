namespace AddComputerDialogTest
{
    partial class AddComputerProductDialog
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
            this.AddButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextbox = new System.Windows.Forms.TextBox();
            this.customerNoLabel = new System.Windows.Forms.Label();
            this.customerNoTextBox = new System.Windows.Forms.TextBox();
            this.customerKwhLabel = new System.Windows.Forms.Label();
            this.customerKwhTextbox = new System.Windows.Forms.TextBox();
            this.customerKwhOffTextbox = new System.Windows.Forms.TextBox();
            this.lblKwhOff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(199, 150);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add ";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(118, 150);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.Location = new System.Drawing.Point(12, 48);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(100, 25);
            this.customerNameLabel.TabIndex = 2;
            this.customerNameLabel.Text = "Customer Name: ";
            this.customerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customerNameTextbox
            // 
            this.customerNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerNameTextbox.Location = new System.Drawing.Point(118, 48);
            this.customerNameTextbox.Name = "customerNameTextbox";
            this.customerNameTextbox.Size = new System.Drawing.Size(167, 20);
            this.customerNameTextbox.TabIndex = 2;
            this.customerNameTextbox.TextChanged += new System.EventHandler(this.CustomerNameTextbox_TextChanged);
            // 
            // customerNoLabel
            // 
            this.customerNoLabel.Location = new System.Drawing.Point(12, 23);
            this.customerNoLabel.Name = "customerNoLabel";
            this.customerNoLabel.Size = new System.Drawing.Size(100, 25);
            this.customerNoLabel.TabIndex = 1;
            this.customerNoLabel.Text = "Account No.: ";
            this.customerNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customerNoTextBox
            // 
            this.customerNoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerNoTextBox.Location = new System.Drawing.Point(118, 22);
            this.customerNoTextBox.Name = "customerNoTextBox";
            this.customerNoTextBox.Size = new System.Drawing.Size(103, 20);
            this.customerNoTextBox.TabIndex = 1;
            this.customerNoTextBox.TextChanged += new System.EventHandler(this.CustomerNoTextBox_TextChanged);
            // 
            // customerKwhLabel
            // 
            this.customerKwhLabel.Location = new System.Drawing.Point(12, 73);
            this.customerKwhLabel.Name = "customerKwhLabel";
            this.customerKwhLabel.Size = new System.Drawing.Size(100, 25);
            this.customerKwhLabel.TabIndex = 2;
            this.customerKwhLabel.Text = "Kwh: ";
            this.customerKwhLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customerKwhTextbox
            // 
            this.customerKwhTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerKwhTextbox.Location = new System.Drawing.Point(118, 75);
            this.customerKwhTextbox.Name = "customerKwhTextbox";
            this.customerKwhTextbox.Size = new System.Drawing.Size(103, 20);
            this.customerKwhTextbox.TabIndex = 3;
            this.customerKwhTextbox.TextChanged += new System.EventHandler(this.CustomerKwhTextbox_TextChanged);
            // 
            // customerKwhOffTextbox
            // 
            this.customerKwhOffTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerKwhOffTextbox.Location = new System.Drawing.Point(118, 101);
            this.customerKwhOffTextbox.Name = "customerKwhOffTextbox";
            this.customerKwhOffTextbox.Size = new System.Drawing.Size(103, 20);
            this.customerKwhOffTextbox.TabIndex = 3;
            this.customerKwhOffTextbox.TextChanged += new System.EventHandler(this.CustomerKwhOffTextbox_TextChanged);
            // 
            // lblKwhOff
            // 
            this.lblKwhOff.Location = new System.Drawing.Point(12, 96);
            this.lblKwhOff.Name = "lblKwhOff";
            this.lblKwhOff.Size = new System.Drawing.Size(100, 25);
            this.lblKwhOff.TabIndex = 2;
            this.lblKwhOff.Text = "KwhOff: ";
            this.lblKwhOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddComputerProductDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 219);
            this.Controls.Add(this.customerKwhOffTextbox);
            this.Controls.Add(this.customerKwhTextbox);
            this.Controls.Add(this.lblKwhOff);
            this.Controls.Add(this.customerKwhLabel);
            this.Controls.Add(this.customerNoTextBox);
            this.Controls.Add(this.customerNoLabel);
            this.Controls.Add(this.customerNameTextbox);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.AddButton);
            this.Name = "AddComputerProductDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Customer Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTextbox;
        private System.Windows.Forms.Label customerNoLabel;
        private System.Windows.Forms.TextBox customerNoTextBox;
        private System.Windows.Forms.Label customerKwhLabel;
        private System.Windows.Forms.TextBox customerKwhTextbox;
        private System.Windows.Forms.TextBox customerKwhOffTextbox;
        private System.Windows.Forms.Label lblKwhOff;
    }
}