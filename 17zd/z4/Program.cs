using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace z4
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

        static void StrReplace(string[] mas)
        {
            StreamWriter st = new StreamWriter("f1.txt");

            foreach (string s in mas)
            {
                for (var i = 0; i < s.Length; i++)
                {
                    st.Write(Convert.ToChar(s[i]) == '1' ? '0' : Convert.ToChar(s[i]) == 
                        '0' ? '1' : Convert.ToChar(s[i]));
                }
            }

            st.Close();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Запишите 5 строк:");
            FileRecorder();

            Console.WriteLine("\nВывод всего файла:");
            string[] mas = FilePrint();

            Console.WriteLine("\nФайл добавлен и изменен");
            StrReplace(mas);
        }
    }
}
