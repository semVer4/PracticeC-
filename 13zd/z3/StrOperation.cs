using System;

namespace z3
{
    internal partial class Program
    {
        class StrOperation
        {
            public static string StrReplace(string mes1)
            {
                string repl = mes1.Replace(' ', '.');
                Console.WriteLine($"Замена пробелов на точку: {repl}");

                return repl;
            }

            public static string ToUpper(string mes1)
            {   
                string upper = mes1.ToUpper();
                Console.WriteLine($"Замена букв на прописные: {upper}");

                return upper;
            }

            public static string StrAdd(string mes1)
            {
                var last = mes1[mes1.Length - 1];
                Console.WriteLine($"Вывод последней буквы текста: {last}");

                return Convert.ToString(last);
            }
        }
    }
}
