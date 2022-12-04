using System;

namespace odd_or_even_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var oddSum = 0;
            var evenSum = 0;
            for (int i = 0; i < count; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum = evenSum + number;
                }
                else
                {
                    oddSum = oddSum + number;
                }
            }
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddSum - evenSum)}");
            }
        }
    }
}
