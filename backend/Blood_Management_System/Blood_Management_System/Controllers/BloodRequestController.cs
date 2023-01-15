using Microsoft.AspNetCore.Mvc;

namespace Blood_Management_System.Controllers
{
    public class BloodRequestController : Controller
    {
        public IActionResult BloodManager()
        {
            return View();
        }

        public IActionResult BloodOrganizer()
        {
            return View();
        }
    }
}
