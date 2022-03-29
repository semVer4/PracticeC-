using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    public class Calculation
    {
        public int a;
        public int b;

        public Calculation(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void Calc1()
        {
            double calc = (1 / a + 1 / Math.Sqrt(b));
            Console.WriteLine($"Вычисление в 1 методе: {calc}");
        }

        public void Calc2()
        {
            double calc = Math.Pow(a, 6);
            Console.WriteLine($"Вычисление в 2 методе: {calc}");
        }
    }
}
