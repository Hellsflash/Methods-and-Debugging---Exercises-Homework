using System;


namespace _05.Fibonacci_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int fibNumber = int.Parse(Console.ReadLine());
            Fib(fibNumber);
        }
        public static void Fib(int fibNumber)
        {
            var fib1 = 0;
            var fib2 = 1;
            var fibNext = 0;
            for (int i = 0; i < fibNumber; i++)
            {
                fibNext = fib1 + fib2;
                fib1 = fib2;
                fib2 = fibNext;
            }
            Console.WriteLine(fib2);
        }
    }
}
