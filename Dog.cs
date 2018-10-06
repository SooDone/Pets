using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Dog : Pet
    {
        private double v;

        public Dog(string Name) :base(Name)
        {
            this.name = Name;
        }

        public Dog(string Name, string Owner) :base(Name, Owner)
        {
            this.name = Name;
            this.owner = Owner;
        }

        public Dog(string Name, string Owner, double Weight) :base(Name, Owner, Weight)
        {
            this.name = Name;
            this.owner = Owner;
            this.weight = Weight;
        }

        public Dog(string Name, string Owner, double Weight, double v) : base(Name, Owner, Weight)
        {
            this.name = Name;
            this.owner = Owner;
            this.weight = Weight;
            this.v = v;
        }
        public void bark(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write("bark!");
            }
            Console.WriteLine("");
        }
    }
}
