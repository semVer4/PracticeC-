using System;

namespace z2
{
    internal partial class Program
    {
        class Array:IComparable
        {
            private int HIndex;
            private int SIndex;
            private int EIndex;
            public int[] vector;

            public Array(int Index, int StartIndex, int EndIndex)
            {
                HIndex = Index;
                SIndex = StartIndex;
                EIndex = EndIndex;
                vector = new int[Index];
            }
            public int StartIndex
            {
                get { return SIndex; }
                set { SIndex = value; }
            }
            public int EndIndex
            {
                get { return EIndex; }
                set { EIndex = value; }
            }
            public int Index
            {
                get { return HIndex; }
            }
            public int this[int ElementNum]
            {
                get
                {
                    if(ElementNum >= HIndex)
                    {
                        throw new IndexOutOfRangeException("Выход из диапазона!");
                    }
                    else
                        return vector[ElementNum];
                }
                set
                {
                    if (ElementNum >= HIndex)
                    {
                        throw new IndexOutOfRangeException("Выход из диапазона!");
                    }
                    else
                        vector[ElementNum] = value;
                }
            }

            public int CompareTo(object obj)
            {
                return CompareTo(obj as Array);
            }

            private int CompareTo(Array other)
            {
                if(other == null)
                    throw new ArgumentNullException();
                if(this == other)
                {
                    return 0;
                }
                return EndIndex > other.EndIndex ? 1 : -1;
            }

            public static Array operator +(Array x, Array y)
            {
                if(x.Index != y.Index)
                {
                    throw new ArgumentException("Ошибка!");
                }
                else
                {
                    Array temp = new Array(x.Index, x.StartIndex, x.EndIndex);
                    for (int i = 0; i < temp.Index; i++)
                    {
                        temp[i] = x[i] + y[i];
                    }
                    return temp;
                }
            }

            public static Array operator -(Array x, Array y)
            {
                if(x.Index != y.Index)
                {
                    throw new ArgumentException("Ошибка!");
                }
                else
                {
                    Array temp = new Array(x.Index, x.StartIndex, x.EndIndex);
                    for (int i = 0; i < temp.Index; i++)
                    {
                        temp[i] = x[i] - y[i];
                    }
                    return temp;
                }
            }

            public void PrintAll()
            {
                Random random = new Random();

                for (int i = 0; i < HIndex; i++)
                {
                    vector[i] = random.Next(30);
                    Console.Write(vector[i] + " ");
                }
            }

            public void PrintElem(int ElementNum)
            {
                Console.Write(vector[ElementNum]);
            }
        }
    }
}
