using System;

namespace AnimalPerspective
{
    public class Cat : Animal, IMammal
    {
        public readonly int numberOfNipples = 10;
        public int NumberOfNipples {get {return numberOfNipples;}}
        public override string Sound()
        {
            return base.Sound() + "Miau";
        }
    }
}
