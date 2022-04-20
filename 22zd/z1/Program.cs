using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace z1
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Car auto = new Car(4, "Mercedes", new PetrolMove());
            auto.Move();
            auto.Movable = new ElectricMove();
            auto.Move();
        }
    }
}
