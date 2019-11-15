using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerData;
using System.Windows.Forms;
using AddComputerDialogTest;
using System.IO;

namespace CustomerBill
{
    public partial class FrmCustBill : Form
    {
        List<Customer> customerData = new List<Customer>();
        public FrmCustBill()
        {
            InitializeComponent();
        }    

       //Assigment 2       

        private Customer createResidentialCustomer()
        {
            // pop a addcomputerdialog. if retyurn is canacle, give up 
            // if return is a dialog 
            AddComputerProductDialog accd = new AddComputerProductDialog();
            DialogResult result;
            result = accd.ShowDialog();

            if (result != DialogResult.OK)
            {
                return null;
            }
            Customer c = new ResidentialCustomer(accd.CustomerNo, accd.CustomerName, 'R', accd.CustomerKwh, 0, 0, 0);

            return c;
        }

        private Customer createCommercialCustomer()
        {
            // pop a addcomputerdialog. if retyurn is canacle, give up 
            // if return is a dialog 
            AddComputerProductDialog accd = new AddComputerProductDialog();
            DialogResult result;
            result = accd.ShowDialog();

            if (result != DialogResult.OK)
            {
                return null;
            }
            Customer c = new CommercialCustomer(accd.CustomerNo, accd.CustomerName, 'C', accd.CustomerKwh, 0, 0, 0);

            return c;
        }
        private Customer createIndustrialCustomer()
        {
            // pop a addcomputerdialog. if retyurn is canacle, give up 
            // if return is a dialog 
            AddComputerProductDialog accd = new AddComputerProductDialog();
            DialogResult result;
            result = accd.ShowDialog();

            if (result != DialogResult.OK)
            {
                return null;
            }
            Customer c = new IndustrialCustomer(accd.CustomerNo, accd.CustomerName, 'I', accd.CustomerKwh, 0, 0, 0);

            return c;
        }
        private void ButtonAddCustomer_Click(object sender, EventArgs e)
        {
            //Call panel depending of Customer Type 
            Customer c = new Customer();

            // Determine the type of product being added swith based on that 
            // calling the appropiate dialog  to get the necessary ino
            // create the object and add it to our inventory list and to the display 
            // list

            if (cmbCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("Must select a product type first before adding");
                return;
            }
            switch (cmbCustomers.SelectedIndex)
            {
                case 0:                                    
                    c = createResidentialCustomer();
                    break;
                case 1:
                    c = createCommercialCustomer();
                    break;
                case 2:                   
                    c = createIndustrialCustomer();
                    break;

                default:
                    MessageBox.Show("This option is not enable");
                    return;
            }

            if (c != null)
            {
                customerData.Add(c);              
                CustomerListBox.Items.Add(c.ToFormattedString());
                TotalCustomLabel.Text = Convert.ToString(customerData.Count);
                decimal total = customerData.Sum(item => item.ChargeAmount);
                lblSumAll.Text = Convert.ToString(total);

            }

        }
        

        private string customerTypeString(Customer c)
        {
            if (c is ResidentialCustomer)
            {
                return "Residential";
            }
            else if (c is CommercialCustomer)
            { return "Commercial"; }
            else if (c is IndustrialCustomer)
            { return "Industrial"; }
            else
            { return "UNKNOWN"; }

        }
        private void LoadCust()
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //let the user save the file 
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Save file Customer data";
            //sfd.DefaultExt = ();
            sfd.Filter = "Customer Data Files|*.pil|Text files|*.txt|All Files|*.*";
            sfd.FilterIndex = 1;

            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


            DialogResult result = sfd.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            // all inside a try/catch

            // open a stream writer on 'customerlist.txt' on the desktop
            // for each product in my inventory run the 


            try
            {

                // string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/productlist.txt";
                StreamWriter output = new StreamWriter(sfd.FileName);
                foreach (Customer c in customerData)
                {
                    output.WriteLine(customerTypeString(c));
                    output.WriteLine(c.ToFileString());
                }
                output.Close();
            }
            catch (Exception excp)
            {
                MessageBox.Show($"File did not write. {excp.Message}");
                return;
            }

            MessageBox.Show($"Customers have been saved in {sfd.FileName}");
        }

        private void BtnLoadData_Click(object sender, EventArgs e)
        {
            //let the user pick the file to open

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select a customer list";

            ofd.Filter = "Customer Data Files|*.pil|Text files|*.txt|All Files|*.*";
            ofd.FilterIndex = 1;

            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = ofd.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            // all inside a try/catch

            // open a stream writer on 'customlist.txt' on the desktop
            // for each line in the file call the construtor that takes single string
            // and get a custom object back  Add that object to my list and to the display list
            // close the file
            Customer c = null;
            try
            {
                //string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/productlist.txt";

                StreamReader input = new StreamReader(ofd.FileName);
                while (!input.EndOfStream)
                {
                    string customerType = input.ReadLine();
                    switch (customerType)
                    {
                        case "Residential":
                            c = new ResidentialCustomer(input.ReadLine());
                            break;
                        case "Commercial":
                            c = new CommercialCustomer(input.ReadLine());
                            break;
                        default:
                            MessageBox.Show("Unknown customer in the file");
                            break;

                    }
                    //string lineFromfile = input.ReadLine();
                    //Product p = new Product(lineFromfile);
                    if (c != null)
                    {
                        customerData.Add(c);
                        CustomerListBox.Items.Add(c.ToFormattedString());
                    }

                }
                input.Close();
            }
            catch (Exception excp)
            {
                MessageBox.Show($"File did not Read. {excp.Message}");
                return;
            }

            MessageBox.Show($"Customer have been load from customeer.txt");
        }
    }
}
