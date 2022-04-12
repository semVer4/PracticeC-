using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace z2
{
    internal class Program
    {
        static void Sum()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
                Console.WriteLine($"Сумма: {sum}");
                Thread.Sleep(100);
            }

            stopwatch.Stop();
            Console.WriteLine($"{Thread.CurrentThread.Name}, {stopwatch.ElapsedMilliseconds}");
        }
        static void Main(string[] args)
        {

            Thread thread = new Thread(Sum);
            thread.Name = "Первый поток";

            Thread thread1 = new Thread(Sum);
            thread1.Name = "Второй поток";

            thread.Start();
            thread1.Start();
        }
    }
}
