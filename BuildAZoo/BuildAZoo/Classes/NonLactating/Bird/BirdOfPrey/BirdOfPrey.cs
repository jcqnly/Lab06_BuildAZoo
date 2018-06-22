using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.NonLactating.Bird.BirdOfPrey
{
    public abstract class BirdOfPrey : Bird
    {
        public override bool IsCarnivorous { get; set; } = true;
    }
}
