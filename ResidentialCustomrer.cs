using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBill
{
    class ResidentialCustomer: Customer
    {
        // Constants

        decimal ResidentialRate =6m;
        decimal ResidentialAddRate = 0.052m;
        // private decimal residentialRate;


        // constructor
        public ResidentialCustomer(long account, string customer, char customtype,
                            decimal kwh,decimal charge,
                            decimal residentialRate,
                            decimal residentialAddRate) : base(account, customer, customtype,
                                 kwh, charge, residentialRate)
        {
            if (residentialRate==0)
            {
                ResidentialRate = 6.00m;
                ResidentialAddRate = 0.052M;
            }
               
        }
        
        public override string ToString()
        {
            return base.ToString();
        }

        public override string ToFormattedString()
        {
            
            return base.ToFormattedString();
        }

        public ResidentialCustomer(string fromFile) : base(fromFile)
        {
            char[] delimiters = { '|',',' };
            string[] tokens = fromFile.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            
        }
        public override string ToFileString()
        {
            return base.ToFileString();
        }

        public override decimal calculateBill()
        {            
            if (Kwh == 0)
                return ResidentialRate; 
            else
                ChargeAmount= ResidentialRate + (ResidentialAddRate * Kwh);
                return ChargeAmount;
        }
    }
}
