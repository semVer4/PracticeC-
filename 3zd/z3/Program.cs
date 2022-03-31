using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using z3.Models;

namespace z3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s1 = Console.ReadLine();
            //string s2 = Console.ReadLine();
            
            //Binary bin = new Binary(s1, s2);
            //bin.BinSum();


            var bNumber1 = new BinaryN("00001");
            var bNumber = new BinaryN("100101001");
            var number = bNumber + bNumber1;
            Console.WriteLine(bNumber);
            Console.WriteLine(bNumber1);
            Console.WriteLine(number);
            //var diff = bNumber - bNumber1;
            Console.ReadLine();
        }
    }
}
