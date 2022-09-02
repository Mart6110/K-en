using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    class Guest
    {
        // Properties
        private string name;
        private byte age;

        // Encapsulation
        public string Name { get { return name; } }
        public byte Age { get { return age; } }

        // Constructor
        public Guest(string name, byte age)
        {
            this.name = name;
            this.age = age;
        }

        // Override ToString
        public override string ToString()
        {
            return Name + " " + Age;
        }
    }
}
