using System;

namespace z1
{
    internal partial class Program
    {
        class Marker :Product
        {
            string name;
            double grade;

            public Marker():base()
            {
                name = String.Empty;
                grade = 0;

                Input();
            }

            public void Input()
            {
                Console.WriteLine("Название товара:");
                name = Console.ReadLine();

                Console.WriteLine("Сорт товара:");
                grade = Convert.ToInt32(Console.ReadLine());
            }

            public override void ChangeCost()
            {
                Cost = 1 / Math.Sqrt(grade);
            }

            public void GetInfo()
            {
                Console.WriteLine($"Название товара: {name}\nКол-во товаров: {Count}" +
                    $"\nЦена товара: {Cost}\nСорт товара: {grade}");    
            }
        }
    }
}
