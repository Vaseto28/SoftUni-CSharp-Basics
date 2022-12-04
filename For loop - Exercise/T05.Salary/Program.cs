using System;

namespace salary
{
    class Program
    {
        static void Main(string[] args)
        {
            var tabsCount = int.Parse(Console.ReadLine());
            var salary = double.Parse(Console.ReadLine());
            var fine = 0;
            for (int i = 0; i < tabsCount; i++)
            {
                var tabs = Console.ReadLine();
                switch (tabs)
                {
                    case "Facebook":
                        fine += 150;
                        break;
                    case "Instagram":
                        fine += 100;
                        break;
                    case "Reddit":
                        fine += 50;
                        break;
                }
                if (fine >= salary)
                {
                    break;
                }
            }
            if (fine >= salary)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(Math.Abs(fine - salary));
            }
        }
    }
}
