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
            var Jet = new Jet(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()),
                Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

            Jet.PrintName();
            Jet.PrintPower2();
        }
    }
}
