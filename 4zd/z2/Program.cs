using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Заполните массив:");

            SearchArr mas = new SearchArr(n, m);
            SearchArr mas2 = new SearchArr(n, m);

            mas.CreatMas();
            mas.Swap();
        }
    }
}
