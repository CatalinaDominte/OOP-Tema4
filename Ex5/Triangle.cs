using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Triangle:Shape
    {
        public Triangle(double Width, double Height):base(Width, Height)
        {
            this.Height = Height;
            this.Width = Width;
        }
        public override double CalculateSurface()
        {
            return Height * Width/2;
        }
    }
}
