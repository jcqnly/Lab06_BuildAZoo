using BuildAZoo.Classes.Lactating.Mammal;
using BuildAZoo.Classes.Lactating.Mammal.Mammal2Leg;
using BuildAZoo.Classes.Lactating.Mammal.Mammal4Leg;
using System;
using Xunit;

namespace TestTheZoo
{
    public class ZooTesting
    {
        [Fact]
        public void CanInherit()
        {
            //new bear object SuperBear can inherit from its derived class, Mammal
            BuildAZoo.Classes.Lactating.Mammal.Mammal2Leg.Bear SuperBear = new Bear();
            //even though MammaryGlands is defined in the Mammal class
            Assert.True(SuperBear.MammaryGlands);
        }

        [Fact]
        public void CanOverrideMethods()
        {
            //IsNocturnal is defined in the Mammal class
            //Both Batty and Doggo have the property,
            //but it's set to different values b/c both have overriden it
            BuildAZoo.Classes.Lactating.Mammal.Mammal2Leg.Bat Batty = new Bat();
            BuildAZoo.Classes.Lactating.Mammal.Mammal4Leg.Dog Doggo = new Dog();

            Assert.NotEqual(Batty.IsNocturnal, Doggo.IsNocturnal);
        }

        [Fact]
        public void ConcreteAnimalIsAnimal()
        {
            //Concrete classes can be instantiated whereas
            //abstract classes cannot be instantiated
            BuildAZoo.Classes.Lactating.Mammal.Mammal4Leg.Dog Doggo = 
                new BuildAZoo.Classes.Lactating.Mammal.Mammal4Leg.Dog();

            //Doggo has all these defined qualities
            Assert.Equal(4, Doggo.Legs);
            Assert.False(Doggo.IsNocturnal);
            Assert.True(Doggo.CanBeDomesticated);
        }

        [Fact]
        public void CanImplementISwimInterface()
        {
            //ISwim Interface is used on the Bear class
            BuildAZoo.Classes.Lactating.Mammal.Mammal2Leg.Bear SuperBear = new Bear();
            //the appropriate value has been set
            Assert.False(SuperBear.BloodThirsty);
        }

        [Fact]
        public void CanImplementIFlyInterface()
        {
            BuildAZoo.Classes.NonLactating.Fish.FishWithCartilage.Shark SHARKY = 
                new BuildAZoo.Classes.NonLactating.Fish.FishWithCartilage.Shark();

            string input = "Not gonna happen";
            //make sure that both outputs matches what the interface established
            Assert.Equal($"{SHARKY.Name} will fly {input}", SHARKY.WhyIFly(input));
        }
    }
}
