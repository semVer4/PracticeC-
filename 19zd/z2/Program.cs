using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace z2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            string path = @"1.txt";
            StreamWriter sw = new StreamWriter(path);

            for (int i = 0; i < 100; i++)
            {
                sw.WriteLine(i);
            }

            sw.Close();

            Queue<int> fromAToB = new Queue<int>();
            Queue<int> lessThenA = new Queue<int>();
            Queue<int> moreThenB = new Queue<int>();

            int number; 
            StreamReader reader = new StreamReader(path);

            while (!reader.EndOfStream)
            {
                number = int.Parse(reader.ReadLine());
                if (number < a)
                    lessThenA.Enqueue(number);
                else if (number > b)
                    moreThenB.Enqueue(number);
                else
                    fromAToB.Enqueue(number);
            }

            Console.Write("Все числа из интервала [a, b]: ");
            Console.WriteLine(string.Join(" ", fromAToB));

            Console.Write("\nВсе числа < a: ");
            Console.WriteLine(string.Join(" ", lessThenA));

            Console.Write("\nВсе числа > b: ");
            Console.WriteLine(string.Join(" ", moreThenB));
        }
    }
}
