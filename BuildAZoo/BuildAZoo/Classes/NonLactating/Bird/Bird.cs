using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.NonLactating.Bird
{
    public abstract class Bird : NonLactating
    {
        public virtual bool CanFly { get; set; } = true;
        public virtual bool IsCarnivorous { get; set; }
        public abstract bool HasFeathers { get; set; }
    }
}
