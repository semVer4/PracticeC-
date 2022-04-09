using System;

namespace z4
{
    internal partial class Program
    {
        class TunAssembly
        {
            public void Message(string mes)
            {
                Console.WriteLine($"Данная модель ({mes}) не соответсвует нашей тюнинг-сборке!");
            }
        }
    }
}
