using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    public class Binary
    {
        public string a = String.Empty;
        public string b = String.Empty;

        public long count;

        public Binary(string a, string b)
        {
            this.a = a;
            this.b = b;
        }

        public void BinSum()
        {
            var s1 = (Convert.ToInt64(a, 2));
            var s2 = (Convert.ToInt64(b, 2));

            count = s1 + s2;
            Console.WriteLine($"Сумма двоичных чисел: {Convert.ToString(count, 2)}");
            Console.WriteLine($"Преобразование в десятичное: {count}");
        }

        public void BinSub()
        {
            var s1 = (Convert.ToInt64(a, 2));
            var s2 = (Convert.ToInt64(b, 2));

            count = s1 - s2;
            Console.WriteLine($"Вычитание двоичных чисел: {Convert.ToString(count, 2)}");
            Console.WriteLine($"Преобразование в десятичное: {count}");
        }

        public void BinMult()
        {
            var s1 = (Convert.ToInt64(a, 2));
            var s2 = (Convert.ToInt64(b, 2));

            count = s1 * s2;
            Console.WriteLine($"Произведение двоичных чисел: {Convert.ToString(count, 2)}");
            Console.WriteLine($"Преобразование в десятичное: {count}");
        }

        public void BinDiv()
        {
            var s1 = (Convert.ToInt64(a, 2));
            var s2 = (Convert.ToInt64(b, 2));

            count = s1 / s2;
            Console.WriteLine($"Деление двоичных чисел: {Convert.ToString(count, 2)}");
            Console.WriteLine($"Преобразование в десятичное: {count}");
        }

    }
}
