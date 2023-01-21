using Blood_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Blood_Management_System.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void authenticateUser(Member m)
        {
            Console.WriteLine(m.Email);
            Console.WriteLine(m.Password);
        }
    }
}