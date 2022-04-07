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
            Marker marker = new Marker();
            marker.ChangeCost(); 
            marker.GetInfo();
        }
    }
}
