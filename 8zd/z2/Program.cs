using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace z2
{
    internal class Program
    {
        public static void SearchLetter(string text)
        {
            string pattern = @"([\w]{1})\1";
            Regex rg = new Regex(pattern, RegexOptions.IgnoreCase);

            MatchCollection matches = rg.Matches(text);

            foreach(Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }

        static void Main(string[] args)
        {
            SearchLetter(Console.ReadLine());
        }
    }
}
