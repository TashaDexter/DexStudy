using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneable
{
    /*Задание:
    * Изучить интерфейс ICloneable
    * Реализовать его на структуре данных члены которой все ValueType
    * Поверхностное и глубокое копирование*/

    class Program
    {
        static void Main(string[] args)
        {
            Flat f1 = new Flat { Stage = 4, Number = 48, Room1 = new Room(5.1, 8.15) };
            Flat f2 = (Flat)f1.Clone();
            Console.WriteLine("Клонирование:");
            Console.WriteLine("f1: Stage - " + f1.Stage + ", Number - " + f1.Number + ". Room1: A - " + f1.Room1.A + ", B - " + f1.Room1.B);
            Console.WriteLine("f2: Stage - " + f2.Stage + ", Number - " + f2.Number + ". Room1: A - " + f2.Room1.A + ", B - " + f2.Room1.B);

            f2.Stage = 3;
            f2.Number = 59;
            f2.Room1.A = 7.85;
            f2.Room1.B = 6.45;
            Console.WriteLine("Проверка работы присваивания:");
            Console.WriteLine("f2: Stage - " + f2.Stage + ", Number - " + f2.Number + ". Room1: A - " + f2.Room1.A + ", B - " + f2.Room1.B);
            Console.ReadKey();
        }
    }
}
