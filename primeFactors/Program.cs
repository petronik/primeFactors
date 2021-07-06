using System;
using System.Collections.Generic;

namespace primeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Please enter your integer: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Prime factors of {num1} are: {primeFactors(num1)}");

            Console.WriteLine("Thank you! Bye!");
        }

        public static string primeFactors(int number)
        {
            var primes = new List<int>();

            for ( int div = 2; div <= number; div++)
            {
                while (number % div == 0)
                {
                    primes.Add(div);
                    number = number / div;
                }
            }

            return string.Join(" x ", primes);
        }
    }
}
