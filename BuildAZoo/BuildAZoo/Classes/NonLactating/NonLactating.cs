using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.NonLactating
{
    abstract public class NonLactating
    {
        //Every nonlactating animal will have the following properties

        /// <summary>
        /// What's the name of this animal?
        /// </summary>
        public abstract string Name { get; set; }

        /// <summary>
        /// What sort of noise does this animal make?
        /// </summary>
        public abstract string Noise { get; set; }

        /// <summary>
        /// get the number of legs
        /// </summary>
        public abstract int Legs { get; set; }

        /// <summary>
        /// What's  this animal's favorite thing to eat?
        /// </summary>
        public abstract string FavFood { get; set; }

        /// <summary>
        /// What are defining characteristics of this animal
        /// </summary>
        /// <returns></returns>
        public abstract string Appearance();

        /// <summary>
        /// What does this animal eat?
        /// </summary>
        public virtual string Diet()
        {
            return $"{Name} really likes {FavFood}!";
        }

        /// <summary>
        /// What does this animal sound like?
        /// </summary>
        /// <returns>a string with the name of the animal</returns>
        public string Sound()
        {
            return $"{Noise}.  I am {Name}.";
        }
    }
}
