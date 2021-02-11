using System;
using System.Collections;

namespace Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            ArrayList circles1 = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                circles1.Add(new Circle(rnd.Next(1, 10) + rnd.NextDouble()));
            }
            circles1.Sort();
            Console.WriteLine("Отсортированный список из 10 кругов по площади (Icomparable)");
            foreach (Circle c in circles1)
                Console.WriteLine("Square:" + c.Square());

            Circle[] circles2 = new Circle[10];
            for (int i = 0; i < circles2.Length; i++)
            {
                circles2[i] = new Circle(rnd.Next(1, 10) + rnd.NextDouble());
            }
            Array.Sort(circles2, new CircleComparer());
            Console.WriteLine("\nОтсортированный список из 10 кругов по площади (IComparer)");
            foreach (Circle c in circles2)
                Console.WriteLine("Square:" + c.Square());
            Console.ReadLine();
        }
    }
}
