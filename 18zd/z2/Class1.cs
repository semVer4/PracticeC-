using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    public class Game
    {
        public Random rand { get; set; }

        public Game()
        {
            rand = new Random();
        }

        public virtual void Game1()
        {
            int a = rand.Next(1, 3);

            if (a == 1) Console.WriteLine("Орёл"); else Console.WriteLine("Решка");
        }
    }

    public class Game2 : Game
    {
        int A { get; set; }

        public Game2(int A)
        {
            this.A = A;
        }

        public override void Game1()
        {
            int n = rand.Next(1, 4);

            string loss = "Проигрыш!";
            string winning = "Вы выйграли! ";

            switch (A)
            {
                case 1:
                    if (n == 1 && A == 1) Console.WriteLine($"{winning} + Выпал камень"); else Console.WriteLine(loss);
                    break;

                case 2:
                    if (n == 2 && A == 2) Console.WriteLine($"{winning} + Выпали ножницы"); else Console.WriteLine(loss);
                    break;

                case 3:
                    if (n == 3 && A == 3) Console.WriteLine($"{winning} + Выпала бумага"); else Console.WriteLine(loss);
                    break;
            }
        }
    }
}
