using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInterfaceModifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(5.0);
            Console.WriteLine("Area of the square: " + square.CalculateArea());

            Circle circle = new Circle(3.0);
            Console.WriteLine("Area of the circle: " + circle.CalculateArea());
            Console.ReadKey();
        }
    }
}
