using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    public class Engine
    {
        public string Name;
        public Engine(string name)
        {
            this.Name = name;
        }
        public void PrintName()
        {
            Console.WriteLine(this.Name);
        }
    }
}
