using System;

namespace z1
{
    internal partial class Program
    {
        class Square:Quadrilateral
        {
            public int Aside = 1;
            public double S = 1;

            public Square(string name):base(name)
            {
                this.Aside = 1;
                this.S = 1;

                Input();
            }

            public virtual void Input()
            {
                Console.WriteLine("Введите сторону квадрата:");

                Console.Write("A:");
                Aside = Convert.ToInt32(Console.ReadLine());
            }

            public virtual double FigureArea()
            {
                S = Aside * Aside;
                return S;
            }

            public override void GetInfo()
            {
                Console.WriteLine($"Название: {name}, Сторона A: {Aside}," +
                    $" Площадь: {S}");
            }
        }
    }
}
