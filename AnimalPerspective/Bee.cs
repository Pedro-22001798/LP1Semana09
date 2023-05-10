using System;

namespace AnimalPerspective
{
    public class Bee : Animal, ICanFly
    {
        public int NumberOfWings {get {return 2;}}
        public override string Sound()
        {
            return base.Sound() + "Zzzzzzz";
        }
    }
}