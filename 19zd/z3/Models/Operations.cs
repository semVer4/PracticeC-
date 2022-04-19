using System.Collections;

namespace z3
{
    internal partial class Program
    {
        class Operations : IEnumerable
        {
            private ArrayList list;

            public Operations()
            {
                list = new ArrayList();
            }
            public Operations(ArrayList a)
            {
                list = a;
            }
            public void Add(Person pers)
            {
                list.Add(pers);
            }
            public Operations Clone()
            {
                return new Operations(list);
            }
            public void RemoveAt(int i)
            {
                list.RemoveAt(i);
            }

            public IEnumerator GetEnumerator()
            {
                return list.GetEnumerator();
            }
        }
    }
}
