using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    internal class Program
    {
        public static void StrPrint(string text)
        {
            string[] result = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in result)
            {
                if (line.Last() == line.First())
                    Console.WriteLine($"Результат: {line}");
            }
        }

        static void Main(string[] args)
        {
            StrPrint(Console.ReadLine());
        }
    }
}
