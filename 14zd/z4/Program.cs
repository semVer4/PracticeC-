using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Info info = new Info();
            Auto auto = new Auto();
            TunAssembly t = new TunAssembly();

            info.Resp += auto.Message;
            info.Resp += auto.CallMes;
            info.Resp += t.Message;

            Console.WriteLine("Введите модель:");
            var model = Console.ReadLine();
            info.OnResp(model);

            Console.WriteLine("Отписка\nВведите модель:");
            var modelEnd = Console.ReadLine();
            info.Resp -= auto.Message;
            info.OnResp(modelEnd);
        }
    }
}
