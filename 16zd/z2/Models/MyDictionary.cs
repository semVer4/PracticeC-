using System;
using System.Collections;
using System.Collections.Generic;

namespace z2
{
    internal partial class Program
    {
        class MyDictionary<TKey, TValue> : IEnumerable
        {
            private TKey[] arrKey;
            private TValue[] arrVal;
            private int count;
            public int Counter
            {
                get { return count; }
            }

            public void Add(TKey key, TValue val)
            {
                this.count++;

                Array.Resize(ref arrKey, count);
                arrKey[count - 1] = key;

                Array.Resize(ref arrVal, count);
                arrVal[count - 1] = val;
            }
            public TValue this[TKey key]
            {
                get
                {
                    int index = 0;
                    for (int i = 0; i < arrKey.Length; i++)
                    {
                        if (key.Equals(arrKey[i]))
                            index = i;
                    }
                    return arrVal[index];
                }
            }
            public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
            {
                for (int i = 0; i < arrKey.Length; i++)
                    yield return new KeyValuePair<TKey, TValue>(arrKey[i], arrVal[i]);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

        }
    }
}
