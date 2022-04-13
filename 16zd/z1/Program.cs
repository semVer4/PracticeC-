using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            MyList<int> mylist = new MyList<int>();

            for (int i = 0; i < 10; i++)
            {
                mylist.Add(i);
                Console.WriteLine(mylist[i]);
            } 

            Console.WriteLine(mylist.Count);
        }
    }
}
