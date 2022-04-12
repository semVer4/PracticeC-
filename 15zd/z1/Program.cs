using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace z1
{
    internal class Program
    {
        static void PrimaryFlow()
        {
            for (var i = 0; i < 9; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(150);
            }  
        }

        static void SecondaryFlow()
        {
            for (var i = 10; i < 19; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(150);
            }
        }

        static void SecondaryFlow2()
        {
            for (var i = 20; i < 29; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(150);
            }
        }

        static void Main(string[] args)
        {
            ThreadStart write = new ThreadStart(PrimaryFlow);
            ThreadStart write1 = new ThreadStart(SecondaryFlow);
            ThreadStart write2 = new ThreadStart(SecondaryFlow2);

            Thread thread = new Thread(write);
            Thread thread1 = new Thread(write1);
            Thread thread2 = new Thread(write2);

            thread.Priority = ThreadPriority.Highest;
            thread1.Priority = ThreadPriority.BelowNormal;
            thread2.Priority = ThreadPriority.Lowest;

            thread.Start();
            thread.Join(100);
            thread1.Start();
            thread1.Join(100);
            thread2.Start();
            thread2.Join(100);
        }
    }
}
