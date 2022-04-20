using System;

namespace z1
{
    internal partial class Program
    {
        class ElectricMove : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Перемещение на электричестве");
            }
        }
    }
}
