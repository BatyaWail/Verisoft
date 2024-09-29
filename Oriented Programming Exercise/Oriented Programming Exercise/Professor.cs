using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oriented_Programming_Exercise
{
    // The Professor class inherits the Person class and adds a department property
    public class Professor : Person
    {
        // Private variable to store the name of the department (Department) where the professor teaches
        private string department;

        public Professor(string name, int age, string address,string department) : base(name, age, address)
        {
            this.department = department;
        }

        public override string GetRole()
        {
            return "Professor";
        }
        public string Teach()
        {
            return "Teaching students complex subjects in a clear and understandable way.";
        }
        public override string ToString()
        {
            return base.ToString() + $", Department: {department}";
        }

    }
}
