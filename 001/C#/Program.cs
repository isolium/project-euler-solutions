using System;
using System.Diagnostics;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            // Solution 1: bruteforcing; not efficient
            sw = Stopwatch.StartNew();
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) sum += i;
            }
            Console.WriteLine("- Solution 1 -");
            Console.Write("RESULT: ");
            Console.WriteLine(sum);
            Console.Write("TIME: ");
            Console.WriteLine(sw.ElapsedMilliseconds + "ms");

            Console.WriteLine();

            // Solution 2: arithmetic approach; most efficient
            sw = Stopwatch.StartNew();
            int SumDivisbleBy(int n, int p)
            {
                return n*(p/n)*((p/n)+1)/2;
            }
            Console.WriteLine("- Solution 2 -");
            Console.Write("RESULT: ");
            Console.WriteLine(SumDivisbleBy(3, 999) + SumDivisbleBy(5, 999) - SumDivisbleBy(15, 999));
            Console.Write("TIME: ");
            Console.WriteLine(sw.ElapsedMilliseconds + "ms");

            sw.Stop();
        }
    }
}
