using System;

namespace walking
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine();
            var steps = 0;
            var totalSteps = 0;
            while (commands != "Going home")
            {
                steps = int.Parse(commands);
                totalSteps += steps;
                if (totalSteps >= 10000)
                {
                    break;
                }
                commands = Console.ReadLine();
            }
            if (commands == "Going home")
            {
                commands = Console.ReadLine();
                steps = int.Parse(commands);
                totalSteps += steps;
            }
            var difference = Math.Abs(totalSteps - 10000);
            if (totalSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{difference} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{difference} more steps to reach goal.");
            }
        }
    }
}
