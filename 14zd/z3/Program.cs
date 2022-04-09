using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    internal class Program
    {
        public class MyInfo
        {
            public string name = "Никита";

            public delegate void Response(string name);
            public event Response Resp;

            public void OnResp(string a)
            {
                if (name != a)
                {
                    Resp(a);
                    name = a;
                }
            }
        }

        public class Person
        {
            public void Message(string mes)
            {
                Console.WriteLine($"Имя изменено на {mes}");
            }
        }

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
