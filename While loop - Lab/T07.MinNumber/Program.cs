using System;

namespace max_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine();
            var minNum = int.MaxValue;
            while (commands != "Stop")
            {
                var num = int.Parse(commands);
                if (num < minNum)
                {
                    minNum = num;
                }
                commands = Console.ReadLine();
            }
            Console.WriteLine(minNum);
        }
    }
}
