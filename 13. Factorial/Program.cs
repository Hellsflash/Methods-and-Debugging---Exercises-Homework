using System;
using System.Numerics;

namespace _13.Factorial
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
            Console.WriteLine(factorial);
        }
    }
}
