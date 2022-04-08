using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    delegate int MathOperations(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите действие: ");
            string x = Console.ReadLine();

            switch (x)
            {
                case "+":
                    MathOperations OpAdd = (a, b) => a + b;
                    Console.WriteLine(OpAdd(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                    break;
                case "-":
                    MathOperations OpSub = (a, b) => a - b;
                    Console.WriteLine(OpSub(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                    break;
                case "*":
                    MathOperations OpMul = (a, b) => a * b;
                    Console.WriteLine(OpMul(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                    break;
                case "/":
                    MathOperations OpDiv = (a, b) => b == 0 ? 0 : a / b;
                    Console.WriteLine(OpDiv(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                    break;
            }
        }
    }
}
