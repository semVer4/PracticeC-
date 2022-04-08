using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    internal partial class Program
    {
        public delegate string OperationDl(string a);

        static void Main(string[] args)
        {
            OperationDl dl = new OperationDl(StrOperation.StrReplace);

            dl += StrOperation.ToUpper;
            dl += StrOperation.StrAdd;

            Console.WriteLine("Введите предложение:");
            dl.Invoke(Console.ReadLine());
        }
    }
}
