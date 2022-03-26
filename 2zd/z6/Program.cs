using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int M = 12;

            double A = Math.PI / 4;
            double B = 4 / Math.PI;

            double h = (B - A) / M;

            for (var i = A; i <= B; i = i + h)
            {
                double y = Math.Cos(1 / i);
                Console.WriteLine($"Значение из числа: {i} = {y}");
            }
        }
    }
}
