using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    public class SearchArr
    {
        public double[,] mas;
        int rows;
        int colums;

        public static bool operator ==(SearchArr current, SearchArr mas)
        {
            if (current.rows != mas.rows || current.colums != mas.colums)
            {
                return false;
            }
            for (int i = 0; i < current.rows; i++)
            {
                for (int j = 0; j < current.colums; j++)
                {
                    if (current[i, j] != mas[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator !=(SearchArr current, SearchArr mas)
        {
            if (current.rows != mas.rows || current.colums != mas.colums)
            {
                return true;
            }
            for (int i = 0; i < current.rows; i++)
            {
                for (int j = 0; j < current.colums; j++)
                {
                    if (current[i, j] != mas[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public SearchArr(int rows, int colums)
        {
            this.rows = rows;
            this.colums = colums;

            mas = new double[rows, colums];

        }
        public double this[int index1, int index2]
        {
            get { return mas[index1, index2]; }
            set { mas[index1, index2] = value; }
        }

        double count = 1;
        public void Swap()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (mas[i, j] < 10 && mas[i, j] > 0)
                    {
                        count = count * mas[i, j];
                    }
                }
                Console.WriteLine($"Произведение положительных элементов < 10: {count}");
            }
        }
        public void CreatMas()
        {

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write("Введите элемент [{0},{1}] : ", i, j);
                    mas[i, j] = double.Parse(Console.ReadLine());
                }
            }
        }
    }

}
