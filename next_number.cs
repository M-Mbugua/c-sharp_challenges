/* Program to increase a number by 1 and print it */

using System;

namespace NextNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The next number is: " + ++number);
        }
    }
}
