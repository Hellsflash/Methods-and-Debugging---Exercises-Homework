using System;

namespace _11.Geometry_Calculator
{
   public class Program
    {
       public static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure=="triangle")
            {
               double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:f2}", TriangleArea(side,height));
            }
            else if (figure=="square")
            {
                double side = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:f2}", SquareArea(side));
            }
            else if (figure=="rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:f2}", RectangleArea(width,height));
            }
            else if (figure=="circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}",CircleArea(radius));
            }

        }
        public static double TriangleArea(double side, double height)
        {
            return  (side * height)/2;
            
        }
        public static double SquareArea(double side)
        {
            return side * side;
        }
        public static double RectangleArea(double width, double height)
        {
            return width * height;
        }
        public static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}