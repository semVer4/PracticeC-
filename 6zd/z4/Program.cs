using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    internal class Program
    {
        public static void SalaryInfo(int a, int b, int[,] salary)
        {
            Random random = new Random();

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    salary[i, j] = random.Next(300, 800);
                    Console.Write(salary[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void FebruarySum(int sumF, int[,] salary)
        {
            for(int i = 0; i < salary.GetLength(0); i++)
            {
                sumF = sumF + salary[i, 2];
            }

            Console.WriteLine(sumF);
        }

        public static void OctoberSum(int sumO, int[,] salary)
        {
            for (int i = 0; i < salary.GetLength(0); i++)
            {
                sumO = sumO + salary[i, 10];
            }

            Console.WriteLine(sumO);
        }

        static void Main(string[] args)
        {
            int a = 20;
            int b = 12;

            int[,] salary = new int[a, b];

            Console.WriteLine("Информация о зарплате:");
            SalaryInfo(20, 12, salary);

            int sum0 = 0;
            int sum1 = 0;

            Console.WriteLine("\nОбщая зарплата в феврале");
            FebruarySum(sum0, salary);

            Console.WriteLine("\nОбщая зарплата в октябре");
            OctoberSum(sum1, salary);

            if(sum0 > sum1)
            {
                Console.WriteLine("\nОбщая зарплата в феврале больше");
            } else
            {
                Console.WriteLine("\nОбщая зарплата в октябре больше");
            }
        }
    }
}
