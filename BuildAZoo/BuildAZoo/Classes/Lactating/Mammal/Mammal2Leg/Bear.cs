using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.Lactating.Mammal.Mammal2Leg
{
    public class Bear : Mammal2Leg
    {
        public override string Name { get; set; } = "BeaR";
        public override string FavFood { get; set; } = "salmon";
        public override string Noise { get; set; } = "BEARRAWRBEAR";
        public override string Appearance()
        {
            return $"The {Name} is a furry and cuddly thing.";
        }
    }
}
