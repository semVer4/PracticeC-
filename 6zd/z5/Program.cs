using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z5
{
    internal class Program
    {
        public static double Factorial(double n)
        {
            if (n == 1) 
                return 1;

            return n * Factorial(n - 1);
        }
        public static double Calc(double n)
        {
            double f = 0;
            return f = Factorial(n - 1) / Factorial(n);
        }
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine(Calc(n));
        }
    }
}
