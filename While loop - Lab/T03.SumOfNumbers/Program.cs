using System;

namespace sum_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = int.Parse(Console.ReadLine());
            var sum1 = 0;
            while (sum > sum1)
            {
                var num = int.Parse(Console.ReadLine());
                sum1 += num;
            }
            Console.WriteLine(sum1);
        }
    }
}
