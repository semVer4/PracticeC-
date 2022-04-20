namespace z1
{
    internal partial class Program
    {
        class Car
        {
            protected int passengers; 
            protected string model; 

            public Car(int num, string model, IMovable mov)
            {
                this.passengers = num;
                this.model = model;
                Movable = mov;
            }

            public IMovable Movable { private get; set; }
            public void Move()
            {
                Movable.Move();
            }
        }
    }
}
