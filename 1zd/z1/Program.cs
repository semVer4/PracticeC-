using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());
            double number3 = Convert.ToDouble(Console.ReadLine());
            double number4 = Convert.ToDouble(Console.ReadLine());

            double a = ((number1 / number2) + (number3 / number4));
            Console.WriteLine($"{number1:0.00}/{number2:0.00}+{number3:0.00}/{number4:0.00}={a:0.00}");
        }
    }
}
