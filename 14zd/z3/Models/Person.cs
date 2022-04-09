using System;

namespace z3
{
    internal partial class Program
    {
        public class Person
        {
            public void Message(string mes)
            {
                Console.WriteLine($"Имя изменено на {mes}");
            }
        }
    }
}
