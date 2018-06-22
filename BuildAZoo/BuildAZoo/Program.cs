using BuildAZoo.Classes.Lactating;
using BuildAZoo.Classes.Lactating.Mammal.Mammal2Leg;
using BuildAZoo.Classes.NonLactating.Fish.FishWithCartilage;
using System;

namespace BuildAZoo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the zoo!");
            //explore the zoo
            Zoo();
            Console.Read();
        }

        /// <summary>
        /// testing that the animal has inherited qualities from its base class
        /// </summary>
        public static void Zoo()
        {
            //LACTATING ANIMAL
            //instantiating a bear object from the Bear class
            Bear bear = new Bear();

            //overriding an abstract method (Appearance())
            Console.WriteLine(bear.Appearance());

            //overriding an abstract property (Name) and
            //overriding a virtual property (Noise)
            Console.WriteLine($"{bear.Name} goes {bear.Noise}.");

            //overriding a virtual method (Diet())
            Console.WriteLine($"{bear.Diet()}");

            //implementing the IFly Interface on Bear
            Console.WriteLine($"{bear.WhyIFly("campers")}");
            //implementing the ISwimAndKill Interface on Bear
            Console.WriteLine($"Is {bear.Name} bloodthirsty?  {bear.BloodThirsty}!!");

            Console.WriteLine("<-------------------------->");

            //NONLACTATING ANIMALS
            //instantiating a shark
            Shark shark = new Shark();

            //overriding an abstract method (Appearance())
            Console.WriteLine(shark.Appearance());

            //overriding an abstract property (Name) and
            //overriding a virtual property (Noise)
            Console.WriteLine($"{shark.Name} goes {shark.Noise}");
            //overriding a virtual method (Diet())
            Console.WriteLine($"{shark.Diet()}");
            //implementing the ISwimAndKill interface on shark
            Console.WriteLine($"Is {shark.Name} blood thirsty? mmm...{shark.BloodThirsty}!");
            //implementing the IFly interface on shark
            Console.WriteLine($"{shark.WhyIFly("the day pigs fly")}");
        }
    }
}
