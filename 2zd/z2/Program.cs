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
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());    
            int c = Convert.ToInt32(Console.ReadLine());

            if(a == b && b == c)
            {
                Console.WriteLine("Равносторонний треугольник");
            }
        }
    }
}
