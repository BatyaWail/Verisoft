using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oriented_Programming_Exercise
{
    public class GraduateCourse : Course
    {
        private string researchFocus;
        // Added an array of participants to allow adding and retrieving participants
        // This is a helper variable that is not known to the main program
        private List<Person> participants;

        public GraduateCourse(string researchFocus)
        {
            this.researchFocus = researchFocus;
            // Initialize the participants list
            this.participants = new List<Person>();
        }

        // Returns the course name based on the provided variable
        public string GetCourseName()
        {
            return $"Graduate Course in {researchFocus} (Focus: Advanced Topics)";
        }

        // Returns the course code - the provided variable in uppercase letters
        public string GetCourseCode()
        {
            // Split the string into words by spaces
            string[] words = this.researchFocus.Split(' ');
            // Take the first letter of each word and make it uppercase
            string code = string.Concat(words.Select(word => word.Substring(0, 1).ToUpper()));
            return code;
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
                   $"\nResearch Focus: {researchFocus}" +
                   $"\nNumber of Participants: {participants.Count}";
        }
    }
}
