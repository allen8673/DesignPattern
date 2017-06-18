using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class TechLeafEnum<T> : IEnumerator<T>
    {
        private T[] _Items = new T[] { };
        private int _Position = -1;

        public TechLeafEnum() { }
        public TechLeafEnum(IEnumerable<T> items)
        {
            _Items = items?.ToArray();
        }


        public T Current
        {
            get
            {
                if (_Position == -1 || _Position > _Items.Length) throw new InvalidOperationException();
                return _Items[_Position];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        #region Dispose實作
        private bool disposed;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Manual release of managed resources.
                }
                // Release unmanaged resources.
                disposed = true;
            }
        }

        ~TechLeafEnum() { Dispose(false); }
        #endregion

        public bool MoveNext()
        {
            return ++_Position < _Items.Length;
        }

        public void Reset()
        {
            _Position = -1;
        }
    }
}
