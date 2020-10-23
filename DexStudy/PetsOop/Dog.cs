using System;

namespace PetsOop
{
    public class Dog : Pet
    {
        public Dog()
        {
            Name = "NoName";
        }

        public Dog(string name)
        {
            Name = name;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Dog says: \"Woof! Woof!\"");
        }

        public override void Move(int distance)
        {
            Console.WriteLine($"Dog ran {distance} meters");
        }
    }
}