using System;
using System.Collections;
using System.Collections.Generic;                   
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    internal class Program
    {
        static void PrintHash(Hashtable hash)
        {
            ICollection key = hash.Keys;

            foreach (var s in key)
            {
                Console.WriteLine($"{s}, {hash[s]}");
            }
        }

        static void Main(string[] args)
        {
            Hashtable disk = new Hashtable();
            Hashtable song = new Hashtable();

            disk.Add(1, "Pop");
            disk.Add(2, "Rock");
            disk.Add(3, "Metal");

            song.Add(1, "PP");
            song.Add(2, "KK");
            song.Add(3, "JJ");

            ICollection key = disk.Keys;

            Console.WriteLine("Выберите один из пунктов:\n1) Добавление диска, 2) Удаление диска," +
                "\n3) Добавление песни, 4) Удаление песни, \n5) Просмотр дисков, 6) Просмотр песен\n7) Выход");

            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    {
                        disk.Add(Console.ReadLine(), Console.ReadLine());
                        PrintHash(disk);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Номер диска: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        if (num == 1)
                        {
                            disk.Remove(1);
                        }
                        else if (num == 2)
                        {
                            disk.Remove(2);
                        }
                        else if (num == 3)
                        {
                            disk.Remove(3);
                        }
                        else if (num == 4)
                        {
                            disk.Remove(4);
                        }
                        PrintHash(disk);
                        break;
                    }
                case 3:
                    {
                        song.Add(Console.ReadLine(), Console.ReadLine());
                        PrintHash(song);
                        break;
                    }
                case 4:
                    {
                        Console.Write("Номер песни: ");
                        int numS = Convert.ToInt32(Console.ReadLine());

                        if (numS == 1) song.Remove(1);
                        else if (numS == 2) song.Remove(2);
                        else if (numS == 3) song.Remove(3);
                        else if (numS == 4) song.Remove(4);

                        PrintHash(song);
                        break;
                    }
                case 5:
                    {
                        PrintHash(disk);
                        break;
                    }
                case 6:
                    {
                        PrintHash(song);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error");
                        break;
                    }
            }
        }
    }
}
