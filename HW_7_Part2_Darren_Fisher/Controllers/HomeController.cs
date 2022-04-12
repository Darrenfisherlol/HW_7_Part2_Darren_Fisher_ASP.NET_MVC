using Microsoft.AspNetCore.Mvc;

namespace HW_7_Part2_Darren_Fisher.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
            return new ContentResult {Content = "This is HW part 7"};


        }

        // a/b is the new route instead if SecondPage
        
        //[Route("a/b")]

        public IActionResult SecondPage()
        {

            return View();
            return new ContentResult { Content = "This is the 2nd webpage in home controller" };

        }
}
}
