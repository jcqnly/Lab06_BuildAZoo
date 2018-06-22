using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.Lactating.Mammal.Mammal2Leg
{
    public abstract class Mammal2Leg : Mammal
    {
        public override int Legs { get; set; } = 2;
        public virtual bool IsNocturnal { get; set; }
    }
}
