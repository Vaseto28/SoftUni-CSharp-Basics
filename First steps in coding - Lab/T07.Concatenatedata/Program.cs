using System;

namespace text_and_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstname = Console.ReadLine();
            var lastname = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();
            Console.WriteLine("You are " + firstname + " " + lastname + ", a " + age + "-years old person from " + town + "."); ;
        }
    }
}
