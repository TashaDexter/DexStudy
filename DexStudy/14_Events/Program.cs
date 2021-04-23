using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            /*реализовать интерфейс INotifyPropertyChanged на произвольном классе,
             *продемонстрировать его работу*/
            Cat cat = new Cat();
            cat.PropertyChanged += ActionOnPropertyChanged;
            cat.Name = "Мурка";          
            cat.Name = "Вася";
            cat.Name = "Селена";
            cat.PropertyChanged -= ActionOnPropertyChanged;
            cat.Name = "Маня";
            cat.Name = "Снежок";

            /*реализовать очередь которая генерирует событие когда кол-во объектов в ней
             *превышает n и событие когда становится пустой*/
            Queue<int> numbers = new Queue<int>();
            numbers.QueueOverflowed += ActionOnQueueOverflowed;
            numbers.QueueIsEmpty += ActionOnQueueIsEmpty;
            numbers.Enqueue(5);
            numbers.Enqueue(1);
            numbers.Enqueue(4);
            numbers.Enqueue(3);
            numbers.Enqueue(4);
            numbers.Clear();
            numbers.Enqueue(3);
            numbers.Dequeue();
            numbers.QueueOverflowed -= ActionOnQueueOverflowed;
            numbers.QueueIsEmpty -= ActionOnQueueIsEmpty;
            foreach (int item in numbers)
                Console.WriteLine(item);

            /*реализовать класс анализирующий поток чисел и если число отличается более
             *чем x процентов выбрасывает событие*/
            Console.ReadLine();

        }

        static void ActionOnPropertyChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Свойство объекта изменилось");
        }

        static void ActionOnQueueOverflowed()
        {
            Console.WriteLine("Невозможно добавить объект! Очередь переполнена!");
        }

        static void ActionOnQueueIsEmpty()
        {
            Console.WriteLine("Очередь пуста.");
        }
        


    }
}
