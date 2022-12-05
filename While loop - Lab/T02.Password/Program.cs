using System;

namespace password
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine();
            var password = Console.ReadLine();
            var inputPassowrd = Console.ReadLine();
            while (inputPassowrd != password)
            {
                inputPassowrd = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}
