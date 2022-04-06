using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using z2.Exceptions;

namespace z2
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Array v1 = new Array(5, 1, 5);
            Array v2 = new Array(5, 1, 5);

            Array v3 = v1 + v2;

            Console.Write("\nВывод всего массива: ");
            v1.PrintAll();

            Console.Write("\nВывод по элементу: ");
            v1.PrintElem(Convert.ToInt32(Console.ReadLine()));

            Console.Write("\nСложение: ");
            v3.PrintAll();

            Console.WriteLine();
        }
    }
}
