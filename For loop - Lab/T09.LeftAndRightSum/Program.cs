using System;

namespace left_and_right_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;
            for (int i = 0; i < count; i++)
            {
                var number = int.Parse(Console.ReadLine());
                sum1 = sum1 + number;
            }
            for (int i = 0; i < count; i++)
            {
                var number1 = int.Parse(Console.ReadLine());
                sum2 = sum2 + number1;
            }
            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1 - sum2)}");
            }
        }
    }
}
