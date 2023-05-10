using System;

namespace AnimalPerspective
{
    public class Dog : Animal, IMammal
    {
        public readonly int numberOfNipples = 8;
        public int NumberOfNipples {get {return numberOfNipples;}}
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
}
