

using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;
public class CourseController : Controller
{

    //localhost:5255 course
    public ActionResult Index()
    {
        return View();
    }


    //localhost:5255 course/details
    public ActionResult Details()
    {
        Course course = new Course();
        course.courseName = "C#";
        course.courseDescription = "C# is a programming language";
        course.coursePrice = 5000;
        return View(course);

    }

    //localhost:5255/course/list
    public ActionResult List()
    {
        // string[] courses = { "C#", "Java", "Python", "JavaScript" };
        // ViewData["Courses"] = courses[0];
        // string[] courseDetails = { "C# is a programming language", "Java is a programming language", "Python is a programming language", "JavaScript is a programming language" };
        // ViewData["CourseDetails"] = courseDetails[0];

        Course course = new Course
        {
            courseName = "C#",
            courseDescription = "C# is a programming language",
            coursePrice = 5000
        };

        Course course1 = new Course
        {
            courseName = "Java",
            courseDescription = "Java is a programming language",
            coursePrice = 6000
        };


        Course course2 = new Course
        {
            courseName = "Python",
            courseDescription = "Python is a programming language",
            coursePrice = 7000
        };



        List<Course> courses = new List<Course> { course, course1, course2 };
        return View(courses);
    }
}
