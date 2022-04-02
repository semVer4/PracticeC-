using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    internal class Program
    {
        static string GetAplhabet()
        {
            StringBuilder sB = new StringBuilder();

            for(char i = 'а'; i <= 'я'; i++)
            {
                sB.Append(i.ToString());
            }
            return sB.ToString();
        }

        public static int[] GetNumber(string text)
        {
            string Alphabet = GetAplhabet();

            int[] array = new int[text.Length];
            for(int i = 0; i < text.Length; i++)
            {
                array[i] = Alphabet.IndexOf(text[i]) + 1;
            }
            return array;
        }

        public static int Sum(int Number)
        {
            int sum = 0;
            while(Number > 0)
            {
                sum += Number % 10;
                Number /= 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            string text = "Рожко Никита Юрьевич";
            string textR = "Рожко Никита Юрьевич".Replace(" ", "").ToLower();
            int[] mas = GetNumber(textR);
            int sum1 = mas.Sum();
            while(sum1 > 9)
            {
                sum1 = Sum(sum1);
            }
            Console.WriteLine(text);
            Console.WriteLine(sum1);
        }
    }
}
