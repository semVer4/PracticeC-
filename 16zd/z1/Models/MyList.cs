using System.Collections.Generic;

namespace z1
{
    internal partial class Program
    {
        class MyList<T>
        { 
            List<T> list = new List<T>();

            public T this[int index]
            {
                get { return list[index]; }
                set { list[index] = value; }
            }
            public void Add(T a)
            {

                list.Add(a);
            }

            public int Count
            {
                get { return list.Count; }
            }
        }
    }
}
