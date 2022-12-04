using System;

namespace tennis_ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            var tournirs = int.Parse(Console.ReadLine());
            var startingPoints = int.Parse(Console.ReadLine());
            var points = 0;
            var totalPoints = 0;
            var winnedTournirs = 0.0;
            for (int i = 0; i < tournirs; i++)
            {
                var status = Console.ReadLine();
                switch (status)
                {
                    case "W":
                        points = 2000;
                        winnedTournirs++;
                        break;
                    case "F":
                        points = 1200;
                        break;
                    case "SF":
                        points = 720;
                        break;
                }
                totalPoints += points;
            }
            var averagePoints = totalPoints / tournirs;
            winnedTournirs = winnedTournirs / tournirs * 100;
            var finalPoints = totalPoints + startingPoints;
            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{winnedTournirs:f2}%");
        }
    }
}
