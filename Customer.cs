using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBill
{
    class Customer
    {

        public long AccountNo
        {
            get { return accountNo; }
            //set { accountNo = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
        }

        public char CustomerType
        {
            get { return customerType; }
        }

        public decimal Kwh
        { get { return kwh; } }
        public decimal Rate
        { get { return rate; } }

        public decimal ChargeAmount
        {
            get { return chargeAmount; }
            set
            {
               chargeAmount = value;
            }
        }


        //define of fields
        private long accountNo;
        private string customerName;
        private char customerType;
        private decimal kwh;
        private decimal rate;
        public decimal chargeAmount;

        //Define construtors
        public Customer() { }

        public Customer(long account, string customer,char customtype, decimal kwh, decimal rate, decimal charge)
        {
            if (!validateAccountNo(account))
                throw new ArgumentException("Bad  Account Number");
            if (!validateCustomerName(customer))
                throw new ArgumentException("Bad  Customer Name");
            accountNo = account;
            customerName = customer;
            customerType = customtype;
            this.kwh = kwh;
            this.rate = rate;
            chargeAmount = calculateBill();
        }

        //definition methods

        public Customer(string fromfile)
        {
            char[] delimiters = { '|', ',' };
            string[] tokens = fromfile.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            customerName = tokens[0];
            customerType =char.Parse( tokens[1]);
            accountNo = long.Parse(tokens[2]);
            kwh = decimal.Parse(tokens[3]);
            chargeAmount = decimal.Parse(tokens[4]);

        }
        public override string ToString()
        {
            return AccountNo + ": " + CustomerName.ToString() + ", " + ChargeAmount;
        }

        //Calculate power bill
        public virtual decimal calculateBill()
        {
            ChargeAmount= rate * kwh;
            return ChargeAmount;
        }

        public virtual string ToFormattedString()
        {
            //chargeAmount = calculateBill();
            string theString = "";
            theString += $"{customerName,-30}";
            theString += $"{customerType,1}";
            theString += $"{accountNo,12}";
            theString += $"{kwh,6:c2}";
            theString += $"{chargeAmount,10:c2}";
            return theString;
        }

        public virtual string ToFileString()
        {
            string theString = "";
            theString += $"{customerName}|";
            theString += $"{customerType}|";
            theString += $"{accountNo}|";
            theString += $"{kwh}|";
            theString += $"{chargeAmount}";
            return theString;
        }

        //Private (Helper) Methods

        private bool validateCustomerName(string customer)
        {
            if (!((customer != null) && (customer.Length > 0)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validateAccountNo(long account)
        {
            if (!((account >= 100000) && (account <= 999999999)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}

