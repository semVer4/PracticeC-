    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class Program
    {
        public static void CalcA(double x)
        {
            try
            {
                double y = x + 4 / x + 8;
                Console.WriteLine(y);
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void CalcB(double x)
        {
            try
            {
                double y = Math.Pow(Math.Cos(x), 3) / x - 1;
                Console.WriteLine(y);
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                double x = Convert.ToDouble(Console.ReadLine());
                CalcA(x);
                CalcB(x);
            }

            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
