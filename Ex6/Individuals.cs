using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Individuals : Customers
    {
        public Individuals(string Name, AcountsType Type, decimal Balance, decimal InterestRate) : base(Name, Type, Balance, InterestRate)
        {

        }


        public override void Interest(int month)

        {
            if (AcountsType.Loan == Type)
            {
                if (month <= 3)
                {
                    decimal interest = 0;
                    Console.WriteLine(Name + " -The interest amount for this acount is: " + interest);
                }
                else
                {
                    decimal interest = (month-3) * InterestRate;
                    Console.WriteLine(Name + " -The interest amount for this acount is: " + interest);
                }
            }
            if (AcountsType.Mortgage == Type)
            {
                if (month <= 6)
                {
                    decimal interest = 0;
                    Console.WriteLine(Name + " -The interest amount for this acount is: " + interest);
                }
                else
                {
                    decimal interest = (month - 6) * InterestRate;
                    Console.WriteLine(Name + " -The interest amount for this acount is: " + interest);
                }
            }
            if (Type == AcountsType.Deposit)
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
