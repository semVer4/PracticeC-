using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double number4 = number % 10; number /= 10;
            double number3 = number % 10; number /= 10;
            double number2 = number % 10; number /= 10;
            double number1 = number % 10;

            double print = number1 * 1000 + number2 * 10 + number3 * 100 + number4;
            Console.WriteLine(print);
        }
    }
}
