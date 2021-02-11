using System;
using System.Collections;

namespace Enum
{
    public class FelineEnum: IEnumerator
    {
        public Cat[] _feline;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public FelineEnum(Cat[] list)
        {
            _feline = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _feline.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Cat Current
        {
            get
            {
                try
                {
                    return _feline[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
