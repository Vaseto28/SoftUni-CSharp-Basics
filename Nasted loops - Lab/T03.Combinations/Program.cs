using System;

namespace combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            var salutions = int.Parse(Console.ReadLine());
            var validCombinations = 0;
            for (int i1 = 0; i1 <= salutions; i1++)
            {
                for (int i2 = 0; i2 <= salutions; i2++)
                {
                    for (int i3 = 0; i3 <= salutions; i3++)
                    {
                        if (i1 + i2 + i3 == salutions)
                        {
                            validCombinations++;
                        }
                    }
                }
            }
            Console.WriteLine(validCombinations);
        }
    }
}
