using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Person pers = new Person("Name1", 20);
            ObjectInfo.Info<Person>(pers);

            Operations operations = new Operations();
            Dictionary<int, string> dictionary = new Dictionary<int, string>(2);
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Введите название");
                string name = null;
                name = Console.ReadLine();
                Console.WriteLine("Введите возраст");
                int age = int.Parse(Console.ReadLine());

                operations.Add(new Person(name, age));
            }

            foreach (KeyValuePair<int, string> keyValue in dictionary)
            {
                Console.WriteLine($"{keyValue.Key} - {keyValue.Value}");
            }

            foreach (Person x in operations)
            {
                x.GetInfo();
            }

            operations.RemoveAt(1);

            Operations cl = (Operations)operations.Clone();
            foreach (Person x in cl)
            {
                x.GetInfo();
            }
        }
    }
}
