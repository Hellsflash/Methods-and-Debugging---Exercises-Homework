using System;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeroes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var number = BigInteger.Parse(Console.ReadLine());
            BigInteger factorial = 1;


            for (BigInteger i = 1; i <= number; i++)
            {
                factorial *= i;



            }
            TrailingZeroes(factorial);

        }

        public static void TrailingZeroes(BigInteger number)
        {
            BigInteger ZeroTrail = 0;

            while (number % 10 == 0)
            {
                number /= 10;
                ZeroTrail++;
            }
            Console.WriteLine(ZeroTrail);

        }
    }
}
