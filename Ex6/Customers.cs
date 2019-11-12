using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    abstract class Customers:Acount
    {
        protected string Name { get; set; }


        public Customers(string Name, AcountsType Type, decimal Balance, decimal InterestRate) : base(Type, Balance, InterestRate)
        {
            this.Name = Name;
            this.Type = Type;
            this.Balance = Balance;
            this.InterestRate = InterestRate;
            
        }
        public override void Deposit(decimal amount)
        {
            this.Balance = this.Balance + amount;
            Console.WriteLine("Your balance is: " + Balance);
        }

        public override void Withdrow(decimal amount)
        {
            if (AcountsType.Deposit==Type)
            {
                this.Balance = this.Balance - amount;
                Console.WriteLine("Your balance is: " + Balance);
            }
            else
            {
                Console.WriteLine("Your can not make this withdrawal operation!");
            }
            
        }
        public override void Interest(int month)
        {
            if(Type == AcountsType.Deposit)
            {
                if(Balance<=1000)
                {
                    decimal interest = 0;
                    Console.WriteLine("You Interest Rate is " + interest);
                }
            }
            else
            {
                decimal interest = month * InterestRate;
                Console.WriteLine("You Interest Rate is: -" + interest);
            }
            }
        }
    }
    


