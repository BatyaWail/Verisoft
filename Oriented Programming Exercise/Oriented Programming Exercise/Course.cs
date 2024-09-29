using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oriented_Programming_Exercise
{
    public interface Course
    {
        // Returns the name of the course
        string GetCourseName();

        // Returns the code of the course
        string GetCourseCode();

        // Adds a participant (Person) to the course
        void AddParticipant(Person person);

        // Returns the list of participants in the course
        List<Person> GetParticipants();
    }
}
