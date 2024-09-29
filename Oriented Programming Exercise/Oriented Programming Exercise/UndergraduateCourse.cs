using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oriented_Programming_Exercise
{
    public class UndergraduateCourse : Course
    {
        private string courseName;
        private string courseCode;
        // Added an array of participants to allow adding and retrieving participants
        // This is a helper variable that is not known to the main program
        private List<Person> participants;
        public UndergraduateCourse(string courseName, string courseCode)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            // Initialize the participants list
            this.participants = participants = new List<Person>();
        }
        public string GetCourseName()
        {
            return courseName;
        }
        public string GetCourseCode()
        {
            return courseCode;
        }

        public void AddParticipant(Person person)
        {
            participants.Add(person);
        }

        public List<Person> GetParticipants()
        {
            return participants;
        }
        public override string ToString()
        {
            // A more concise way to format the string
            return $"Graduate Course: {GetCourseName()} ({GetCourseCode()})" +
                   $"\nNumber of Participants: {participants.Count}";
        }


    }
}
