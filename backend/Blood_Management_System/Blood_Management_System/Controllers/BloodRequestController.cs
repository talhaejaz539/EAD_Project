using Microsoft.AspNetCore.Mvc;

namespace Blood_Management_System.Controllers
{
    public class BloodRequestController : Controller
    {
        public IActionResult BloodManager()
        {
            string name = "";
            if (HttpContext.Request.Cookies.ContainsKey("nameOfUser"))
                name = HttpContext.Request.Cookies["nameOfUser"];
            //Console.WriteLine(name);
            ViewData["name"] = name;
            return View();
        }

        public IActionResult BloodOrganizer()
        {
            string name = "";
            if (HttpContext.Request.Cookies.ContainsKey("nameOfUser"))
                name = HttpContext.Request.Cookies["nameOfUser"];
            //Console.WriteLine(name);
            ViewData["name"] = name;
            return View();
        }
    }
}
