using System;

namespace sum_of_prime_and_non_prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine();
            var primeNumsSum = 0;
            var nonPrimeNumsSum = 0;
            var isPrime = true;
            while (commands != "stop")
            {
                var num = int.Parse(commands);
                isPrime = true;
                if (num < 0)
                {

                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            nonPrimeNumsSum += num;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        primeNumsSum += num;
                    }
                }
                commands = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeNumsSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumsSum}");
        }
    }
}
