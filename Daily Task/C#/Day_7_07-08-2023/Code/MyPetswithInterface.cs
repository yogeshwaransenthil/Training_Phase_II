using Basic_Programs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class MyPetswithInterface : IAnimal
    {
        private int eyes, ears, legs;
        private string? name = string.Empty;
        public MyPetswithInterface(int eyes, int ears, int legs, string? name)
        {
            this.Eyes = eyes;
            this.Ears = ears;
            this.Legs = legs;
            this.name = name;
        }

        public int Eyes { get => eyes; set => eyes = value; }
        public int Ears { get => ears; set => ears = value; }
        public int Legs { get => legs; set => legs = value; }

        public void Sleep()
        {

            Console.WriteLine("Sleeping ZZZZ");

        }
        public void Eat()
        {
            Console.WriteLine("Eating em..em..");
        }


        public void AboutMe()
        {
            Console.WriteLine($"I have {Eyes} eyes {Ears} ears {Legs} legs");
        }

        public void Sound()
        {

        }
    }
}