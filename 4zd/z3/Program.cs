using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RStation station = new RStation();
            int count = 4;
            for (int i = 0; i < count; i++)
            {
                station.Add();
            }
            station[0].ShowInfo();
            station[1].ShowInfo();
            station[2].ShowInfo();
            station[3].ShowInfo();
            station.ShowLastTime();
            station.ShowNameStation();
        }
    }
}
