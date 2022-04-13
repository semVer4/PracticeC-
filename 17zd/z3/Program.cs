using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace z3
{
    internal class Program
    {
        static void FileRecorder()
        {
            string[] mas = new string[5];

            StreamWriter file = new StreamWriter("f.txt");

            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"Строка: {i}: ");
                mas[i] = Console.ReadLine();

                file.WriteLine(mas[i]);
            }

            Console.WriteLine("Строки записаны");
            file.Close();
        }

        static string[] FilePrint()
        {
            string[] mas = File.ReadAllLines("f.txt");

            foreach (string s in mas)
            {
                Console.WriteLine(s);
            }

            return mas;
        }

        static int StrAmount()
        {
            int count = System.IO.File.ReadAllLines("f.txt").Length;

            return count;
        }

        static void AmountS(string[] mas)
        {
            int i = 0;
            foreach (string s in mas)
            {
                Console.WriteLine($"Строка: {i}, символов: {s.Length}");
                i++;
            }
        }

        static void DeleteStr()
        {
            StreamReader st = new StreamReader("f.txt");
            FileStream file = new FileStream("f2.txt", FileMode.Append, FileAccess.Write);
            StreamWriter file1 = new StreamWriter(file);

            int k = 0, m = 0;
            string a;

            while (!st.EndOfStream)
            {
                a = st.ReadLine();
                k = k + 1;
                m = k;

                if (k != m)
                {
                    file1.WriteLine(a);
                }
            }
        }


        static void StrLength(string[] mas)
        {
            int maxS = 0;
            foreach (string s in mas)
            {
                maxS = Math.Max(maxS, s.Length);
            }

            Console.WriteLine(maxS);
        }

        static void PrintLetter(string letter, string[] mas)
        {
            foreach (string s in mas)
            {
                for (int i = 0; i < letter.Length; i++)
                {
                    if (s[0] == letter[i])
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }

        static void StrOverwriting(int s1, int s2, string[] mas)
        {
            for (s1 = 0; s1 < s2; s1++)
            {
                foreach (string s in mas)
                {
                    Console.WriteLine(s);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Запишите 5 строк:");
            FileRecorder();

            Console.WriteLine("\nВывод всего файла:");
            string[] mas = FilePrint();

            Console.Write($"\nКол-во строк: {StrAmount()}\n");

            Console.WriteLine("\nКол-во символов:");
            AmountS(mas);

            Console.WriteLine("\nУдаление последней строки:\n");
            DeleteStr();

            Console.WriteLine("Вывод строк с s1 по s2:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());
            StrOverwriting(s1, s2, mas);

            Console.WriteLine("\nДлина самой длинной строки:");
            StrLength(mas);

            Console.WriteLine("\nВывод строк начинающихся на заданную букву:");
            Console.Write("Введите букву: ");
            string letter = Console.ReadLine();
            PrintLetter(letter, mas);
        }
    }
}
