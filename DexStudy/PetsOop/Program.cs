﻿using System;
using System.Collections.Generic;

namespace PetsOop
{
    /*ЗАДАНИЕ:
     Самостоятельно изучить интерфейсы, область применения, какие из принципов ООП применимы
     к статическим членам класса реализовать несколько классов, с глубиной иерархии 2-3,
     с применением всех принципов ООП, продемонстрировать в приложении (консоль).
     Области для примера: животные, автомашины, геометр. фигуры, и т.д.*/

    /*Checking .gitignore*/
    public class PetsOoP
    {
        private static void Main(string[] args)
        {
            var pets = new List<Pet>();

            int petsNumber;
            Console.WriteLine("Hello!\nHow many pets do you want to add? ");
            string inputNumber = Console.ReadLine();
            if (Int32.TryParse(inputNumber, out petsNumber))
            {
                for (int i = 0; i < petsNumber; i++)
                {
                    int petCode;
                    Console.WriteLine("--------------------------------\n" +
                    "Which pet would you like to add?\n1 - Cat, 2 - Dog, 3 - Fish ");
                    string inputCode = Console.ReadLine();
                    if (Int32.TryParse(inputCode, out petCode))
                    {
                        var pet = GetPetByCode(petCode);

                        if (pet != null)
                        {
                            Console.WriteLine("What is your pet's name?");
                            pet.Name = Console.ReadLine();
                            pets.Add(pet);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error! Code is incorrect.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error! You entered incorrect value.");
            }

            if (pets.Count != 0)
            {
                PrintPets(pets);
            }
            Console.ReadKey();
        }

        private static Pet GetPetByCode(int code)
        {
            switch (code)
            {
                case 1:
                    {
                        return new Cat();
                    }
                case 2:
                    {
                        return new Dog();
                    }
                case 3:
                    {
                        return new Fish();
                    }
                default:
                    {
                        Console.WriteLine("Error! Code is incorrect.");
                        return null;
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