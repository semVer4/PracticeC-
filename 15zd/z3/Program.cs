using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace z3
{
    internal class Program
    {
        static void Sum(int A, int N)
        {
            double sum = 0;

            for (int i = 0; i < N; i++)
            {
                sum = sum + Math.Pow(A, i);

                Console.WriteLine($"1 метод: {sum}, {Thread.CurrentThread.Name}");
                Thread.Sleep(150);
            } 
        }

        static void Mult(int A, int N)
        {
            double mult = 1;

            for (var i = 0; i < N; i++)
            {
                mult = mult * Math.Pow(A, i);

                Console.WriteLine($"2 метод: {mult}, {Thread.CurrentThread.Name}");
                Thread.Sleep(150);
            }
        }

        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());

            ThreadStart ts = new ThreadStart(
                delegate ()
                {
                    Sum(A, N);
                });

            Thread thread = new Thread(ts);
            thread.Name = "1 поток";
            thread.Start();

            ThreadStart ts2 = new ThreadStart(
                delegate ()
                {
                    Sum(A, N);
                    Mult(A, N);
                });

            Thread thread1 = new Thread(ts2);
            thread1.Name = "2 поток";
            thread1.Start();
        }
    }
}
