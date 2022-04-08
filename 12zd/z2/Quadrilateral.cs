using System;

namespace z1
{
    internal partial class Program
    {
        abstract class Quadrilateral
        {
            public string name { get; set; }

            public Quadrilateral(string name)
            {
                this.name = name;
            }

            public abstract void GetInfo();
        }
    }
}
