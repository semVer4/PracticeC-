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
            Console.WriteLine("A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("X: ");
            int X = Convert.ToInt32(Console.ReadLine());

            while (A % 10 != X)
            {
                A++;
            }

            int i;
            Console.WriteLine();
            Console.WriteLine("Цикл for: ");
            for (i = A; i <= B; i += 10)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("Цикл while: ");
            i = A;
            while (i <= B)
            {
                Console.WriteLine(i);
                i += 10;
            }

            Console.WriteLine();
            Console.WriteLine("Цикл do while: ");
            i = A;
            do
            {
                Console.WriteLine(i);
                i += 10;
            }
            while (i <= B);
        }
    }
}
