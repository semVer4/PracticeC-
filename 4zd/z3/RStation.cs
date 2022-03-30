using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class RStation      //класс вокзал
    {
        List<Train> Trains = new List<Train>();     //объявление коллекции поездов

        public Train this[int index]    //пользовательский индексатор для класса
        {
            get
            {
                return Trains[index];
            }
            set
            {
                if (index >= 0 && value is Train)
                {
                    Trains.Add(value);
                    Trains.Sort();
                }
            }
        }

        public void Add()       //метод добавления поезда в коллекцию
        {
            int namber = 0;
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.Write("Введите номер поезда: ");
                    namber = Convert.ToInt32(Console.ReadLine());
                    flag = !flag;
                }
                catch
                {
                    Console.WriteLine("Неверный формат номера");
                }
            }

            Console.Write("Введите конечный пункт назначения: ");
            string NameStation = Console.ReadLine();
            Train train = new Train(NameStation, namber);
            Trains.Add(train);
            Trains.Sort();
        }
        public void ShowLastTime()  //метод для вывода информации поездов отправляемых после заданного времени
        {
            Console.Write("Введите время для сравнения: ");
            Train p1 = new Train("null", 1);
            for (int i = 0; i < Trains.Count; i++)
                if (p1 < this[i])
                    this[i].ShowInfo();
        }

        public void ShowNameStation() //метод для вывода ин-ии о поездах, отправляющихся в заданный пункт назначения
        {
            Console.Write("Введите пункт назначения: ");
            string punkt = Console.ReadLine();
            int num = 0;
            for (int i = 0; i < Trains.Count; i++)
            {
                if (Trains[i].NameStation == punkt)
                {
                    Console.WriteLine(Trains[i]);
                    num++;
                }
            }
            if (num == 0)
                Console.WriteLine("В заданный пункт назначения поезда не ходят!");
        }
    }
}
