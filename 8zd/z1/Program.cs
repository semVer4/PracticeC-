using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace z1
{
    internal class Program
    {
        public static void FindingC(string text)
        {
            string pattern = @"\b[бвгджзйклмнпрстфхцчшщ]{3,}\S+\b";
            Regex rg = new Regex(pattern, RegexOptions.IgnoreCase);

            MatchCollection matches = rg.Matches(text);

            foreach (Match match in matches)
                Console.WriteLine($"Результат: {match.Value}");
        }

        static void Main(string[] args)
        {
            FindingC(Console.ReadLine());
        }
    }
}
