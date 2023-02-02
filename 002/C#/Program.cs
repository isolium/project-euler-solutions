using System;
using System.Diagnostics;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            // Solution 1: calculating Fibonacci series and testing for even values;
            // not efficient
            sw = Stopwatch.StartNew();
            int a = 1;
            int b = 1;
            int c = a + b;
            int sum = 0;
            while (c < 4000000)
            {
                if (c % 2 == 0) sum += c;
                a = b;
                b = c;
                c = a + b;
            }
            Console.WriteLine("- Solution 1 -");
            Console.Write("RESULT: ");
            Console.WriteLine(sum);
            Console.Write("TIME: ");
            Console.WriteLine(sw.ElapsedMilliseconds + "ms");

            Console.WriteLine();

            // Solution 2: calculating every third value of the series. that is,
            // the even values; more efficient
            sw = Stopwatch.StartNew();
            a = 1;
            b = 1;
            int t;
            sum = 0;
            while ((a + b) < 4000000)
            {
                sum += (a + b);
                t = a;
                a = a + 2 * b;
                b = 2 * t + 3 * b;
            }
            Console.WriteLine("- Solution 2 -");
            Console.Write("RESULT: ");
            Console.WriteLine(sum);
            Console.Write("TIME: ");
            Console.WriteLine(sw.ElapsedMilliseconds + "ms");

            sw.Stop();
        }
    }
}
