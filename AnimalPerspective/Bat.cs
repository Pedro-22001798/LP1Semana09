using System;

namespace AnimalPerspective
{
    public class Bat : Animal, IMammal
    {
        public readonly int numberOfNipples = 4;
        public int NumberOfNipples {get {return numberOfNipples;}}
        public override string Sound()
        {
            return base.Sound() + "ihihii";
        }
    }
}
