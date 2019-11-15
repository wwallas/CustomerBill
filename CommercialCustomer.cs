using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBill
{
    class CommercialCustomer: Customer
    {
        // Constants

        // Constants

        decimal CommercialRate = 60m;
        decimal CommercialAddRate = 0.045m;
        // private decimal residentialRate;


        // constructor
        public CommercialCustomer(long account, string customer, char customtype,
                            decimal kwh, decimal charge,
                            decimal residentialRate,
                            decimal residentialAddRate) : base(account, customer, customtype,
                                 kwh, charge, residentialRate)
        {
            if (residentialRate == 0)
            {
                CommercialRate = 60.00m;
                CommercialAddRate = 0.045M;
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

        public CommercialCustomer(string fromFile) : base(fromFile)
        {
            char[] delimiters = { '|', ',' };
            string[] tokens = fromFile.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        }
        public override string ToFileString()
        {
            return base.ToFileString();
        }

        public override decimal calculateBill()
        {//
            if (Kwh >= 0 && Kwh <=1000)
                return CommercialRate;
            else
                ChargeAmount = ((Kwh - 1000) * CommercialAddRate) + CommercialRate; ;
                return ChargeAmount;
        }
    }
}
