using System;

namespace AnimalPerspective
{
    public class Bee : Animal, ICanFly
    {
        public int NumberOfWings {get; }
        public override string Sound()
        {
            return base.Sound() + "Zzzzzzz";
        }

        public Bee()
        {
            NumberOfWings = 2;
        }
    }
}