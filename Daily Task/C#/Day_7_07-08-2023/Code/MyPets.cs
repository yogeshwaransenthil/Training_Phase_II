using Basic_Programs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProgram
{
    class MyPets : Animal
    {
        private string? name = string.Empty;
        public MyPets(int eyes, int ears, int legs, string name) : base(eyes, ears, legs)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }

        public override void Sound()
        {
            if (Name.ToLower().Equals("Dog"))
            {
                Console.WriteLine("Bow Bow......");
            }
            else if (Name.ToLower().Equals("Cat"))
            {
                Console.WriteLine("Meow Meow.....");
            }
        }
    }
}