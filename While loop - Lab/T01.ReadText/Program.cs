using System;

namespace Read_text
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            while (text != "Stop")
            {
                Console.WriteLine(text);
                text = Console.ReadLine();
            }
        }
    }
}
