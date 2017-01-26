using System;


namespace _03.English_Name_of_Last_Digit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            var result = PrintLastDigit(number);

            Console.WriteLine(result);

        }

        public static string PrintLastDigit(long lastDigit)
        {
            lastDigit =Math.Abs(lastDigit%10);

            if (lastDigit == 0)
            {
                return "zero";
            }
            else if (lastDigit == 1)
            {
                return "one";
            }
            else if (lastDigit == 2)
            {
                return "two";
            }
            else if (lastDigit == 3)
            {
                return "three";
            }
            else if (lastDigit == 4)
            {
                return "four";
            }
            else if (lastDigit == 5)
            {
                return "five";
            }
            else if (lastDigit == 6)
            {
                return "six";
            }
            else if (lastDigit == 7)
            {
                return "seven";
            }
            else if (lastDigit == 8)
            {
                return "eight";
            }
            else  
            {
                return "nine";
            }

        }


    }

}

