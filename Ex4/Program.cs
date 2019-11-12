using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar FordFocus = new ICar(15000, ProducerType.Ford, "Focus-2015");
            ICar FordFiesta = new ICar(14000, ProducerType.Ford, "Fiesta-2013");
            ICar AudiA4 = new ICar(18000, ProducerType.Audi, "Audi-2014");
            ICar OpelAstra = new ICar(10000, ProducerType.Opel, "Astra-2015");


            IStore FordStore = new IStore(0, "4 saptamani");
            FordStore.CarsList.Add(FordFocus);
            FordStore.CarsList.Add(FordFiesta);
            FordStore.CarsList.Add(AudiA4);
            FordStore.CarsList.Add(OpelAstra);

            
            FordStore.PlaceOrder(FordFocus);
            FordStore.CalculatePriceAfterDiscount();
            FordStore.DeleteOrder(FordFocus);
           

            IStore SkodaStore = new IStore(15, "3 saptamani");
            SkodaStore.CalculatePriceAfterDiscount();
            SkodaStore.CarsList.Add(FordFocus);
            SkodaStore.CarsList.Add(FordFiesta);
            SkodaStore.CarsList.Add(AudiA4);
            SkodaStore.CarsList.Add(OpelAstra);
            SkodaStore.PlaceOrder(FordFocus);
            SkodaStore.CalculatePriceAfterDiscount();
            Console.ReadLine();
        }
    }
}
