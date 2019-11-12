using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    abstract class Acount
    {
        public AcountsType Type { get; set; }
        protected decimal Balance { get; set; }
        protected decimal InterestRate { get; set; }
        
        protected Acount (AcountsType Type, decimal Balance, decimal InterestRate)//, DateTime Date)
        {
            this.Type = Type;
            this.Balance = Balance;
            this.InterestRate = InterestRate;
            //this.Date = Date;
        }
      
        public virtual void Deposit(decimal amount)
        {
            this.Balance=this.Balance + amount;
        }
        public virtual void Withdrow (decimal amount)
        {
            this.Balance = this.Balance - amount;
        }

        public virtual void Interest(int month)
        {
            decimal interest= month * InterestRate;
           
        }


    }
    public enum AcountsType
    {
        Deposit, Loan, Mortgage
    }
        

}
