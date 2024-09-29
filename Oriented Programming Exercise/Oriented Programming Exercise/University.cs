using Oriented_Programming_Exercise;

Student student1 = new Student("S1001", "John Doe", 20, "123 University St");
Student student2 = new Student("S1002", "Jane Smith", 22, "456 College Ave");
Student student3 = new Student("S1003", "Alice Johnson", 21, "789 Campus Dr");
Student student4 = new Student("S1004", "Bob Miller", 23, "456 Elm St");
Professor professor1 = new Professor("Dr. Brown", 50, "789 Academic Rd", "Computer Science");
Professor professor2 = new Professor("Dr. Davis", 48, "123 Faculty Ln", "Mathematics");

// Create courses
UndergraduateCourse undergraduateCourse = new UndergraduateCourse("Intro to Programming", "CS101");
GraduateCourse graduateCourse = new GraduateCourse("Advanced Algorithms");

// Add participants to courses
undergraduateCourse.AddParticipant(student1);
undergraduateCourse.AddParticipant(student2);
undergraduateCourse.AddParticipant(professor1);
undergraduateCourse.AddParticipant(professor2);

graduateCourse.AddParticipant(student3);
graduateCourse.AddParticipant(student4);
graduateCourse.AddParticipant(professor1);
graduateCourse.AddParticipant(professor2);

// Display participants in undergraduate course
//Console.Write("Participants in Undergraduate Course:");
Console.WriteLine(undergraduateCourse);

foreach (Person participant in undergraduateCourse.GetParticipants())
{
    Console.Write(participant.GetRole() + "   -------------   ");
    Console.WriteLine(participant);
    if (participant is Student)
    {
        Console.WriteLine($"Learn now: {((Student)participant).Study()}");
    }
    else if (participant is Professor)
    {
        Console.WriteLine($"Teach students now: {((Professor)participant).Teach()} ");
    }
}
Console.WriteLine();
// Display participants in graduate course
//Console.WriteLine("\nParticipants in Graduate Course:\n");
Console.WriteLine(graduateCourse);
foreach (Person participant in graduateCourse.GetParticipants())
{
    Console.Write(participant.GetRole() + "   -------------   ");
    Console.WriteLine(participant);
    if (participant is Student)
    {
        Console.WriteLine($"Learn now: {((Student)participant).Study()}");
    }
    else if (participant is Professor)
    {
        Console.WriteLine($"Teach students now: {((Professor)participant).Teach()} ");
    }
}