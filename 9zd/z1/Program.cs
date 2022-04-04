using System;
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
            Note note = new Note();
            Note[] info = note.Filling();

            note.SortInfo(info);
            note.PrintInfo(info);

            Console.Write("\nВведите номер месяца: ");
            note.InfoBD(info, Console.ReadLine());
        }
    }
}
