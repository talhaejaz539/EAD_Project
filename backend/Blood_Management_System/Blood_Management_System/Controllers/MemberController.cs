using Microsoft.AspNetCore.Mvc;

namespace Blood_Management_System.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
