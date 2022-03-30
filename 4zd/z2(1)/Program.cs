using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2_1_
{
    internal class Program
    {
        static void Func1(double x, out double y)
        {
            y = 0;

            Console.WriteLine($"f({x}) = {Function(x)} ");
        }
        static double Function(double x)
        {
            double y;

            if (x < 0)
            {
                y = 0;
            } else if (x > 0 || x != 1)
            {
                y = Math.Pow(x, 2) + 1;
            } else
            {
                y = 1;
            }

            return y;
        }

        static void Main(string[] args)
        {
            double y = 0;
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("h=");
            double h = Convert.ToDouble(Console.ReadLine());

            for (double i = a; i <= b; i += h)
            {
                Console.WriteLine($"f({i}) = {Function(i)}");

            }

            for (double i = a; i <= b; i += h)
            {
                Func1(i, out y);
            }
        }
    }
}
