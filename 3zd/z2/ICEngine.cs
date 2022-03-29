using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    public class ICEngine : Engine
    {
        public int Power;
        public ICEngine(string name, int power) : base(name)
        {
            this.Power = power;
        }
        public void PrintPower()
        {
            Console.WriteLine(this.Power);
        }
    }
}
