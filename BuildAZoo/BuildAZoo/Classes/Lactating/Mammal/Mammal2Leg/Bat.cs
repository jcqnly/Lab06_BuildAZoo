using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.Lactating.Mammal.Mammal2Leg
{
    public class Bat : Mammal2Leg
    {
        public override string Name { get; set; } = "Bat";
        public override string FavFood { get; set; } = "Berries";
        public override string Noise { get; set; } = "BATBATBAT";
        public override bool IsNocturnal { get; set; } = true;
        public override string Appearance()
        {
            return $"The {Name} is a creature of the night!";
        }
    }
}
