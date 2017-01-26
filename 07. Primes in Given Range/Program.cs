using System;
using System.Collections.Generic;

namespace _07.Primes_in_Given_Range
{
    public static class Program
    {
       public static  void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            string numbers = String.Join(", ", GetPrimeNumbers(startNumber, endNumber).ToArray());
            Console.WriteLine(numbers);
        }

        private static List<int> GetPrimeNumbers(int start, int end)
        {
            var result = new List<int>();
            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;
                if (i < 2) isPrime = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
