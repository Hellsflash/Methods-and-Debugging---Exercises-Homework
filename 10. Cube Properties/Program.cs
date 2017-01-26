using System;

namespace _10.Cube_Properties
{
  public class Program
    {
        public static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            if (parameter == "face")
            {
                double result = Math.Sqrt((side * side)*2);
                Console.WriteLine("{0:f2}", result);
            }
            else if (parameter == "space")
            {
                double result = Math.Sqrt((side*side )*3);
                Console.WriteLine("{0:f2}", result);
            }
            else if (parameter == "volume")
            {
                double result = side * side * side;
                Console.WriteLine("{0:f2}", result);
            }
            else if (parameter=="area")
            {
                double result = (side * side) * 6;
                Console.WriteLine("{0:f2}",result);
            }   
        }
    }
}
