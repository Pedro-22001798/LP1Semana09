using System;

namespace AnimalPerspective
{
    public class Program
    {
        private static void Main()
        {
            Animal animal1 = new Dog();
            Animal animal2 = new Cat();
            Animal animal3 = new Bat();
            Animal animal4 = new Bee();
            WriteAnimalInformation(animal1);
            WriteAnimalInformation(animal2);
            WriteAnimalInformation(animal3);
            WriteAnimalInformation(animal4);
        }

        private static void WriteAnimalInformation(Animal newAnimal)
        {
            if(newAnimal is ICanFly)
            {
                Console.WriteLine($"{newAnimal.GetType()} Number of wings = {((ICanFly)newAnimal).NumberOfWings}");
            }
            if(newAnimal is IMammal)
            {
                Console.WriteLine($"{newAnimal.GetType()} Number of nipples = {((IMammal)newAnimal).NumberOfNipples}");
            }
        }
    }
}