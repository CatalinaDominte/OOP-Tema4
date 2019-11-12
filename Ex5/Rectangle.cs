using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Rectangle:Shape
    {
        public Rectangle(double Width, double Height) : base(Width, Height)
        {
            this.Height = Height;
            this.Width = Width;
        }
        public override double CalculateSurface()
        {
            return Height * Width;
        }
    }
}
