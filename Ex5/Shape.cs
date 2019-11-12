using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    abstract class Shape
    {
        protected double Width {get;set;}
        protected double Height { get; set; }
        protected Shape(double Width, double Height)
        {
            this.Height = Height;
            this.Width = Width;
        }
        public abstract double CalculateSurface();
       
    }
    
}
