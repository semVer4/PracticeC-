namespace z2
{
    internal partial class Program
    {
        class A
        {
            protected float a;
            protected float b;

            public float C
            {
                get { return a / b; }
            }
            public A(float a, float b)
            {
                this.a = a;
                this.b = b;
            }
        }
    }
}
