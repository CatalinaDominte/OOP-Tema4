using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class IStore : IOrder
    {
        public int Discount{ get; }
        public List<ICar> Order { get; set; }
        public List<ICar> CarsList { get; set; }

        protected string DeliveryTime { get;  }
       

        public IStore(int Discount, string DeliveryTime) 
        {
            this.Discount = Discount;
            this.DeliveryTime = DeliveryTime;
            this.Order = new List<ICar>();
            this.CarsList = new List<ICar>();
        }
       
        public ICar PlaceOrder(ICar x)
        {
            Order.Add(x);
            CarsList.Remove(x);
            Console.WriteLine("Comanda Dvs. a fost plasata: Masina " + x.Type + " "+ x.Model + "va fi livrata in " + DeliveryTime);
            return x;
            
        }
        public ICar DeleteOrder(ICar x)
        {

            Order.Remove(x);
          CarsList.Remove(x);


            Console.WriteLine("Comanda a fost anulata");
            return x;
        }
        public void CalculatePriceAfterDiscount()
        {
            foreach (var price in Order)
            {
                if(Discount==0)
                {
                    int pret = price.Price;
                    Console.WriteLine("Pretul masinii este:" + pret);
                }
                else
                {
                    int pret = price.Price - (price.Price / Discount);
                    Console.WriteLine("Pretul masinii este:" + pret);
                }
                 
            }
        }

        public string PlaceOrder()
        {
            throw new NotImplementedException();
        }

        public string DeleteOrder()
        {
            throw new NotImplementedException();
        }
    }
}
