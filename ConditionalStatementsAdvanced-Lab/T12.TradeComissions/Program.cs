using System;

namespace comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameOfCity = Console.ReadLine();
            var sales = double.Parse(Console.ReadLine());
            var comissions = 0.0;
            switch (nameOfCity)
            {
                case "Sofia":
                    if (sales >= 0 && sales <= 500)
                    {
                        comissions = sales * 0.05;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comissions = sales * 0.07;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comissions = sales * 0.08;
                    }
                    else if (sales > 10000)
                    {
                        comissions = sales * 0.12;
                    }
                    break;
                case "Varna":
                    if (sales >= 0 && sales <= 500)
                    {
                        comissions = sales * 0.045;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comissions = sales * 0.075;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comissions = sales * 0.10;
                    }
                    else if (sales > 10000)
                    {
                        comissions = sales * 0.13;
                    }
                    break;
                case "Plovdiv":
                    if (sales >= 0 && sales <= 500)
                    {
                        comissions = sales * 0.055;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comissions = sales * 0.08;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comissions = sales * 0.12;
                    }
                    else if (sales > 10000)
                    {
                        comissions = sales * 0.145;
                    }
                    break;
            }
            if (comissions == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{comissions:f2}");
            }
        }
    }
}
