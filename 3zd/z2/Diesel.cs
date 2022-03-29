using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    public class Diesel : Engine
    {
        public int Power1;
        public Diesel(string name, int power, int power1) : base(name)
        {
            this.Power1 = power1;
        }
        public void PrintPower1()
        {
            Console.WriteLine(this.Power1);
        }
    }
}
