using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    internal class Program
    {
        public static void ArrFilling(int[,] mas, int a, int b, int n)
        {
            Random random = new Random();
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    mas[i, j] = random.Next(a, b);
                }
            }
        }
        public static void PrintMas(int[,] mas, int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(" " + mas[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void SearchMin(int[,] mas, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int minLine = mas[i, 0];
                for (int j = 0; j < n; j++)
                {
                    if (mas[i, j] < minLine)
                    {
                        minLine = mas[i, j];
                    }
                }
                Console.WriteLine("Строка {0}, значение: {1}", i, minLine);
                Console.WriteLine();
            }
        }

        public static void Sum(int[,] mas)
        {
            double sum = 0;

            for(int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if(mas[i, j] < 0)
                    {
                        double s = Math.Pow(mas[i, j], 2);
                        sum = sum + s;
                    } 
                }
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            int[,] mas = new int[n, n];
            Console.WriteLine("Введите а");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = int.Parse(Console.ReadLine());
            ArrFilling(mas, a, b, n);
            PrintMas(mas, n);

            Console.WriteLine("Найменьший элемент в каждой строке:");
            SearchMin(mas, n);

            Console.WriteLine("Сумма квадратов отрицательных чисел:");
            Sum(mas);
        }
    }
}
