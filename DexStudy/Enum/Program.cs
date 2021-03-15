using System;

namespace Enum
{
    /*Задание:
    * Сделать пример множества и его членов, реализовать интерфейс для перечисления
    */
    class Program
    {    
        static void Main(string[] args)
        {
            Cat[] felineArray = new Cat[]
            {
                new Cat("Murka"),
                new Cat("Snejok"),
                new Cat("Liza"),
                new Cat("Manya")
            };

            Feline felineList = new Feline(felineArray);
            //при помощи foreach 
            Console.WriteLine("------Обход при помощи foreach-----");
            foreach (Cat cat in felineList)
                Console.WriteLine(cat.Name);

            //с помощью индексирования           
            Console.WriteLine("------Обход при помощи while-----");
            int i = 0;
            while (i < felineList.Length)
            {
                Console.WriteLine(felineList[i].Name);
                i++;
            }

            Console.Read();
        }
    }
}
