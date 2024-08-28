using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises.Exercise2
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double GetArea() => Width * Height;
    }

    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public override double GetArea() => 0.5 * Base * Height;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle { Width = 5, Height = 10 };
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

            Triangle triangle = new Triangle { Base = 5, Height = 10 };
            Console.WriteLine($"Triangle Area: {triangle.GetArea()}");
        }
    }
}
