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
            double x = Convert.ToDouble(Console.ReadLine());
            double y;

            if(x > 6.7)
            {
                y = 4 - Math.Pow(Math.E, 4 * x);
                Console.WriteLine(y);
            } else if(x <= 6.7)
            {
                y = Math.Log10(3.5 + x);
                Console.WriteLine(y);
            }
        }
    }
}
