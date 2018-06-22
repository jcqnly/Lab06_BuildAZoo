using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.NonLactating.Bird.BirdOfPrey
{
    public class Falcon : BirdOfPrey
    {
        public override string Name { get; set; } = "Falcon";
        public override string FavFood { get; set; } = "rodents";
        public override int Legs { get; set; } = 2;
        public override string Noise { get; set; } = "WHOOP FLAP FALCON FLAP";
        public override bool HasFeathers { get; set; } = true;
        public override string Appearance()
        {
            return $"The {Name} is a FUUURYOUSOUS bird of prey!";
        }
    }
}
