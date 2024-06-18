using System;

namespace Librery.Generic
{
    public class List<T> where T : IComparable <T>
    {
        private T[] list;


        public List()
        {
            list = new T[0];
        }


        public void Add(T item) 
        {
            extension();
            list[list.Length - 1] = item;
        }


        public T getItem(int index)
        {
            if (isWithinTheArray(index))
            {
                return list[index];
            }
            return default;
        }


        public bool Contains(T item)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].CompareTo(item) == 0)
                {
                    return true;
                }
            }
            return false;
        }


        public void Remove(int index)
        {
            if (isWithinTheArray(index))
            {
                compression();
            }
            return;
        }


        private bool isWithinTheArray(int index)
        {
            if (list.Length >= index)
            {
                return true;
            }
            return false;
        }


        private void extension() //Розширює масив
        {
            T[] cash = list;
            list = new T[cash.Length + 1];
            for (int i = 0; i < list.Length - 1; i++)
            {
                list[i] = cash[i];
            }
        }

        private void compression() //зжимає масив
        {
            T[] cash = list;
            list = new T[cash.Length - 1];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = cash[i];
            }
        }

        internal object ToArray()
        {
            throw new NotImplementedException();
        }
    }
}
