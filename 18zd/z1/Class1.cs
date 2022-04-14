using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    public class Triangle
    {
        public int P { get; set; }
        public double S { get; set; }

        public int s1, s2, s3;

        public Triangle(int s1, int s2, int s3) : base()
        {
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
        }

        public void Check()
        {
            int sum = s1 + s2 + s3;

            if (sum >= 3)
            {
                Console.WriteLine("Треугольник существует");
            }
            else
            {
                Console.WriteLine("Треугольник ещё не создан");
            }
        }

        public virtual void Perimetr()
        {
            P = s1 + s2 + s3;
            Console.WriteLine($"Периметр треугольника: {P}");
        }

        public virtual void Square()
        {
            double a = (s1 + s2 + s3 / 2);
            S = Math.Sqrt(a * (a - s1) * (a - s2) * (a - s3));
            Console.WriteLine($"Площадь треугольника: {S}");
        }

        public void ViewTriangle()
        {
            if (s1 == s2 & s1 == s3 & s2 == s3)
            {
                Console.WriteLine("Равносторонний труегольник");
            }

            if (s1 == s2 || s1 == s3 || s2 == s3)
            {
                Console.WriteLine("Равнобедренный треугольник");
            }

            if (s1 != s2 & s1 != s3 & s2 != s3)
            {
                Console.WriteLine("Разносторонний труегольник");
            }
        }
    }

    public class Rectangle : Triangle
    {
        public Rectangle(int s1, int s2, int s3) : base(s1, s2, s3)
        {
            this.s1 = s1;
            this.s2 = s2;
        }

        public override void Perimetr()
        {
            P = s1 + s1 + s2 + s2;
            Console.WriteLine($"Периметр прямоугольника: {P}");
        }

        public override void Square()
        {
            S = s1 * s2;
            Console.WriteLine($"Площадь прямоугольника: {S}");
        }
    }
}
