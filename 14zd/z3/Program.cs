using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    internal partial class Program
    {
        public static string Input(string mes)
        {
            Console.WriteLine(mes);
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            MyInfo info = new MyInfo();
            Person person = new Person();

            info.Resp += person.Message;
            var name = Input("Name:");

            info.OnResp(name);
        }
    }
}
