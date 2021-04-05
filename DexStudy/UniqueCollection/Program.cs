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
            UniqueCollection<Person> p_collection = new UniqueCollection<Person>();
            try
            {
                int_collection.Add(5);
                int_collection.Add(4);
                int_collection.Add(3);
                int_collection.Add(6);
                //int_collection.Add(5);
                int_collection.Add(14);

                Person p1 = new Person();
                p1.FirstName = "Мария";
                p1.LastName = "Иванова";
                p1.PassportID = 15825;
                p1.BirthDate = Convert.ToDateTime("18.05.2010");
                p1.BirthPlace = "Первомайск";

                Person p2 = new Person();
                p2.FirstName = "Оксана";
                p2.LastName = "Иванова";
                p2.PassportID = 15625;
                p2.BirthDate = Convert.ToDateTime("18.05.2010");
                p2.BirthPlace = "Первомайск";

                Person p3 = new Person();
                p3.FirstName = "Мария";
                p3.LastName = "Иванова";
                p3.PassportID = 15825;
                p3.BirthDate = Convert.ToDateTime("18.05.2010");
                p3.BirthPlace = "Первомайск";

                p_collection.Add(p1);
                p_collection.Add(p2);
                p_collection.Add(p3);
            }

            catch (Exception any)
            {
                Console.WriteLine(any.Message);
            }

            finally
            {
                Console.WriteLine("\nКоллекция объектов int:");
                foreach (int i in int_collection)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("\nКоллекция объектов Person:");
                foreach (Person p in p_collection)
                {
                    Console.WriteLine(p);
                }
                Console.ReadLine();
            }
            
        }
    }
}
