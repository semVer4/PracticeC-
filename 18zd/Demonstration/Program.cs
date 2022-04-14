using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using z1;
using z2;

namespace Demonstration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int st = Convert.ToInt32(Console.ReadLine());
            int st1 = Convert.ToInt32(Console.ReadLine());
            int st2 = Convert.ToInt32(Console.ReadLine());

            Triangle triangle = new Triangle(st, st1, st2);
            triangle.Perimetr();
            triangle.Square();
            triangle.ViewTriangle();

            Rectangle rectangle = new Rectangle(st, st1, st2);
            rectangle.Perimetr();
            rectangle.Square();

            Game game = new Game();
            game.Game1();

            int a = Convert.ToInt32(Console.ReadLine());
            Game2 game2 = new Game2(a);
            game2.Game1();
        }
    }
}
