using Blood_Management_System.Data;
using Blood_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Blood_Management_System.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Response.Cookies.Delete("nameOfUser");
            return View();
        }

        [HttpPost]
        public IActionResult authenticateUser(Member member)
        {
            try
            {
                MemberRepository m = new MemberRepository();
                Member mem = m.login(member);

                string cookieData = String.Empty;
                string sessionData = String.Empty;
                if (mem != null)
                {
                    cookieData = "Welcome " + mem.Name;
                    //sessionData = mem.Designation;
                    HttpContext.Response.Cookies.Append("nameOfUser", cookieData);
                    //HttpContext.Session.SetString("Designation", sessionData);
                }

                if (mem.Designation.Equals("President"))
                    return RedirectToAction("Admin", "Member");
                else if (mem.Designation.Equals("Data Manager"))
                    return RedirectToAction("DataManager", "Donor");
                else if (mem.Designation.Equals("Blood Manager"))
                    return RedirectToAction("BloodManager", "BloodRequest");
                else if (mem.Designation.Equals("Blood Organizer"))
                    return RedirectToAction("BloodOrganizer", "BloodRequest");

            } catch(Exception e)
            {
                //return RedirectToAction("Index");
            }





            //if (HttpContext.Request.Cookies.ContainsKey("nameOfUser"))
            //{
            //    string firstVisitedDateTime = HttpContext.Request.Cookies["nameOfUser"];
            //    cookieData = "Welcome back " + firstVisitedDateTime;

            //}
            //else
            //{
            //    CookieOptions option = new CookieOptions();
            //    option.Expires = System.DateTime.Now.AddDays(1);
            //    cookieData = "Welcome " + mem.Name;
            //    HttpContext.Response.Cookies.Append("nameOfUser", cookieData, option);
            //}
            return RedirectToAction("Index");
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Index");
        }
    }
}