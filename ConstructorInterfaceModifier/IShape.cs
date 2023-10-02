using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInterfaceModifier
{
    public interface IShape
    {
        double CalculateArea();
    }

    // Implementing the IShape interface with a Square class
    public class Square : IShape
    {
        public double SideLength { get; set; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        public double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }

    // Implementing the IShape interface with a Circle class
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
