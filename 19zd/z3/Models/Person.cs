using System;

namespace z3
{
    internal partial class Program
    {
        class Person : Game
        {
            public Person(string name, int age) : base(name, age) {}

            public override void GetInfo()
            {
                Console.WriteLine($"Название: {name}\nВозраст: {age}");
            }
        }
    }
}
