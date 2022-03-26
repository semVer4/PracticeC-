using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("X: ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            int Y = Convert.ToInt32(Console.ReadLine());

            for (int i = A; i < B; i++)
            {
                if ((i - X) % 10 == 0 || (i - Y) % 10 == 0) Console.WriteLine(i);
            }
        }
    }
}
