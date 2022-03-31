using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using z2.Exceptions;

namespace z2
{
    internal class Program
    {
        public static void Func1(double x)
        {
            try
            {
                double f;

                if (x < -4 && x >= 1)
                {
                    f = 3 * x + 2 / 4 * x + 4;
                    Console.WriteLine(f);
                }
                else if (1 < x)
                {
                    f = Math.Pow(x, 2);
                    Console.WriteLine(f);
                }

                else throw new OutOfDiapazonException("Выход из диапазона!", "Ошибка!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OutOfDiapazonException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                double x = Convert.ToDouble(Console.ReadLine());
                Func1(x);
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OutOfDiapazonException ex)
            {
                Console.WriteLine(ex.Comment, ex.Message);
            }
        }
    }
}
