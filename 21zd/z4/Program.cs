using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace z4
{
    internal class Program
    {
        static void Calc(int x)
        {
            int a = -1;
            int b = 9;

            double c = 1;

            for (int i = a; i <= b; i++)
            {

                c = Math.Cos(1 / x);
                Console.WriteLine(c);
                Thread.Sleep(500);
            }
        }

        static void Main(string[] args)
        {
            ParallelLoopResult plR = Parallel.For(-1, 9, Calc);
        }
    }
}
