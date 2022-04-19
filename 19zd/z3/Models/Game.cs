using System;

namespace z3
{
    internal partial class Program
    {
        class Game
        {
            public string name;
            public int age;

            public Game(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public virtual void GetInfo()
            {
                Console.WriteLine($"Название: {name}\nВозраст: {age}");
            }
        }
    }
}
