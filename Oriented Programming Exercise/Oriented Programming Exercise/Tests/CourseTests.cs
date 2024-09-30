using NUnit.Framework;
using Oriented_Programming_Exercise;

[TestFixture]
public class CourseTests
{
    private Student student1;
    private Student student2;
    private Professor professor1;
    private UndergraduateCourse undergraduateCourse;
    private GraduateCourse graduateCourse;

    [SetUp]
    public void Setup()
    {
        student1 = new Student("S1001", "John Doe", 20, "123 University St");
        student2 = new Student("S1002", "Jane Smith", 22, "456 College Ave");
        professor1 = new Professor("Dr. Brown", 50, "789 Academic Rd", "Computer Science");

        undergraduateCourse = new UndergraduateCourse("Intro to Programming", "CS101");
        graduateCourse = new GraduateCourse("Advanced Algorithms");
    }

    [Test]
    public void Test_AddMultipleParticipants()
    {
        undergraduateCourse.AddParticipant(student1);
        undergraduateCourse.AddParticipant(student2);
        undergraduateCourse.AddParticipant(professor1);

        var participants = undergraduateCourse.GetParticipants();
        Assert.That(participants, Has.Count.EqualTo(3));
        Assert.That(participants, Does.Contain(student1));
        Assert.That(participants, Does.Contain(student2));
        Assert.That(participants, Does.Contain(professor1));
    }

    [Test]
    public void Test_GetParticipants_EmptyList()
    {
        var participants = undergraduateCourse.GetParticipants();
        Assert.That(participants, Is.Empty);
    }

    [Test]
    public void Test_ToString_Student()
    {
        undergraduateCourse.AddParticipant(student1);
        var result = undergraduateCourse.ToString();
        Assert.That(result, Does.Contain(student1.GetName()));
        Assert.That(result, Does.Contain("Student ID"));

    }
    public void Test_ToString_Professor()
    {
        undergraduateCourse.AddParticipant(professor1);
        var result = undergraduateCourse.ToString();
        Assert.That(result, Does.Contain(professor1.GetName()));
        Assert.That(result, Does.Contain("Department"));

    }
    [Test]
    public void Test_ToString_GraduateCourse()
    {
        // Arrange
        var graduateCourse = new GraduateCourse("Advanced Algorithms");
        var student1 = new Student("S1001", "John Doe", 20, "123 University St");
        var student2 = new Student("S1002", "Jane Smith", 22, "456 College Ave");

        // Act
        graduateCourse.AddParticipant(student1); // נוסיף משתתף
        graduateCourse.AddParticipant(student2);
        var result = graduateCourse.ToString();

        // Assert
        Assert.That(result, Does.Contain("Graduate Course: Advanced Algorithms"));
        Assert.That(result, Does.Contain("Number of Participants: 2"));
    }
    [Test]
    public void Test_ToString_UndergraduateCourse()
    {
        // Arrange
        var undergraduateCourse = new UndergraduateCourse("Introduction to Programming", "UG101");
        var student1 = new Student("S1001", "John Doe", 20, "123 University St");
        var student2 = new Student("S1002", "Jane Smith", 22, "456 College Ave");

        // Act
        undergraduateCourse.AddParticipant(student1); // נוסיף משתתף
        undergraduateCourse.AddParticipant(student2);
        var result = undergraduateCourse.ToString();

        // Assert
        Assert.That(result, Does.Contain("Undergraduate Course: Introduction to Programming"));
        Assert.That(result, Does.Contain("(UG101)"));
        Assert.That(result, Does.Contain("Number of Participants: 2"));
    }


    [Test]
    public void Test_AddParticipantToGraduateCourse()
    {
        graduateCourse.AddParticipant(student1);
        var participants = graduateCourse.GetParticipants();
        Assert.That(participants, Does.Contain(student1));
    }

    [Test]
    public void Test_GetParticipants_FromGraduateCourse()
    {
        graduateCourse.AddParticipant(professor1);
        var participants = graduateCourse.GetParticipants();
        Assert.That(participants, Does.Contain(professor1));
    }
    [Test]
    public void Test_GetCourseName_GraduateCourse()
    {
        Assert.That(graduateCourse.GetCourseName(), Does.StartWith("Graduate Course in"));
    }

    [Test]
    public void Test_GetCourseCode_GraduateCourse()
    {
        // Assuming the course code is generated based on the research focus
        Assert.That(graduateCourse.GetCourseCode(), Does.Match("[A-Z]+")); // Check for uppercase letters
    }
}