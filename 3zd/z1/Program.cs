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
            Calculation calc = new Calculation(Convert.ToInt32(Console.ReadLine()), 
                Convert.ToInt32(Console.ReadLine()));

            calc.Calc1();
            calc.Calc2();
        }
    }
}
