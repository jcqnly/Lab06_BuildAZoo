using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.NonLactating.Fish
{
    public abstract class Fish : NonLactating
    {
        public virtual bool HasScales { get; set; }
    }
}
