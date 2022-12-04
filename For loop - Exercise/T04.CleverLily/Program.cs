using System;

namespace clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var washingMachinePrice = double.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());
            var toysCount = 0;
            var sum = 0;
            var totalSaves = 0;
            var saves = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    sum = (i * 5) - 1;
                    saves = saves + sum;
                }
                else
                {
                    toysCount += 1;
                }
            }
            totalSaves = saves + (toysCount * toyPrice);
            if (totalSaves >= washingMachinePrice)
            {
                var moneyLeft = Math.Abs(totalSaves - washingMachinePrice);
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else
            {
                var neededMoney = Math.Abs(totalSaves - washingMachinePrice);
                Console.WriteLine($"No! {neededMoney:f2}");
            }
        }
    }
}
