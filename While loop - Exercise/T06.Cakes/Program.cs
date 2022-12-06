using System;

namespace cake
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var lenght = int.Parse(Console.ReadLine());
            var commands = Console.ReadLine();
            var area = width * lenght;
            while (commands != "STOP")
            {
                var piece = int.Parse(commands);
                area -= piece;
                if (area < 0)
                {
                    var morePieces = Math.Abs(area);
                    Console.WriteLine($"No more cake left! You need {morePieces} pieces more.");
                    break;
                }
                commands = Console.ReadLine();
            }
            if (commands == "STOP")
            {
                var piecesLeft = Math.Abs(area);
                Console.WriteLine($"{piecesLeft} pieces are left.");
            }
        }
    }
}
