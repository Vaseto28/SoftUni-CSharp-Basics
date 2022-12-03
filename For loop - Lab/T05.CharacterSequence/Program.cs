using System;

namespace character_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}
