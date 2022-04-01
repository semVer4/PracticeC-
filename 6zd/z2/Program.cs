using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    internal class Program
    {
        public static void ArrFilling(double[] mas)
        {
            Random random = new Random();
            for (int i = 0; i <= 20; i++)
            {
                mas[i] = random.Next(30);

                if(i <= 10)
                {
                    double a1 = i;
                    Console.WriteLine(a1);
                }
            }
        }

        public static void MoreArr(double more, double[] mas)
        {
            for (var i = 1; i <= 20; i++)
            {
                if (i <= 10)
                {
                    more = more + mas[i];
                }
            }
            Console.WriteLine(more);
        }

        public static void LesserAr(double lesser, double[] mas)
        {
            for(var i = 1; i <= 20; i++)
            {
                if(i >= 10)
                {
                    lesser = lesser + mas[i];
                }
            }
            Console.WriteLine(lesser);
        }

        public static void Sort(double[] mas)
        {
            Array.Sort(mas);
            Array.Reverse(mas);
            foreach (var item in mas)
            {
                Console.Write(" " + item);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число k");
            int k = int.Parse(Console.ReadLine());

            double[] mas = new double[100];
            ArrFilling(mas);

            Sort(mas);

            double more = 0;
            double lesser = 0;

            Console.WriteLine("\nБольшее значение:");
            MoreArr(more, mas);

            Console.WriteLine("\nМеньшее значение:");
            LesserAr(lesser, mas);

            Console.WriteLine(Array.BinarySearch(mas, k));
        }
    }
}
