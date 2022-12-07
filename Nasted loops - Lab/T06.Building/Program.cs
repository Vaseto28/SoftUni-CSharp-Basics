using System;

namespace building
{
    class Program
    {
        static void Main(string[] args)
        {
            var floors = int.Parse(Console.ReadLine());
            var rooms = int.Parse(Console.ReadLine());
            for (int floor = floors; floor > 0; floor--)
            {
                if (floor == floors)
                {
                    for (int room = 0; room < rooms; room++)
                    {
                        Console.Write($"L{floor}{room} ");
                    }
                    Console.WriteLine();
                }
                else if (floor % 2 == 0)
                {
                    for (int room = 0; room < rooms; room++)
                    {
                        Console.Write($"O{floor}{room} ");
                    }
                    Console.WriteLine();
                }
                else if (floor % 2 != 0)
                {
                    for (int room = 0; room < rooms; room++)
                    {
                        Console.Write($"A{floor}{room} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
