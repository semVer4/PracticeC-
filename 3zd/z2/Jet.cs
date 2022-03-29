using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    public class Jet : Engine
    {
        public int Power2;
        public Jet(string name, int power, int power1, int power2) : base(name)
        {
            this.Power2 = power2;
        }
        public void PrintPower2()
        {
            Console.WriteLine(this.Power2);
        }
    }
}
