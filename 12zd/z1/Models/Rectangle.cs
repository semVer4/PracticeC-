using System;

namespace z1
{
    internal partial class Program
    {
        class Rectangle:Quadrilateral
        {
            public int Aside = 1;
            public int Bside = 1;
            public double S = 1;

            public Rectangle(string name):base(name)
            {
                this.Aside = 1;
                this.Bside = 1;
                this.S = 1;

                Input();
            }

            public virtual void Input()
            {
                Console.WriteLine("Введите длину сторон прямоугольника:");

                Console.Write("A:");
                Aside = Convert.ToInt32(Console.ReadLine());

                Console.Write("B:");
                Bside = Convert.ToInt32(Console.ReadLine());
            }
                
            public virtual double FigureArea()
            {
                S = Aside * Bside;
                return S;
            }

            public override void GetInfo()
            {
                Console.WriteLine($"Название: {name}, Сторона A: {Aside}, Сторона B: {Bside}," +
                    $" Площадь: {FigureArea()}");
            }
        }
    }
}
