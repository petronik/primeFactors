using System;
using System.Collections.Generic;

namespace primeFactors
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                int num1;
                Console.WriteLine("Please enter your integer or 0 to exit: ");
                num1 = int.Parse(Console.ReadLine());

                if(num1 == 0)
                {
                    Console.WriteLine("Thank you! Bye!");
                    break;
                }

                Console.WriteLine($"Prime factors of {num1} are: {primeFactors(num1)}");

                
            }
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
