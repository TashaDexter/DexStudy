using System;

namespace PetsOop
{
    public class Fish : Pet
    {
        public Fish()
        {
            Name = "NoName";
        }

        public Fish(string name)
        {
            Name = name;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Fish don't speak, silly :)");
        }

        public override void Move(int distance)
        {
            Console.WriteLine($"Fish swam {distance} meters");
        }
    }
}