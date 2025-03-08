

using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;
public class CourseController : Controller
{

    List<Course> courses = new List<Course> {
    new Course {id=1, courseName = "C#", courseDescription = "C# is a programming language", coursePrice = 5000 },
    new Course {id=2, courseName = "Java", courseDescription = "Java is a programming language", coursePrice = 6000 },
    new Course { id=3,courseName = "Python", courseDescription = "Python is a programming language", coursePrice = 7000 },
};
    //localhost:5255 course
    public ActionResult Index()
    {
        return View(courses);
    }


    //localhost:5255 course/details
    public ActionResult Details(int id)
    {
        Course? course = courses.Where(x => x.id == id).FirstOrDefault();

        return View(course);

    }

    //localhost:5255/course/list
    public ActionResult List()
    {
        // string[] courses = { "C#", "Java", "Python", "JavaScript" };
        // ViewData["Courses"] = courses[0];
        // string[] courseDetails = { "C# is a programming language", "Java is a programming language", "Python is a programming language", "JavaScript is a programming language" };
        // ViewData["CourseDetails"] = courseDetails[0];

        return View(courses);
    }
}
