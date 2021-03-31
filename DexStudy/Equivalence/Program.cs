using System;

namespace Equivalence
{
    class Program
    {
        //Реализовать свой класс Person(ФИО, Дата рождения, Место рождения, Номер паспорта),
        //переопределить в нём методы.GetHashCode и Equals

        //Что необходимо сделать, чтобы вызвался переопределённый метод Equals при сравнении через оператор ==?
        //Перегрузить операторы отношения == и !=
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.FirstName = "Мария";
            p1.LastName = "Иванова";
            p1.PassportID = 15825;
            p1.BirthDate = Convert.ToDateTime("18.05.2010");
            p1.BirthPlace = "Первомайск";

            Person p2 = new Person();
            p2.FirstName = "Мария";
            p2.LastName = "Иванова";
            p2.PassportID = 15825;
            p2.BirthDate = Convert.ToDateTime("18.05.2010");
            p2.BirthPlace = "Первомайск";

            Console.WriteLine("Сравним p1 и p2");
            Console.WriteLine("Equals:" + p1.Equals(p2));
            Console.WriteLine("GetHashCode:p1=" + p1.GetHashCode() + ", p2=" + p2.GetHashCode());
            Console.WriteLine("Comparison with == :"+ (p1 == p2));

            Console.WriteLine("\nИзменим свойство для объекта p2");
            p2.BirthPlace = "Тирасполь";

            Console.WriteLine("Equals:" + p1.Equals(p2));
            Console.WriteLine("GetHashCode:p1=" + p1.GetHashCode() + ", p2=" + p2.GetHashCode());
            Console.WriteLine("Comparison with == :" + (p1 == p2));

            Console.ReadLine();
        }
    }
}
