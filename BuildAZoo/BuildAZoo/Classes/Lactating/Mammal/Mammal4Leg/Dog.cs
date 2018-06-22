using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.Lactating.Mammal.Mammal4Leg
{
    public class Dog : Mammal4Leg
    {
        public override string Name { get; set; } = "DOGGO";
        public override int Legs { get; set; } = 4;
        public override bool CanBeDomesticated { get; set; } = true;
        public override bool IsNocturnal { get; set; } = false;
        public override string Appearance()
        {
            return $"{Name} is most regal of em all!";
        }
    }
}
