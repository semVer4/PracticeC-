using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace z1
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Quadrilateral[] quadrilaterals = new Quadrilateral[count] ;

            foreach(Quadrilateral quadrilateral in quadrilaterals)
            {
                quadrilateral.GetInfo();
            }
            for(int i = 0;i<count;i++)
            {
                quadrilaterals[i] = new Rectangle(Console.ReadLine());
            }
            foreach(Quadrilateral quadrilateral in quadrilaterals)
            {
                quadrilateral.GetInfo();
            }
            var qMax = quadrilaterals.Max(p => p.GetInfo);
        }
    }
}
