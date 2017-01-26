using System;


namespace _04.Numbers_in_Reversed_Order
{
   public class Program
    {
       public static void Main(string[] args)
        {
            string number = Console.ReadLine();
            LastDigit(number);
        }

        public static void LastDigit(string number)
        {
            int lastDigit = 1;
            string result = "";
            for (int i = number.Length; i >0; i--)
            {
                char digit = number[number.Length - lastDigit];
                result += digit;
                lastDigit++;
            }
            Console.WriteLine(result);
        }
    }
}
