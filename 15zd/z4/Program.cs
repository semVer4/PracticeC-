using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace z4
{
    internal class Program
    {
        static int[] mas = new int[10];

        static void Sum()
        {
            for (var i = 0; i < mas.Length; i++)
            {
                Random rand = new Random();
                mas[i] = rand.Next(10, 30);
                
                if (mas[i] % 2 == 0)
                {
                    Console.WriteLine(mas[i]);
                }

                Thread.Sleep(100);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Кол-во потоков: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Thread[] thread = new Thread[amount];
            int[] s = new int[amount];

            int[] x = new int[amount];

            for (var i = 0; i < 10; i++)
            {
                mas[i] = i;
            }
            
            for (var i = 0; i < amount; i++)
            {
                x[i] = i;
                thread[i] = new Thread(Sum);
                thread[i].Start();
                thread[i].Join();
            }
        }
    }
}
