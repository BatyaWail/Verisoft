using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oriented_Programming_Exercise
{
    // The Student class inherits the Person class and adds a studentId property
    public class Student:Person
    {
        // Private variable to store student id
        private string studentId;
        public Student(string studentId,string name, int age, string address) : base(name, age, address)
        {
            this.studentId = studentId;
        }

        public override string GetRole()
        {
            return "Student";
        }

        public string Study()
        {
            return "Immersed in deep learning and expanding knowledge.";
        }

        public override string ToString()
        {
            return base.ToString() + $", Student ID: {studentId}";
        }
    }
}
