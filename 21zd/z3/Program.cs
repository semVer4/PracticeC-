using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    internal class Program
    {
        static void CalcFunction(int number)
        {
            int b = number / 100 % 10;
            int n = number / 10 % 10;
            int d = number % 10;

            int print = b + n;
            Console.WriteLine(print);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите 3-значное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Task task = new Task(
                delegate ()
                {
                    CalcFunction(number);
                });

            task.Start();
            task.Wait();

            Task task2 = new Task(
                delegate ()
                {
                    CalcFunction(number);
                }); 

            task2.Start();
        }
    }
}
