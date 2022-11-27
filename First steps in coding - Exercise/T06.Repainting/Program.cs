using System;

namespace repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            var naylon = int.Parse(Console.ReadLine());
            var boq = int.Parse(Console.ReadLine());
            var razreditel = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var price = ((naylon + 2) * 1.50) + ((boq + 0.1 * boq) * 14.50) + (razreditel * 5) + 0.40;
            var workerPrice = hours * (price * 0.30);
            var finalprice = price + workerPrice;
            Console.WriteLine(finalprice);
        }
    }
}
