using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace Example.Controllers
{

    // The controller methods get mapped to routes
    // for example  the name HelloWorldController 
    // is mapped to /HelloWorld 
    // and each method like Welcome() is linked
    // to /HelloWorld/Welcome

    public class HelloWorldController : Controller
    {
    public IActionResult Index()
    {
        //return "This is my default action...";
        return View();
    }

    // public string Welcome()
    // {
    //     return "This is the welcome action method";
    // }

    // public string Welcome (string name, int numTimes =1)
    // {
    //     return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    // }

    public IActionResult Welcome (string name, int numTimes=1)
    {
        // the view data dictionary is a dynamic object so any type can be used. 
       // the viewData dictionary contains data that will be passed to the view.
        ViewData["Message"] = "Hello" + name;
        ViewData["NumTimes"] = numTimes;

        return View();
    }


    }


}   