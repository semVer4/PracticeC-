using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    internal class Program
    {
        static void SortInc3(ref double a, ref double b, ref double c)
        {
            double maxnum = Math.Max(Math.Max(a, b), c);
            double minnum = Math.Min(Math.Min(a, b), c);
            double middlenum = a + b + c - maxnum - minnum;

            a = minnum;
            b = middlenum;
            c = maxnum;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Заполните 1 группу чисел:");
                double a1 = Convert.ToInt64(Console.ReadLine()), b1 = Convert.ToInt64(Console.ReadLine()),
                    c1 = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("Заполните 2 группу чисел:");
                double a2 = Convert.ToInt64(Console.ReadLine()), b2 = Convert.ToInt64(Console.ReadLine()),
                    c2 = Convert.ToInt64(Console.ReadLine());
                
                SortInc3(ref a1, ref b1, ref c1);
                SortInc3(ref a2, ref b2, ref c2);

                Console.WriteLine("1 группа чисел: {0} {1} {2}", a1, b1, c1);
                Console.WriteLine("2 группа чисел: {0} {1} {2}", a2, b2, c2);
            } catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
