using System;

namespace AnimalPerspective
{
    public class Dog : Animal, IMammal
    {
        public int NumberOfNipples {get; }
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }

        public Dog()
        {
            NumberOfNipples = 8;
        }
    }
}
