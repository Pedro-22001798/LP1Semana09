using System;

namespace AnimalPerspective
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public int NumberOfNipples {get; }
        public int NumberOfWings {get; }
        public override string Sound()
        {
            return base.Sound() + "ihihii";
        }

        public Bat()
        {
            NumberOfNipples = 4;
            NumberOfWings = 2;
        }
    }
}
