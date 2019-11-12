using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
     public interface IOrder
    {
        
         String PlaceOrder();
          String DeleteOrder();
    }
    public enum ProducerType
    {
        Skoda, Ford, AlfaRomeo, Fiat, Volvo, Audi, Opel
    };
}
