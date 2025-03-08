using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class HomeController : Controller
{

    //localhost:5255 home
    public ActionResult Index()
    {
        int num1,num2;
        num1=10;
        num2=20;
        int sum=num1+num2;
        ViewData["Sum"]=sum;
        
        return View();
    }


    //localhost:5255/home/about
    public ActionResult About()
    {
        return View();
    }

    //localhost:5255/home/contact
    public ActionResult Contact()
    {
        return View();
    }

}
