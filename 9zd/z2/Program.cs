using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    internal class Program
    {
        enum Post
        {
            Chief = 150,
            Engineer = 200,
            Driver = 50,
            Manager = 160,
            Clerk = 250
        }

        class Accauntat
        {
            public bool AskForBonus(Post worker, int hours)
            {
                return hours <= Convert.ToInt32(worker);
            }
        }
        static void Main(string[] args)
        {
            Accauntat acPrint = new Accauntat();
            Console.WriteLine(acPrint.AskForBonus(Post.Engineer, 155));
        }
    }
}
