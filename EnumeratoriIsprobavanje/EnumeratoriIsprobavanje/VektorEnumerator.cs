using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratoriIsprobavanje
{
    internal class VektorEnumerator<T> : IEnumerator<T>
    {

        private T[] field;
        private int count;
        private int current;

        public VektorEnumerator()
        { 
            field = new T[8];
            count = 0;
            current = -1;
        }

        public VektorEnumerator(int len)
        { 
            field = new T[len];
            count = 0;
            current = -1;
        }

        public void Add(T item)
        { 
            if (count == field.Length)
                ReallocMechanism();
            field[count++] = item;
        }

        public bool Remove(T item)
        {
            if (count == 0)
                throw new Exception("Empty vector!");
            int _i = -1;
            for (int i = 0; i < count; ++i)
                if (field[i].Equals(item)) 
                {
                    _i = i;
                    break;
                }
            if (_i == -1)
                return false;
            RemoveAt(_i);
            return true;
        }

        public T RemoveAt(int _i)
        {
            if (count == 0)
                throw new Exception("Empty vector!");
            if (_i < 0 || _i >= count)
                throw new Exception("Index out of bounds!");
            T ret = field[_i];
            if (ret == null)
                return default;
            for (int i = _i; i < count - 1; ++i)
                field[i] = field[i + 1];
            field[count - 1] = default;
            count--;
            return ret;
        }

        private void ReallocMechanism()
        { 
            T[] reallocField = new T[field.Length * 2];
            for (int i = 0; i < count; ++i)
                reallocField[i] = field[i];
            field = reallocField;
        }

        T IEnumerator<T>.Current
        {
            get
            {
                return (T)((IEnumerator)this).Current;
            }
        }

        object IEnumerator.Current
        { 
            get 
            {
                if (field == null)
                    throw new ObjectDisposedException(GetType().Name);
                if (count == 0)
                    throw new Exception("Empty vector!");
                if (current == -1)
                    throw new Exception("Iterator reset!");
                return field[current];
            }
        }

        void IDisposable.Dispose()
        {
            field = null;
            count = 0;
            current = -1;
        }

        bool IEnumerator.MoveNext()
        {
            if (field == null)
                throw new ObjectDisposedException(GetType().Name);
            if (current == count - 1)
                return false;
            current++;
            return true;
        }

        void IEnumerator.Reset()
        {
            if (field == null)
                throw new ObjectDisposedException(GetType().Name);
            current = -1;
        }
    }
}
