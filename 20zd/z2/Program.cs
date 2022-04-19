using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class Program
    {
        public delegate double CalcFigure(double R);

        /// <summary>
        /// Этот метод высчитывает длину окружности.
        /// </summary>
        /// <param name="r">Ввод радиуса</param>
        /// <returns>Длина окружности</returns>
        static double GetLength(double r)
        {
            double D = 2 * Math.PI * r;
            Console.WriteLine($"Длина окружности: {Math.Round(D, 3)}");

            return Math.Round(D, 3);
        }

        /// <summary>
        /// Этот метод высчитывает площадь круга.
        /// </summary>
        /// <param name="r">Ввод радиуса</param>
        /// <returns>Площадь круга</returns>
        static double GetArea(double r)
        {
            double S = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Площадь круга: {Math.Round(S, 3)}");

            return Math.Round(S, 3);
        }

        /// <summary>
        /// Этот метод высчитывает объём шара.
        /// </summary>
        /// <param name="r">Ввод радиуса</param>
        /// <returns>Объём шара</returns>
        static double GetVolume(double r)
        {
            double V = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Объём шара: {Math.Round(V, 3)}");

            return Math.Round(V, 3);
        }

        static void Main(string[] args)
        {
            CalcFigure CF = new CalcFigure(GetLength);
            CF += GetArea;
            CF += GetVolume;

            Console.WriteLine("Введите радиус:");
            CF.Invoke(Convert.ToDouble(Console.ReadLine()));
        }
    }
}