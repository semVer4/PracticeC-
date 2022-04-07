using System;

namespace z1
{
    internal partial class Program
    {
        class Product
        {
            private int count;
            private double cost;

            public Product()
            {
                count = 0;
                cost = 0;

                Input();
            }

            public void GetInfo()
            {
                Console.WriteLine($"Цена товара: {cost}\nКол-во товаров: {count}");
            }

            public int Count { get { return count; } set { count = value; } }
            public double Cost { get { return cost; } set { cost = value; } }
            
            public void Input()
            {
                Console.WriteLine("Количество товаров:");
                count = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
