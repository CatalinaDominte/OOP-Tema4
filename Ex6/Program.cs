using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Acount VasilescuAndreea = new Individuals("Vasilescu Maria", AcountsType.Deposit,189, 5 );
            Acount VasilescuAndreea2 = new Individuals("Vasilescu Andreea", AcountsType.Loan, 1000, 8);
            Acount DevSoftSA = new Companies("DevSoftSA", AcountsType.Mortgage, 10000, 10);
            //DevSoftSA.Interest(15);

            //VasilescuAndreea.Interest(3);
            // VasilescuAndreea2.Interest(10);
            VasilescuAndreea.Deposit(15000);
            // VasilescuAndreea2.Withdrow(50);
            VasilescuAndreea.Withdrow(200);


            Console.ReadLine();
        }
        
    }
    
}
