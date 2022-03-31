using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class Train : IComparable 
    {
        String nameStation; 
        int namber;         
        DateTime time;      
        public String NameStation      
        {
            get { return nameStation; }
            set { nameStation = value; }
        }

        public int Namber           
        {
            get { return namber; }
            set
            {
                if (value > 0)
                    namber = value;
            }
        }

        public DateTime Time        
        {
            get { return time; }
            set { time = value; }
        }

        void SetTime()       
        {
            while (true)
            {
                int hour = 0;
                int minute = 0;
                Console.Write("Введите время отправления поезда: "); 
                string t = Console.ReadLine();
                string h = "";
                string m = "";
                int q;
                bool flag = false;
                for (int i = 0; i < t.Length; i++)
                {
                    if (!flag)
                    {
                        if (Int32.TryParse(Convert.ToString(t[i]), out q))
                        {
                            h = h + t[i];
                        }
                        else
                        {
                            flag = true;
                            continue;
                        }
                    }
                    if (flag)
                    {
                        if (Int32.TryParse(Convert.ToString(t[i]), out q))
                        {
                            m = m + t[i];
                        }
                    }
                }
                try
                {
                    hour = Int32.Parse(h);
                    minute = Int32.Parse(m);
                    Time = new DateTime(2022, 12, 12, hour, minute, 0);
                    return;
                }
                catch
                {
                    Console.WriteLine("Введен неверный формат времени");
                }

            }
        }

        public Train(string NameStation, int Namber)    
        {
            this.NameStation = NameStation;
            this.Namber = Namber;
            SetTime();
        }

        public Train(string NameStation, int Namber, DateTime Time)    
        {
            this.NameStation = NameStation;
            this.Namber = Namber;
            this.Time = Time;
        }

        public int CompareTo(object input) 
        {
            if (input is Train)
            {
                Train p1 = (Train)input;
                if (this.Time > p1.Time)
                    return 1;
                else if (this.Time < p1.Time)
                    return -1;
                else
                    return 0;
            }
            return 0;
        }

        public override string ToString() 
        {
            string info = String.Format("Поезд №{0} следует в пункт назначения {1}. Время отправления: {2}.{3}!",
                Namber, NameStation, time.Hour, time.Minute);
            return info;
        }
        public void ShowInfo() 
        {
            Console.WriteLine(ToString());
        }

        public static bool operator >(Train p1, Train p2) 
        {
            if (p1.Time > p2.Time)
                return true;
            return false;
        }
        public static bool operator <(Train p1, Train p2)  
        {
            if (p1.Time < p2.Time)
                return true;
            return false;
        }
        public static bool operator ==(Train p1, Train p2)
        {
            if (p1.Time == p2.Time)
                return true;
            return false;
        }
        public static bool operator !=(Train p1, Train p2)
        {
            if (p1.Time != p2.Time)
                return true;
            return false;
        }
    }
}
