using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    internal class Program
    {
        static public void Replace(string s)
        {
            string[] split = s.Split(' ');
            string splitStr = split[split.Length - 1];
            for (int i = 1; i < split.Length - 1; i++)
            {
                splitStr += " " + split[i];
                splitStr += " " + split[0];
                Console.WriteLine(splitStr);
            }
        }
        static public string Gluing(string s)
        {
            string[] split = s.Split(' ');
            string splitStr = split[split.Length - 1];
            for (int i = 0; i < split.Length - 1; i++)
            {
                splitStr = split[1] + split[2];

            }
            return splitStr;
        }
        static public string PrintReverse(string s)
        {
            string[] split = s.Split(' ');
            string a = split[split.Length - 1];
            for (int i = 0; i < split.Length - 1; i++)
            {
                a = split[2];
            }
            return a;

        }
        static public string Cutting(string s)
        {
            string[] split = s.Split(' ');
            string firstWord = split[split.Length - 1];
            for (int i = 0; i < split.Length - 1; i++)
            {
                firstWord = split[0];
            }
            return firstWord;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Склеянные: {Gluing(Console.ReadLine())}");

            Console.WriteLine($"1 и последнее слова поменялись местами");
            Replace(Console.ReadLine());

            string print = PrintReverse(Console.ReadLine());
            var rString = new string(print.Reverse().ToArray());
            string.Join("", print.Reverse());

            Console.WriteLine($"Обратный порядок: {rString}");
            var firstWord = Cutting(Console.ReadLine());
            StringBuilder sb = new StringBuilder(firstWord);

            Console.WriteLine($"Без 2 букв: {sb.Remove(0, 2)}");
        }
    }
}
