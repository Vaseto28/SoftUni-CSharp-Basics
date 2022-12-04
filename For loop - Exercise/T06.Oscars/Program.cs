using System;

namespace oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            var actorName = Console.ReadLine();
            var academyPoints = double.Parse(Console.ReadLine());
            var raters = int.Parse(Console.ReadLine());
            for (int i = 0; i < raters; i++)
            {
                var raterName = Console.ReadLine();
                var raterPoints = double.Parse(Console.ReadLine());
                var nameLength = raterName.Length;
                academyPoints += ((nameLength * raterPoints) / 2);
                if (academyPoints >= 1250.5)
                {
                    break;
                }
            }
            if (academyPoints >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyPoints:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {Math.Abs(academyPoints - 1250.5):f1} more!");
            }
        }
    }
}
