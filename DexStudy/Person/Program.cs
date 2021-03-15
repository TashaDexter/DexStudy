using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    /*ЗАДАНИЕ:
     Реализовать класс Person (FirstName, LastName), определить операторы неявного/явного
    преобразования к строке, продемонстрировать работу. Пример: "Иванов Иван" должен
    преобразовываться в Person.
    Попробуйте сравнить экземпляр Person и текст при помощи оператора ==, затем при
    помощи Equals(), объясните результат.*/
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.FirstName = "Петр";
            p1.LastName = "Васильевич";

            string s1 = "Петр Васильевич";
            
            Console.WriteLine("Сравнение при помощи ==: " + (s1 == p1));
            //при сравнении происходит неявное преобразование p1 в string, оба экземпляра строки
            //имеют одинаковую длину и идентичные символы в каждой позиции символа
            Console.WriteLine("Сравнение при помощи Equals: " + s1.Equals(p1));
            //в методе Equals p1 явно приводится к string, затем объекты сравниваются по имени
            Console.Read();
        }
    }
}
