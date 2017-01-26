using System;


namespace _06.Prime_Checker
{
    public class Program
    {
        public static void Main(string[] args)
        {
           long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }

        public static bool IsPrime(long number)
        {
            long sqrtNumer = (long)Math.Sqrt(number);
            if (number <= 1)
            {
                return false;
            }
            else if (number >= 2)
            {
                for (int i = 2; i <= sqrtNumer; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;

        }
    }
}
