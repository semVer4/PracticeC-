using System;

namespace z2
{
    internal partial class Program
    {
        class B :A
        {
            public float d;

            public float C2
            {
                get
                {
                    switch(d)
                    {
                        case 0:
                            Console.WriteLine("Введите число > 0");
                            d = Convert.ToInt32(Console.ReadLine());
                            break;
                    }

                    return a + b + d;
                }
            }
            public B(float a, float b) : base(a, b)
            {
                this.a = a;
                this.b = b;
            }
            public B(float a, float b, float d) : this(a, b)
            {
                this.a = a;
                this.b = b;
                this.d = d;
            }
        }
    }
}
