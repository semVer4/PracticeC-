using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace z2
{
    internal class Program
    {
        static void CalcFunction(int a)
        {
            double z1 = Math.Sin(2 * a) + Math.Sin(5 * a) - Math.Sin(3 * a) / Math.Cos(a) + 1 - 2 * Math.Sin(2 * a);
            Console.WriteLine(z1);
        }
        static void CalcSecondFunction(int a)
        {
            double z2 = 2 * Math.Sin(a);
            Console.WriteLine(z2);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Task[] task = new Task[2]
            {
                new Task(
                    delegate ()
                    {
                        CalcFunction(a);
                    }),

                new Task(
                    delegate ()
                    {
                        CalcSecondFunction(a);
                    })
            };

            foreach (var st in task)
            {
                st.Start();
                Thread.Sleep(100);
            }
        }
    }
}
