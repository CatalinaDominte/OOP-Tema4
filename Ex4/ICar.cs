using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
     class ICar
    {
        public ProducerType Type { get; set; }
        public int Price { get; set; }
        public string Model { get; set; }

        public ICar(int Price, ProducerType Type, string Model)
        {
            this.Price = Price;
            this.Type = Type;
            this.Model = Model;
        }
    }
}
