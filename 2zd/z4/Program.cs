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
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            int X = Convert.ToInt32(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Цикл - do while");
            int i = B;
            do
            {
                if (i % 2 == 0 && i % 10 == X || i % 10 == Y)
                {
                    Console.WriteLine(i);
                }

                i--;

            } while (i >= A);

            Console.WriteLine();

            Console.WriteLine("Цикл - for");
            for(var number = B; number >= A; number--)
            {
                if(number % 2 == 0 && number % 10 == X || number % 10 == Y)
                {
                    Console.WriteLine(number);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Цикл - while");
            while(A <= B)
            {
                B--;

                if(B % 2 == 0 && B % 10 == X || B % 10 == Y)
                {
                    Console.WriteLine(B);
                }
            }
        }
    }
}
