 using System;

namespace z1
{
    internal partial class Program
    {
        class Quadrilateral
        {
            public string name { get; set; }

            public Quadrilateral(string name)
            {
                this.name = name;
            }

            public virtual void GetInfo()
            {
                Console.WriteLine($"Название: {name}");
            }
        }
    }
}
