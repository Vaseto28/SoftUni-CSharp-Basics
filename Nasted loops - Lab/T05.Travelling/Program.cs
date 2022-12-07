using System;

namespace travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            var destination = Console.ReadLine();
            while (destination != "End")
            {
                var budget = double.Parse(Console.ReadLine());
                var savings = 0.0;
                while (savings < budget)
                {
                    savings += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
