using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Square:Shape
    {
        public Square(double Width) : base(Width, Width)
        {
            
            this.Width = Width;
        }
        public override double CalculateSurface()
        {
            return Height * Height;
        }
    }
}
