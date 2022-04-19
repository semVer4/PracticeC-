using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class Program
    {
        /// <summary>
        /// Этот метод меняет цифры в двузначном числе местами.
        /// </summary>
        /// <param name="x">Число</param>
        public static void Calculation(int x)
        {
            if (Convert.ToString(x).Length == 2)
            {
                var a = x / 10;
                var b = x % 10;

                Console.WriteLine($"Цифры поменялись местами: {b + a.ToString()}");
            }
            else
            {
                Console.WriteLine($"Цифры не поменялись местами: {x}");
            }
        }

        static void Main(string[] args)
        {
            Calculation(Convert.ToInt32(Console.ReadLine()));
        }
    }
}