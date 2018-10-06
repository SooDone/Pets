using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pet
    {
        public string type;
        public string name;
        public string owner;
        public double weight;

        public Pet()
        {

        }

        public Pet(string Type)
        {
            this.type = Type;
        }

        public Pet(string Type, string Name)
        {
            this.type = Type;
            this.name = Name;
        }

        public Pet(string Type, string Name, string Owner)
        {
            this.type = Type;
            this.name = Name;
            this.owner = Owner;
        }

        public Pet(string Type, string Name, double weight) : this(Type, Name)
        {
            this.weight = weight;
        }

        public Pet(string Type, string Name, string Owner, double Weight)
        {
            this.type = Type;
            this.name = Name;
            this.owner = Owner;
            this.weight = Weight;
        }

        public void getTag()
        {           
            Console.WriteLine("If lost, call {0}", owner);
        }
    }
}
