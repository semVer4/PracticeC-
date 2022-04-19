using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace z5
{
    internal class Program
    {
        static void CalcFunction(int a)
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken token = cancelTokenSource.Token;

            int sum = 0;
            int proiz = 1;

            int[] mas = new int[4] { 34, 7, 87, 12 };
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
                proiz *= mas[i];
                Thread.Sleep(500);

                if (proiz >= 248472 || sum >= 248472)
                {
                    cancelTokenSource.Cancel();
                    Console.WriteLine($"Число равно {proiz}");
                }

                Console.WriteLine(sum);
                Console.WriteLine(proiz);
            }

        }

        static void Main(string[] args)
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken CLtoken = cancelTokenSource.Token;

            Task task = new Task(
                delegate ()
                {
                    Thread.Sleep(600);
                    cancelTokenSource.Cancel();
                });

            task.Start();

            Parallel.ForEach<int>(new List<int>() { 34, 7, 87, 12 },
                new ParallelOptions { CancellationToken = CLtoken }, CalcFunction);
        }
    }
}
