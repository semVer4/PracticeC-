using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Quadrilateral[] quadrilaterals = new Quadrilateral[] { new Square("F1"), new Rectangle("F2") };

            foreach(Quadrilateral quadrilateral in quadrilaterals)
            {
                quadrilateral.GetInfo();
            }
        }
    }
}
