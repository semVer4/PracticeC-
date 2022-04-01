using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class Program
    {
        public static void ArrFilling(int x, double[] mas)
        {
            Random random = new Random();

            for(var i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(30);
                Console.WriteLine(mas[i]);
            }
        }

        public static void Print(int x, double[] mas)
        {
            for (var i = 0; i < mas.Length; i++)
            {
                if (mas[i] > 0 && mas[i] > 3.2)
                {
                    Console.WriteLine(mas[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Размерность массива:");
            int x = Convert.ToInt32(Console.ReadLine());

            double[] mas = new double[x];

            Console.WriteLine("Заполнение:");
            ArrFilling(x, mas);

            Console.WriteLine("Вывод по условию:");
            Print(x, mas);
        }
    }
}
