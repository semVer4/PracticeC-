using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(var i = 0; i < 999; i++)
            {
                if(Math.Pow(i, 2) % 1000 == i && i.ToString().Length == 3)
                {
                    Console.WriteLine($"Число: {i}. Aвтоморфное число: {Math.Pow(i, 2)}");
                }
            }
        }
    }
}
