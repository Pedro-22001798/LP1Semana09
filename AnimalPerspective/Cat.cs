using System;

namespace AnimalPerspective
{
    public class Cat : Animal, IMammal
    {
        public int NumberOfNipples {get; }
        public override string Sound()
        {
            return base.Sound() + "Miau";
        }

        public Cat()
        {
            NumberOfNipples = 10;
        }
    }
}
