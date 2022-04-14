namespace ClassLibrary1
{
    public class Triangle
    {
        public int count { get; set; }

        public int s1, s2, s3, s4;

        public Triangle(int s1, int s2, int s3) : base()
        {
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
        }

        public void Check()
        {
            int sum = s1 + s2 + s3;

            if (sum >= 3)
            {
                Console.WriteLine("Треугольник существует");
            }
            else
            {
                Console.WriteLine("Треугольник ещё не создан");
            }
        }

        public virtual int Perimetr()
        {
            count = s1 + s2 + s3;
            return count;
        }

        public void ViewTriangle()
        {
            if (s1 == s2 & s1 == s3 & s2 == s3)
            {
                Console.WriteLine("Равносторонний труегольник");
            }

            if (s1 == s2 || s1 == s3 || s2 == s3)
            {
                Console.WriteLine("Равнобедренный треугольник");
            }

            if (s1 != s2 & s1 != s3 & s2 != s3)
            {
                Console.WriteLine("Разносторонний труегольник");
            }
        }
    }

    public class Rectangle : Triangle
    {
        public Rectangle(int s1, int s2, int s3, int s4) : base(s1, s2, s3)
        {
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
            this.s4 = s4;
        }

        public override int Perimetr()
        {
            count = s1 + s2 + s3 + s4;
            return count;
        }
    }
}