using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericDemo
{
    interface IMyCollection<T>
    {
        void Add(T newValue);
        T RemoveAt(int indexPosition);
        int Count { get; }
        int Capacity { get; }
    }
    class MyCollection<T> : IMyCollection<T>, IEnumerable<T>
    {
        private T[] arr;
        private int index;

        public MyCollection()
        {
            index = 0;
            arr = new T[4];
        }

        public T this[int x]
        {
            get
            {
                return arr[x];
            }
            set
            {
                arr[x] = value;
            }
        }

        public int Count
        {
            get => index;
        }

        public int Capacity => arr.Length;

        public void Add(T newValue)
        {
            if (arr.Length == index)
            {
                T[] temporary = new T[arr.Length * 2];
                Array.Copy(arr, temporary, arr.Length);
                arr = temporary;
            }
            arr[index] = newValue;
            index++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            //var obj = new Enumerator(arr[i]);
            for (int i = 0; i < this.Count; i++)
            {
               yield return arr[i];
            }
        }

        public T RemoveAt(int indexPosition)
        {
            if (indexPosition < index)
            {
                return arr[indexPosition];
            }
            else
                throw new IndexOutOfRangeException("index position is outside the range of the array");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
