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

        static void DeleteStr(string[] mas)
        {
            string[] writeText = new string[mas.Length - 1];
            Array.Copy(mas, 0, writeText, 0, mas.Length - 1);
            File.WriteAllLines("f2.txt", writeText);
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

        static void PrintsStr(int s1, int s2, string[] mas)
        {
            string a = null;
            string b = null;

            for (int i = 0; i < mas.Length; i++)
            {
                a = mas[s1];
                b = mas[s2];
            }

            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static void StrRewriting(string[] mas)
        {
            StreamWriter sw = new StreamWriter(new FileStream("f3.txt", FileMode.Create, FileAccess.Write));
            
            for (int i = mas.Length; i > 0; i--)
                sw.WriteLine(mas[i - 1]);

            sw.Close();
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

            Console.WriteLine("\nПоследняя строка удалена и перезаписана в другой файл\n");
            DeleteStr(mas);

            Console.WriteLine("\nДлина самой длинной строки:");
            StrLength(mas);

            Console.WriteLine("\nВывод строк начинающихся на заданную букву:");
            Console.Write("Введите букву: ");
            string letter = Console.ReadLine();
            PrintLetter(letter, mas);

            Console.WriteLine("\nВведите промежуток s1, s2: ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());
            PrintsStr(s1, s2, mas);

            Console.WriteLine("\nСтроки перезаписаны в обратном порядке, в другой файл");
            StrRewriting(mas);
        }
    }
}
