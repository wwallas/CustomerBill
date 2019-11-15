using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBill
{
    class IndustrialCustomer:Customer
    {
        //Calculate Peak bill
        decimal FlaratePeak = 76.00m;
        decimal AddKwhIndPeak = 0.065m;
        //decimal KwhPea = Convert.ToDecimal(txtPeaHou.Text);


        // Calculate Off Peak bill

        decimal FlarateOffPeak = 40.00m;
        decimal AddKwhIndOffPeak = 0.028m;
        //decimal KwhOffPea = Convert.ToDecimal(txtOffPeaHou.Text);
        public decimal KwhOffPea
        {
            get { return kwhOffPea; }
        }

    
        private decimal kwhOffPea;

        //Constructor

        public IndustrialCustomer(long account, string customer, char customtype,
                            decimal kwh, decimal charge,
                            decimal flatRate,
                            decimal kwhOff
                            ) : base(account, customer, customtype,
                                 kwh, charge, flatRate)
        {
            kwhOffPea = kwhOff;

            FlaratePeak = 76.00m;
            FlarateOffPeak = 40.00m;

            AddKwhIndPeak = 0.065m;
            AddKwhIndOffPeak = 0.028m;           

        }

        //Methods
        public override string ToString()
        {
            return base.ToString();
        }

        public override string ToFormattedString()
        {

            return base.ToFormattedString();
        }

        public IndustrialCustomer(string fromFile) : base(fromFile)
        {
            char[] delimiters = { '|', ',' };
            string[] tokens = fromFile.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        }

        public override string ToFileString()
        {
            return base.ToFileString();
        }

        public override decimal calculateBill()
        {

            
            if (Kwh >= 0 && Kwh <= 1000)
            {
               return  FlaratePeak;               
            }
            else
            {
                decimal total = ((Kwh - 1000) * AddKwhIndPeak) + FlaratePeak;
                return total + calculateBillOff();
            }
        }
        public  decimal calculateBillOff()
        {

            if (KwhOffPea >= 0 && KwhOffPea <= 1000)
            {
                return FlarateOffPeak;
            }
            else
            {
                decimal totalOff = ((KwhOffPea - 1000) * AddKwhIndOffPeak) + FlarateOffPeak;
                return totalOff;
            }
            
        }
    }
}
