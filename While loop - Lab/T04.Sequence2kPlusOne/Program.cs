using System;

namespace _2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var newNum = 1;
            while (newNum <= num)
            {
                Console.WriteLine(newNum);
                newNum = 2 * newNum + 1;
            }

        }
    }
}
