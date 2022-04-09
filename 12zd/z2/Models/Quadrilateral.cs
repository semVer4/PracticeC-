using System;

namespace z1
{ 
    internal partial class Program
    {
        abstract class Quadrilateral
        {
            public string name { get; set; }
            public double S = 1;

            public Quadrilateral(string name)
            {
                this.name = name;
            }

            public abstract double FigureArea()
            {
                return S;
            }

            public abstract void GetInfo();
        }
    }
}
