using Microsoft.AspNetCore.Mvc;

namespace Blood_Management_System.Controllers
{
    public class BloodRequestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
