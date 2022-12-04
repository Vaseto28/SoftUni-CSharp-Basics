using System;

namespace half_sum_element
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var sum = 0;
            var max = int.MinValue;
            for (int i = 0; i < count; i++)
            {
                var number = int.Parse(Console.ReadLine());
                sum = sum + number;
                if (number >= max)
                {
                    max = number;
                }
            }
            sum = sum - max;
            if (sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - max)}");
            }
        }
    }
}
