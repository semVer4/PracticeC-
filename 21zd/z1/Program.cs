using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace z1
{
    internal class Program
    {
        static void MyTask(int number)
        {
            double number4 = number % 10; number /= 10;
            double number3 = number % 10; number /= 10;
            double number2 = number % 10; number /= 10;
            double number1 = number % 10;

            double print = number1 * 1000 + number2 * 10 + number3 * 100 + number4;
            Console.WriteLine(print);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите 4-значное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Task task = new Task(
                delegate ()
                {
                    MyTask(number);
                });

            task.Start();
            task.Wait();

            Task task1 = Task.Factory.StartNew(
                delegate ()
                {
                    MyTask(number);
                });

            Task task2 = Task.Run(
                delegate ()
                {
                    MyTask(number);
                });
        }
    }
}
