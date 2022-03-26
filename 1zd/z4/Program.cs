using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Размеры комнаты:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Размеры окна:");
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Размеры двери:");
            double n = Convert.ToDouble(Console.ReadLine());
            double m = Convert.ToDouble(Console.ReadLine());

            double S1 = c * d;
            double S2 = n * m;

            var S = 4 * a * b - S1 - S2;
            Console.WriteLine($"Площадь: {S}");
        }
    }
}
