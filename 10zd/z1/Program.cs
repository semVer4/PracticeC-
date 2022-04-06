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
            TestClass test = new TestClass();

            int w = 5;

            test.F0(w);
            test.F1();

            test.IxF0(w);
            test.IxF1();

            var obj = test as Iz;
            obj.F0(w);
            obj.F1();
        }
    }
}
