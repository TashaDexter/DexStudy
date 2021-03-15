using System.Collections;

namespace Enum
{
    public class Feline: IEnumerable
    {
        private Cat[] _feline;
        public Feline(Cat[] cArray)
        {
            Length = cArray.Length;
            _feline = new Cat[cArray.Length];
            for (int i = 0; i < cArray.Length; i++)
            {
                _feline[i] = cArray[i];
            }

        }

        //индексирование------------------------------------------------------------------
        public Cat this[int index]
        {
            get
            {
                return _feline[index];
            }
            set
            {
                _feline[index] = value;
            }
        }
       
        public int Length { get; private set; }
        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public FelineEnum GetEnumerator()
        {
            return new FelineEnum(_feline);
        }
    }

}
