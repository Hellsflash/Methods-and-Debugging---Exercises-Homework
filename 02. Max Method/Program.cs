using System;


namespace _02.Max_Method
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = GetMax(firstNumber, secondNumber, thirdNumber);

            Console.WriteLine(result);
        }

        public static int GetMax(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b>a && b>c)
            {
                return b;
            }
            else 
            {
                return c;
            }
           
        }
    }
}
