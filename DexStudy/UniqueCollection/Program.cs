using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUniqueCollection
{
    class Program
    {
        //Реализовать коллекцию которая хранит только уникальные объекты UniqueCollection<T>,
        //при попытке добавить существующий инстанс, выбрасывает исключение
        static void Main(string[] args)
        {
            UniqueCollection<int> int_collection = new UniqueCollection<int>();
            try
            {
                int_collection.Add(5);
                int_collection.Add(6);
                int_collection.Add(7);
                int_collection.Add(5);
                int_collection.Add(9);
            }

            catch (Exception any)
            {
                Console.WriteLine(any.Message);
            }

            finally
            {
                Console.WriteLine("Элементы коллекции:");
                foreach (int i in int_collection)
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();
            }
            
        }
    }
}
