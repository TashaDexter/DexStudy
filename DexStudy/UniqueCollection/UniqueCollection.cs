using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyUniqueCollection
{
    class UniqueCollection <T> : ICollection <T>
    {
        private readonly ICollection<T> uniqueCol;
        public UniqueCollection()
        {
            uniqueCol = new List<T>();
        }

        public bool Contains(T item)
        {
            return uniqueCol.Contains(item);
        }

        public void Add(T item)
        {

            if (!Contains(item))
            {
                uniqueCol.Add(item);
            }
            else
            {
                throw new Exception("Невозможно добавить объект "+item+". Данный элемент уже существует в коллекции!");
            }
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            uniqueCol.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get
            {
                return uniqueCol.Count;
            }
        }

        public bool Remove(T item)
        {
            return uniqueCol.Remove(item);
        }

        public void Clear()
        {
            uniqueCol.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return uniqueCol.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return uniqueCol.GetEnumerator();
        }

        public bool IsReadOnly
        {
            get { return false; }
        }
    }
}
