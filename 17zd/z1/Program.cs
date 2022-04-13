using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace z1
{
    internal class Program
    {
        static void FileRecord()
        {
            Random rand = new Random();
            int[] mas = new int[10];

            StreamWriter file = new StreamWriter("f.txt");

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(10, 30);
                file.WriteLine(mas[i]);
            }

            file.Close();
        }

        static int FileReader()
        {
            string[] mas = File.ReadAllLines("f.txt");

            string maxN = mas.Max();
            string minN = mas.Min();

            return Convert.ToInt32(maxN) + Convert.ToInt32(minN);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Рандомные числа записаны в файл");
            FileRecord();

            Console.Write("Сумма максимального и минимального числа: ");
            Console.WriteLine(FileReader());
        }
    }
}
