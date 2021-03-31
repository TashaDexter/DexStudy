using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typed_dictionary
{
    class Program
    {
        //Реализовать упрощенную версию справочника места работ, где ключом является
        //класс Person(ФИО, Дата рождения, Место рождения, Номер паспорта), значением -
        //string (текущее место работы). В качестве результата работы должно быть следующее:
        //Вводим данные о физическом лице: ФИО, Дата рождения, Место рождения, Номер
        //паспорта и нам выдают его текущее место работы, если такой человек существует в нашей базе.
        static void Main(string[] args)
        {
            Dictionary<Person, string> workplaces = new Dictionary<Person, string>();
            Person p1 = new Person();
            p1.FirstName = "Николай";
            p1.LastName = "Петров";
            p1.PassportID = 125879;
            p1.BirthDate = Convert.ToDateTime("14.03.91");
            p1.BirthPlace = "Бендеры";

            Person p2 = new Person();
            p2.FirstName = "Василий";
            p2.LastName = "Николаев";
            p2.PassportID = 125574;
            p2.BirthDate = Convert.ToDateTime("25.06.85");
            p2.BirthPlace = "Тирасполь";

            Person p3 = new Person();
            p3.FirstName = "Кристина";
            p3.LastName = "Яковлева";
            p3.PassportID = 845714;
            p3.BirthDate = Convert.ToDateTime("24.10.76");
            p3.BirthPlace = "Тирасполь";

            workplaces.Add(p1, "Инженерно-технический институт");
            workplaces.Add(p2, "Гуманитарно-математическая гимназия");
            workplaces.Add(p3, "Хлопчато-бумажный комбинат");

            Console.WriteLine("Содеражние справочника workplaces:");
            foreach (var p in workplaces)
                Console.WriteLine(p.Key + " - " + p.Value);

            Person person = new Person();
            Console.WriteLine("\nВведите данные о физическом лице:");
            Console.Write("Имя:");
            person.FirstName = Console.ReadLine();
            Console.Write("Фамилия:");
            person.LastName = Console.ReadLine();
            Console.Write("Номер паспорта:");
            person.PassportID= Convert.ToInt32(Console.ReadLine());
            Console.Write("Дата рождения:");
            person.BirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Место рождения:");
            person.BirthPlace = Console.ReadLine();

            if (workplaces.ContainsKey(person))
            {
                Console.WriteLine("Место работы:"+workplaces[person]);
            }
            else
                Console.WriteLine("Данное физическое лицо отсутствует в базе данных!");

            Console.ReadLine();
        }
    }
}
