using System;

namespace max_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine();
            var maxNum = int.MinValue;
            while (commands != "Stop")
            {
                var num = int.Parse(commands);
                if (num > maxNum)
                {
                    maxNum = num;
                }
                commands = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}
