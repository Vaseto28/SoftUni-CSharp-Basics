using System;

namespace projects_making
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var projects = int.Parse(Console.ReadLine());
            var hours = projects * 3;
            Console.WriteLine("The architect " + name + " will need " + hours + " hours to complete " + projects + " project/s.");
        }
    }
}
