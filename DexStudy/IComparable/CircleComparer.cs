using System.Collections.Generic;

namespace Comparator
{
    class CircleComparer: IComparer<Circle>
    {
        public int Compare(Circle c1, Circle c2)
        {
            if (c1.Square() > c2.Square())
                return 1;
            else if (c1.Square() < c2.Square())
                return -1;
            else
                return 0;
        }
    }
}
