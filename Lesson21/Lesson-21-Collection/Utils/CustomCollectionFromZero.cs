using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lesson_21_Collection.Utils
{
    public class CustomCollectionFromZero<T> : ICollection<T>
        where T : Section
    {
        protected IList<T> Items;
        public CustomCollectionFromZero()
        {
            Items = new List<T>();
        }

        public int Count => Items.Count;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            if (!string.IsNullOrEmpty(item.Name)) ;
        }

        public void Clear()
        {
            Items.Clear();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
