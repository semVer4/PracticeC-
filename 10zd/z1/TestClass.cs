using System;

namespace z1
{
    internal partial class Program
    {
        class TestClass:Ix, Iy, Iz
        {
            public int w;

            public TestClass()
            {
                w = 5;
            }

            public TestClass(int xKey)
            {
                w = xKey;
            }

            public void IxF0(int xKey)
            {
                w = 7 * w;
                Console.WriteLine($"IxF0: {w}");
            }

            public void IxF1()
            {
                w = w * 7;
                Console.WriteLine($"IxF1: {w}");
            }

            void Iz.F0(int xKey)
            {
                w = xKey * 8;
                Console.WriteLine($"Iz.F0: {w}");
            }

            void Iz.F1()
            {
                w = w * 8;
                Console.WriteLine($"Iz.F1: {w}");
            }

            public void F0(int xKey)
            {
                w = 6 + xKey;
                Console.WriteLine($"F0: {w}");
            }

            public void F1()
            {
                w = 6 + w;
                Console.WriteLine($"F1: {w}");
            }
        }
    }
}
