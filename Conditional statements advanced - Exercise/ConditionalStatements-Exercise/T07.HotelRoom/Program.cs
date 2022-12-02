using System;

namespace hotel_room
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());
            var studioPrice = 0.0;
            var appartmentPrice = 0.0;
            switch (month)

            {
                case "May":
                case "October":
                    studioPrice = 50;
                    appartmentPrice = 65;
                    if (nights > 7 && nights <= 14)
                    {
                        studioPrice = studioPrice - studioPrice * 0.05;
                    }
                    else if (nights > 14)
                    {
                        studioPrice = studioPrice - studioPrice * 0.30; ;
                        appartmentPrice = appartmentPrice - appartmentPrice * 0.10;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    appartmentPrice = 68.70;
                    if (nights > 14)
                    {
                        studioPrice = studioPrice - studioPrice * 0.20;
                        appartmentPrice = appartmentPrice - appartmentPrice * 0.10;
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = 76;
                    appartmentPrice = 77;
                    if (nights > 14)
                    {
                        appartmentPrice = appartmentPrice - appartmentPrice * 0.10;
                    }
                    break;
            }
            Console.WriteLine($"Apartment: {nights * appartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {nights * studioPrice:f2} lv.");
        }
    }
}
