using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 1;

            double y = Math.Log10(2 * x) + (Math.Sin(2) * x + 1) / (2 * Math.Sqrt(Math.E) + 1 - Math.Cos(x - Math.PI));
            Console.WriteLine(y);
        }
    }
}
