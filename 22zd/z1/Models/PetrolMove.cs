using System;

namespace z1
{
    internal partial class Program
    {
        class PetrolMove : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Перемещение на бензине");
            }
        }
    }
}
