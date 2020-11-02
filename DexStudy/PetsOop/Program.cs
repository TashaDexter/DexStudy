using System;
using System.Collections.Generic;

namespace PetsOop
{
    /*ЗАДАНИЕ:
     Самостоятельно изучить интерфейсы, область применения, какие из принципов ООП применимы
     к статическим членам класса реализовать несколько классов, с глубиной иерархии 2-3,
     с применением всех принципов ООП, продемонстрировать в приложении (консоль).
     Области для примера: животные, автомашины, геометр. фигуры, и т.д.*/

    public class PetsOoP
    {
        private static void Main(string[] args)
        {
            var pets = new List<Pet>();
            try
            {
                Console.WriteLine("Hello!\nHow many pets do you want to add? ");
                int n = Int32.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("--------------------------------\n" +
                    "Which pet would you like to add?\n1 - Cat, 2 - Dog, 3 - Fish ");
                    int petCode = Int32.Parse(Console.ReadLine());
                    var pet = GetPetByCode(petCode);

                    if (pet != null)
                    {
                        Console.WriteLine("What is your pet's name?");
                        pet.Name = Console.ReadLine();
                        pets.Add(pet);
                    }
                }
            }
            catch (System.FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception any)
            {
                Console.WriteLine(any.Message);
            }
            finally
            {
                PrintPets(pets);
                Console.ReadKey();
            }
        }

        private static Pet GetPetByCode(int code)
        {
            switch (code)
            {
                case 1:
                    {
                        return new Cat();
                        break;
                    }
                case 2:
                    {
                        return new Dog();
                        break;
                    }
                case 3:
                    {
                        return new Fish();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error! Code is incorrect.");
                        return null;
                        break;
                    }
            }
        }

        private static void PrintPets(List<Pet> pets)
        {
            Console.WriteLine("--------------------------------\nCurrent list of pets:");
            foreach (var p in pets)
            {
                Console.WriteLine($"Class: {p.GetType()}");
                Console.WriteLine($"name: {p.Name}");
                p.MakeSound();
                p.Move(5);
                Console.WriteLine("\n");
            }
        }
    }
}