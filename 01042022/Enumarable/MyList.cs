using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Enumarable
{
    internal class MyList<T>:IEnumerable<T>
    {
        T[] _arr = new T[10];

        public T this[int index]
        {
            get => _arr[index];
            set => _arr[index] = value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _arr)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
