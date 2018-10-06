using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Cat : Pet
    {
        private double v;

        public Cat(string Name) : base(Name)
        {
            this.name = Name;
        }

        public Cat(string Name, string Owner) : base(Name, Owner)
        {
            this.name = Name;
            this.owner = Owner;
        }

        public Cat(string Name, string Owner, double Weight) : base(Name, Owner, Weight)
        {
            this.name = Name;
            this.owner = Owner;
            this.weight = Weight;
        }

        public Cat(string Name, string Owner, double Weight, double v) : base(Name, Owner, Weight)
        {
            this.name = Name;
            this.owner = Owner;
            this.weight = Weight;
            this.v = v;
        }

        public void meow(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write("meow.");
            }
            Console.WriteLine("");
        }
    }
}
