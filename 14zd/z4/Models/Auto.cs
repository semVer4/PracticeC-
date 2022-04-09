using System;

namespace z4
{
    internal partial class Program
    {
        class Auto
        {
            public void Message(string mes)
            {
                Console.WriteLine($"{mes} не является моделью данной марки!");
            }

            public void CallMes(string mes)
            {
                Console.WriteLine($"Возможно модель {mes} изменена");
            }
        }
    }
}
