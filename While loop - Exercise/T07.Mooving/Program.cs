using System;

namespace mooving
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var lenght = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            var capacity = width * lenght * height;
            var commands = Console.ReadLine();
            while (commands != "Done")
            {
                var boxCapacity = int.Parse(commands);
                capacity -= boxCapacity;
                if (capacity < 0)
                {
                    var neededCubicMeters = Math.Abs(capacity);
                    Console.WriteLine($"No more free space! You need {neededCubicMeters} Cubic meters more.");
                    return;
                }
                commands = Console.ReadLine();
            }
            var moreCubicMeters = Math.Abs(capacity);
            Console.WriteLine($"{moreCubicMeters} Cubic meters left.");
        }
    }
}
