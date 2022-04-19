using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "abc#d##c";
            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                if (c == '#' && stack.Count > 0)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }

            }

            var st = new string(stack.Reverse().ToArray());
            Console.WriteLine(st);
        }
    }
}
