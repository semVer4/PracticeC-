using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace z1
{
    internal class Program
    {
        public interface IStrategy
        {
            void Algorithm();
        }

        public class ConcreteStrategy1 : IStrategy
        {
            public void Algorithm() {}
        }

        public class ConcreteStrategy2 : IStrategy
        {
            public void Algorithm() {}
        }

        public class Context
        {
            public IStrategy ContextStrategy { get; set; }

            public Context(IStrategy _strategy)
            {
                ContextStrategy = _strategy;
            }

            public void ExecuteAlgorithm()
            {
                ContextStrategy.Algorithm();
            }
        }

        static void Main(string[] args)
        {
            Car auto = new Car(4, "Mercedes", new PetrolMove());
            auto.Move();
            auto.Movable = new ElectricMove();
            auto.Move();
        }

        interface IMovable
        {
            void Move();
        }

        class PetrolMove : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Перемещение на бензине");
            }
        }

        class ElectricMove : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Перемещение на электричестве");
            }
        }

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
