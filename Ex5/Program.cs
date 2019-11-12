using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape Triangle1 = new Triangle(5, 6);
            Console.WriteLine(Triangle1.CalculateSurface());

            Shape Rectangle1 = new Rectangle(5, 8);
            Console.WriteLine(Rectangle1.CalculateSurface());

            Shape Square1 = new Square(5);
            Console.WriteLine(Square1.CalculateSurface());

            List<Shape> List = new List<Shape>();
            List.Add(Triangle1);
            List.Add(Rectangle1);
            List.Add(Square1);

            foreach (var shape in List)
            {
                Console.WriteLine(shape.CalculateSurface());
            }

            Console.ReadLine();
        }
    }
}
