using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    internal class Program
    {
        public class WorkArr
        {
            //int x = 5;
            double[,] mas = new double[5, 5];

            Random random = new Random();

            double count = 1;

            public void ArrFilling()
            {
                for (int i = 1; i < 5; i++)
                {
                    for (int j = 1; j < 5; j++)
                    {
                        mas[i, j] = random.Next(20);
                        if(mas[i, j] < 10)
                        {
                            count = count *= mas[i, j];
                            //Console.WriteLine(count);
                        }
                    }
                }

                Console.WriteLine(count);
            }

            /*public void ArrSearch()
            {
                double count = 1;

                if (arr < 10)
                {
                    count = count *= arr;
                    Console.WriteLine(arr);
                }

                Console.WriteLine($"Произведение: {count}");
            }*/
        }

        static void Main(string[] args)
        { 
            WorkArr workArr = new WorkArr();
            workArr.ArrFilling();
        }
    }
}
