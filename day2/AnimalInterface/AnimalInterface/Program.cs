using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{

    class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Sound { get; set; }
    }

    class Bear : IAnimal
    {
        public string Name { get; set; }
        public string Sound { get; set; }
        public string MakeSound()
        {
            return Sound;
        }
    }

    class Chicken : IAnimal
    {
        public string Name { get; set; }
        public string Sound { get; set; }
        public string MakeSound()
        {
            return Sound;
        }
    }

    class Eagle : IAnimal
    {
        public string Name { get; set; }
        public string Sound { get; set; }
        public string MakeSound()
        {
            return Sound;
        }
    }

    class AnimalUtility
    {
        public void DoSomething(string animal)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var animals = new Animal[]
            //{
            //    new Animal {Name = "Pooh Bear", Sound = "Oh bother" },
            //    new Animal {Name = "Chicken Little", Sound = "The sky is falling" },
            //    new Animal {Name = "Sam the Eagle", Sound = "I am not amused" }

            //};
            

            //Console.WriteLine(animal1.MakeSound());
            Console.ReadLine();
        }
    }
}
