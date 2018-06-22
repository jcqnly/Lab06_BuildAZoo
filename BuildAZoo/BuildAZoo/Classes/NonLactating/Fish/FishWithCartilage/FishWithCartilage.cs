using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.NonLactating.Fish.FishWithCartilage
{
    public abstract class FishWithCartilage : Fish
    {
        public virtual bool IsCarnivorous { get; set; }
        public abstract bool HasVertebrae { get; set; }
    }
}
