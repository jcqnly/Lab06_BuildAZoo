﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.NonLactating.Fish.FishWithCartilage
{
    public class Shark : FishWithCartilage, ISwimAndKill, IFly
    {
        public override string Name { get; set; } = "Sharky";
        public override string FavFood { get; set; } = "humans";
        public override bool IsCarnivorous { get; set; } = true;
        public override bool HasVertebrae { get; set; } = false;
        public override int Legs { get; set; } = 0;
        public override string Noise { get; set; } = "ChOMp cHoMp!!!";
        //the interface
        public bool BloodThirsty { get; set; } = true;

        public override string Appearance()
        {
            return $"The {Name} is a scary looking fishy!";
        }

        public string WhyIFly(string input)
        {
            return $"{Name} will fly {input}";
        }
    }
}
