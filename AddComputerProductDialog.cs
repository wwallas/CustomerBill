using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddComputerDialogTest
{
 
    public partial class AddComputerProductDialog : Form
    {
        public long     CustomerNo;
        public string   CustomerName;        
        public decimal  CustomerKwh;
        public decimal CustomerKwhOff;



        private bool haveValidCustomerNo = false;
        private bool haveValidCustomerName = false;
        private bool haveValidCustomerKwh = false;
        private bool haveValidCustomerKwhOff = false;

        public AddComputerProductDialog()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
           
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string badFieldName = null;
            string adviceString = null;
            if (!haveValidCustomerNo)
            {
                badFieldName = "Customer No";
                adviceString = "Customer No must be numeric, at lease 6 digits but no  more than 10";
            }            
            else if (!haveValidCustomerName)
            {
                badFieldName = "Customer Name";
                adviceString = "Must ente the name of the client.";
            }
            else if (!haveValidCustomerKwh)
            {
                badFieldName = "Customer Kwh";
                adviceString = "Kwh must be grater than 0";
            }
            else if (!haveValidCustomerKwhOff)
            {
                badFieldName = "Customer KwhOff";
                adviceString = "Kwh must be grater than 0";
            }

            if (badFieldName != null)
            {
                MessageBox.Show($"Invalid {badFieldName}.\n{adviceString}","Data Entry Error");
                return;
            }
            DialogResult = DialogResult.OK;
                     
        }

        private void CustomerNoTextBox_TextChanged(object sender, EventArgs e)
        {
            haveValidCustomerNo = false;

            if (long.TryParse(customerNoTextBox.Text.Trim(), out CustomerNo))
            {
                if ((CustomerNo >= 100000) && (CustomerNo <= 999999999))
                {
                    haveValidCustomerNo = true;

                }
            }
        }

        private void CustomerNameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (customerNameTextbox.Text.Trim().Length == 0)
            {
                haveValidCustomerName = false;
            }
            else
            {
                haveValidCustomerName = true;
                CustomerName = customerNameTextbox.Text.Trim();

            }
        }

        private void CustomerKwhTextbox_TextChanged(object sender, EventArgs e)
        {
            haveValidCustomerKwh = false;

            if (decimal.TryParse(customerKwhTextbox.Text.Trim(), out CustomerKwh))
            {
                if (CustomerKwh >= 0)
                {
                    haveValidCustomerKwh = true;
                }
            }
        }

        private void CustomerKwhOffTextbox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(customerKwhOffTextbox.Text.Trim(), out CustomerKwhOff))
            {
                if (CustomerKwhOff >= 0)
                {
                    haveValidCustomerKwhOff = true;
                }
            }
        }
    }
}

