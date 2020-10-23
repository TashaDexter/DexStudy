namespace PetsOop
{
    public abstract class Pet : IAnimal
    {
        public string Name { get; set; }

        public abstract void MakeSound();

        public abstract void Move(int distance);
    }
}