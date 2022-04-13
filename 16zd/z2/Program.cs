using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace z2
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            dictionary.Add(1, 2);
            dictionary.Add(2, 3);

            Console.WriteLine(dictionary.Count);

            foreach (var i in dictionary)
            {
                Console.WriteLine(i);
            }
        }
    }
}
