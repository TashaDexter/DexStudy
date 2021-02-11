using System.Collections;

namespace Enum
{
    public class Feline: IEnumerable
    {
        private Cat[] _feline;
        Cat[] data;
        public Feline(Cat[] cArray)
        {
            Length = cArray.Length;
            _feline = new Cat[cArray.Length];
            data = new Cat[cArray.Length];//данные для индексирования
            for (int i = 0; i < cArray.Length; i++)
            {
                _feline[i] = cArray[i];
                data[i] = cArray[i];
            }


        }
        //индексирование------------------------------------------------------------------
        public Cat this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
        //индексирование----------------------------------------------------------------------     
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
