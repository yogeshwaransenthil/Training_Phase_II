using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    abstract class Animal
    {
        private int eyes, ears, legs;
        public Animal(int eyes, int ears, int legs)
        {
            this.Eyes = eyes;
            this.Ears = ears;
            this.Legs = legs;
        }

        public int Eyes { get => eyes; set => eyes = value; }
        public int Ears { get => ears; set => ears = value; }
        public int Legs { get => legs; set => legs = value; }

        public static void Sleep()
        {
            Console.WriteLine("Sleeping ZZZZ");

        }
        public static void Eat()
        {
            Console.WriteLine("Eating em..em..");
        }
        public void AboutMe()
        {
            Console.WriteLine($"I have {Eyes} eyes {Ears} ears {Legs} legs");
        }

        public abstract void Sound();

    }
}