using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Companies:Customers
    {

        public Companies(string Name, AcountsType Type, decimal Balance, decimal InterestRate ) : base(Name, Type, Balance, InterestRate)
        {

        }
        public override void Interest(int month)
            
        {
            if (AcountsType.Loan==Type)
            {
                if (month <= 2)
                {
                    decimal interest = 0;
                    Console.WriteLine(Name+" -The interest amount for this acount is: " + interest);
                }
                else
                {
                    decimal interest = (month-2) * InterestRate;
                    Console.WriteLine(Name + " -The interest amount for this acount is: " + interest);
                }
            }
            if (AcountsType.Mortgage == Type)
            {
                if (month <= 12)
                {
                    decimal interest = (decimal)0.5*(month * InterestRate);
                    Console.WriteLine(Name + " -The interest amount for this acount is: " + interest);
                }
                else
                {
                    decimal interest = ((month - 12) * InterestRate) + ((decimal)0.5 * 12 * InterestRate);
                    Console.WriteLine(Name + " -The interest amount for this acount is: " + interest);
                }
            }
            if (AcountsType.Deposit==Type)
            {
                if (Balance <= 1000)
                {
                    decimal interest = 0;
                    Console.WriteLine(Name + " -The interest amount for this acount is: " + interest);
                }
                else
                {
                    decimal interest = month * InterestRate;
                    Console.WriteLine(Name + " -The interest amount for this acount is: " + interest);
                }
            }
            

            
        }
    }
}
