using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.Lactating.Mammal
{
    /// <summary>
    /// base class for lactating mammals
    /// </summary>
    public abstract class Mammal : Lactating
    {
        public bool MammaryGlands { get; set; } = true;
        public virtual bool IsNocturnal { get; set; }
    }
}
