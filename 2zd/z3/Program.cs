using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());

            var cart = new Dictionary<int, string>()
            {
                {1, "пики"},
                {2, "трефы"},
                {3, "бубны"},
                {4, "червы"}
            };

            switch (k)
            {
                case 6:
                {
                    Console.WriteLine($"Шестерка - {cart[m]}");
                    break;
                }

                case 7:
                {
                    Console.WriteLine($"Семёрка - {cart[m]}");
                    break;
                }

                case 8:
                {
                    Console.WriteLine($"Восьмёрка - {cart[m]}");
                    break;
                }

                case 9:
                {
                    Console.WriteLine($"Девятка - {cart[m]}");
                    break;
                }

                case 10:
                {
                    Console.WriteLine($"Десятка - {cart[m]}");
                    break;
                }

                case 11:
                {
                    Console.WriteLine($"Валет - {cart[m]}");
                    break;
                }

                case 12:
                {
                    Console.WriteLine($"Дама - {cart[m]}");
                    break;
                }

                case 13:
                {
                    Console.WriteLine($"Король - {cart[m]}");
                    break;
                }

                case 14:
                {
                    Console.WriteLine($"Туз - {cart[m]}");
                    break;
                }
            }
        }
    }
}
