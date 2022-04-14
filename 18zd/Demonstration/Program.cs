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
            Triangle triangle = new Triangle(2, 3, 4);
            triangle.Perimetr();
            triangle.Square();
            triangle.ViewTriangle();

            Rectangle rectangle = new Rectangle(3, 3, 2);
            rectangle.Perimetr();
            rectangle.Square();

            Game game = new Game();
            game.Game1();

            Game2 game2 = new Game2(2);
            game2.Game1();
        }
    }
}
