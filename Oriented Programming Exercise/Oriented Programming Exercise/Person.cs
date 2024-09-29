using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oriented_Programming_Exercise
{
    public abstract class Person
    {
        private string name;
        private int age;
        // Address is marked as protected. This means it can be accessed by derived classes but not directly from outside the class hierarchy.
        protected string address;

        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        // This method is abstract. Derived classes must implement it to provide their specific role (e.g., Student, Instructor).
        public abstract string GetRole();

        public string GetName()
        {
            return this.name;
        }

        public int GetAge()
        {
            return this.age;
        }

        public string GetAddress()
        {
            return this.address;
        }

        public override string ToString()
        {
            return $"Name: {name}, Age: {age}, Address: {address}";
        }
    }
}
