using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class Program
    {
        delegate double CountPrint(double a);

        static double Perimetr(double a)
        {
            double P = a * 4;
            Console.WriteLine($"Периметр квадрата: {P}");

            return P;
        }

        static double Square(double a)
        {
            double S = Math.Pow(a, 2);
            Console.WriteLine($"Площадь квадрата: {S}");

            return S;
        }

        static double PrintTriangle(double a)
        {
            Console.WriteLine($"Сторона треугольника: {a}");

            return a;
        }

        static void Main(string[] args)
        {
            CountPrint CP = new CountPrint(Perimetr);
            CP += Square;
            CP += PrintTriangle;

            try
            {
                Console.Write("Введите сторону фигуры: ");
                CP.Invoke(Convert.ToDouble(Console.ReadLine()));
            } catch (FormatException)
            {
                Console.WriteLine("Введите число!");
            }
        }
    }
}
