using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace z1
{
    internal partial class Program
    {
        struct Note
        {
            string name, surname;
            string phone;
            int[] birthDay;

            public Note[] Filling()
            {
                Note[] info = new Note[2];

                for(int i = 0; i < info.Length; i++)
                {
                    Console.Write("Имя: ");
                    info[i].name = Console.ReadLine();

                    Console.Write("Фамилия: ");
                    info[i].surname = Console.ReadLine();

                    Console.Write("Телефон: ");
                    info[i].phone = Console.ReadLine();

                    Console.WriteLine("День Рождения: ");
                    info[i].birthDay = new int[3];

                    for(int j = 0; j < info[i].birthDay.Length; j++)
                    {
                        info[i].birthDay[j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                return info;
            }

            public void PrintInfo(Note[] info)
            {
                for(int i = 0; i < info.Length; i++)
                {
                    Console.WriteLine($"\nИмя: {info[i].name}");
                    Console.WriteLine($"Фамилия: {info[i].surname}");
                    Console.WriteLine($"Телефон: {info[i].phone}");

                    Console.Write("День рождения: ");
                    for(int j = 0; j < info[i].birthDay.Length; j++)
                    {
                        Console.Write(info[i].birthDay[j] + ".");
                    }

                    Console.WriteLine("\n");
                }
            }

            public void SortInfo(Note[] info)
            {
                Array.Sort(info, (n, n1) => String.Compare(n.name, n1.name));
                Array.Sort(info, (s, s1) => String.Compare(s.surname, s1.surname));
            }

            public void InfoBD(Note[] info, string month)
            {
                Console.WriteLine("Информация о людях, чьи дни рождения приходятся на месяц:");
                for(int i = 0; i < info.Length; i++)
                {
                    if(info[i].birthDay[1] == Convert.ToInt32(month))
                    {
                        Console.WriteLine($"Имя: {info[i].name}");
                        Console.WriteLine($"Фамилия: {info[i].surname}");
                        Console.WriteLine($"Телефон: {info[i].phone}\n");
                    }
                } 
            }
        }
    }
}
