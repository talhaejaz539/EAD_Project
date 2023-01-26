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
        public IActionResult authenticateUser(Member member)
        {
            Console.WriteLine(member.Email);
            Console.WriteLine(member.Password);
            MemberRepository m = new MemberRepository();
            Member mem = m.login(member);
            Console.WriteLine(mem);
            if (mem.Designation.Equals("President"))
                return RedirectToAction("Admin", "Member");
            else if (mem.Designation.Equals("Data Manager"))
                return RedirectToAction("DataManager", "Donor");
            else if (mem.Designation.Equals("Blood Manager"))
                return RedirectToAction("BloodManager", "BloodRequest");
            else if (mem.Designation.Equals("Blood Organizer"))
                return RedirectToAction("BloodOrganizer", "BloodRequest");
            return RedirectToAction("Index");
        }
    }
}