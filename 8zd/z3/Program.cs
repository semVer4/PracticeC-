using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace z3
{
    internal class Program
    {
        public static void SearchNumber(string text)
        {
            string pattern = @"\b(\d+\W?)";
            Regex regex = new Regex(pattern);

            foreach (Match match in regex.Matches(text))
            {
                Console.WriteLine(match.Value);
            }
        }

        static void Main(string[] args)
        {
            SearchNumber(Console.ReadLine());
        }
    }
}
