using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class Program
    {
        public static void StrPrint(string text)
        {
            string[] lines = text.Split(' ');

            foreach(string line in lines)
            {
                int count = line.Count(char.IsDigit);

                if(count > 0)
                {
                    Console.WriteLine($"Слова с числом: {line}");
                }
            }
        }

        static void Main(string[] args)
        {
            StrPrint(Console.ReadLine());
        }
    }
}
