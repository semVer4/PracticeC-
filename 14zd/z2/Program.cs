using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    internal class Program
    {
        delegate void CountPrint(double a);

        static void Perimetr(double a, CountPrint method)
        {
            double P = a * 4;
            method(P);
        }

        static void Square(double a, CountPrint method)
        {
            double S = Math.Pow(a, 2);
            method(S);
        }

        static void PrintTriangle(double a, CountPrint method)
        {
            method(a);
        }

        static void PrintDelegate(double a)
        {
            Console.WriteLine(a);
        }

        static void Main(string[] args)
        {
            CountPrint method = PrintDelegate;

            try
            {
                Console.Write("Введите сторону фигуры: ");
                double side = Convert.ToDouble(Console.ReadLine());

                Console.Write("Периметр квадрата: ");
                Perimetr(side, method);

                Console.Write("Площадь квадрата: ");
                Square(side, method);

                Console.Write("Сторона треугольника: ");
                PrintTriangle(side, method);

            } catch (FormatException)
            {
                Console.WriteLine("Введите число!");
            }
        }
    }
}