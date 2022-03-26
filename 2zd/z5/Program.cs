using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            int count = 1;

            for(var i = A; i <= B; i++)
            {
                count = count *= i;
            }

            Console.WriteLine($"Прозиведение чисел: {count}");
        }
    }
}
