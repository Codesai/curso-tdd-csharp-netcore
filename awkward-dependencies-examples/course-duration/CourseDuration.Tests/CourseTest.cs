using NUnit.Framework;

namespace CourseDuration.Tests;

public class CourseTest
{
    private Course _course;

    [SetUp]
    public void SetUp()
    {
        _course = new Course("macramé");
    }
    
    [Test]
    public void Identifies_Short_Courses()
    {
       _course.Start();
       _course.End();
       
       Assert.That(_course.IsShort, Is.True);
    }

    [Test]
    [Ignore("pending")]
    public void Identifies_Long_Courses()
    {
    }
    
    [Test]
    [Ignore("pending")]
    public void Knows_The_Course_Title()
    {
    }
    
}