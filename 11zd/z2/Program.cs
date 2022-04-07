using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A, B:");
            A classA = new A(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            B classB = new B(3, 3);

            Console.WriteLine("d:");
            classB.d = float.Parse(Console.ReadLine());

            Console.WriteLine(classA.C);
            Console.WriteLine(classB.C2);
        }
    }
}
