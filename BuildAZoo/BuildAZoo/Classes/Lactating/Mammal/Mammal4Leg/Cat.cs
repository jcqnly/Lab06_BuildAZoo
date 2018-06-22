using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.Lactating.Mammal.Mammal4Leg
{
    public class Cat : Mammal4Leg
    {
        public override string Name { get; set; } = "KITTY CAT";
        public override int Legs { get; set; } = 4;
        public override bool CanBeDomesticated { get; set; } = true;
        public override string Appearance()
        {
            return $"The {Name} will knock your full wine glass over. Guaranteed.";
        }
    }
}
