using System;

namespace lunch_break
{
    class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            int episodeContinuous = int.Parse(Console.ReadLine());
            int breakContinuous = int.Parse(Console.ReadLine());
            double lunchAndRestTime = breakContinuous / 8.0 + breakContinuous / 4.0;
            double timeLeft = breakContinuous - lunchAndRestTime;
            if (timeLeft >= episodeContinuous)
            {
                double timeleft = Math.Abs(episodeContinuous - timeLeft);
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeleft)} minutes free time.");
            }
            else
            {
                double neededTime = Math.Abs(episodeContinuous - timeLeft);
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(neededTime)} more minutes.");
            }
        }
    }
}
