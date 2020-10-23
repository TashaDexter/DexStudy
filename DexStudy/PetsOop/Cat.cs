using System;

namespace PetsOop
{
    public class Cat : Pet
    {
        public Cat()
        {
            Name = "NoName";
        }

        public Cat(string name)
        {
            Name = name;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Cat says: \"Meow! Meow!\"");
        }

        public override void Move(int distance)
        {
            Console.WriteLine($"Cat ran {distance} meters");
        }
    }
}