﻿using System;
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
            string s1 = "Петр Васильевич";
            Person p1 = (Person)s1;
            Console.WriteLine("Строка:" + s1 + "\nЯвное преобразование в Person: FirstName - " + p1.FirstName + ", LastName - " + p1.LastName);
            Console.WriteLine("Сравнение при помощи ==: " + (s1 == p1));
            Console.WriteLine("Сравнение при помощи Equals: " + s1.Equals(p1));
            Console.WriteLine();

            string s2 = "Евгения Николаевна";
            Person p2 = s2;            
            Console.WriteLine("Строка:" + s2 + "\nНеявное преобразование в Person: FirstName - " + p2.FirstName + ", LastName - " + p2.LastName);
            Person p3 = new Person { FirstName = "Николай", LastName = "Викторович" };
            Console.WriteLine("Сравнение при помощи ==: " + (s2 == p2));
            Console.WriteLine("Сравнение при помощи Equals: " + s2.Equals(p2));
            Console.WriteLine();
            
            string s3 = (string)p3;
            Console.WriteLine("Person: FirstName - " + p3.FirstName + ", LastName - " + p3.LastName + "\nЯвное преобразование в строку: " + s3);
            Console.WriteLine("Сравнение при помощи ==: " + (s3 == p3));
            Console.WriteLine("Сравнение при помощи Equals: " + s3.Equals(p3));
            Console.WriteLine();
            
            string s4 = p3;
            Console.WriteLine("Person: FirstName - " + p3.FirstName + ", LastName - " + p3.LastName + "\nНеявное преобразование в строку: " + s3);
            Console.WriteLine("Сравнение при помощи ==: " + (s4 == p3));
            Console.WriteLine("Сравнение при помощи Equals: " + s4.Equals(p3));
            Console.WriteLine();
            Console.Read();
        }
    }
}
