using System;

namespace even_powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            var powers = int.Parse(Console.ReadLine());
            var num = 1;
            for (int i = 0; i <= powers; i += 2)
            {
                Console.WriteLine(num);
                num = 4 * num;
            }
        }
    }
}
