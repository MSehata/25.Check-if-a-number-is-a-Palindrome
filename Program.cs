using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Check_if_a_number_is_a_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int reversedNumber = Reverse(number);

            if (number == reversedNumber)
                Console.WriteLine(number + " is a palindrome.");
            else
                Console.WriteLine(number + " is not a palindrome.");
        }

        static int Reverse(int n)
        {
            int reverse = 0;
            while (n > 0)
            {
                int remainder = n % 10;
                reverse = (reverse * 10) + remainder;
                n = n / 10;
            }
            return reverse;
        }
    }
}
