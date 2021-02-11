using System;

namespace Comparator
{
    class Circle : IComparable
    {
        public Circle() { }
        public Circle(double r)
        {
            R = r;
        }
        public double R { get; set; }
        public double Square()
        {
            return Math.PI * Math.Pow(R, 2);
        }
        public int CompareTo(object obj)
        {
            Circle other = obj as Circle;
            if (other != null)

            {
                if (this.Square() > other.Square())
                    return 1;
                if (this.Square() < other.Square())
                    return -1;
                else
                    return 0;
            }
            else
                throw new ArgumentException("Object is not a Circle");
        }
    }
}
