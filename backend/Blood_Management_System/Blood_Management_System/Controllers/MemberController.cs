using Blood_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blood_Management_System.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Admin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult addMember(Member m)
        {
            Console.WriteLine(m.Name);
            Console.WriteLine(m.Email);
            Console.WriteLine(m.Password);
            Console.WriteLine(m.RollNo);
            Console.WriteLine(m.Phone);
            Console.WriteLine(m.Designation);
            Console.WriteLine(m.ListGroup);
            Console.WriteLine(m.Status);

            MemberRepository memberRepository = new MemberRepository();
            memberRepository.signUp(m);

            return RedirectToAction("Admin");
        }

        //[HttpPost]
        //public void updateMember(Member m)
        //{
        //    Console.WriteLine(m.Name);
        //    Console.WriteLine(m.Email);
        //    Console.WriteLine(m.RollNo);
        //    Console.WriteLine(m.Phone);
        //    Console.WriteLine(m.Designation);
        //    Console.WriteLine(m.ListGroup);
        //    Console.WriteLine(m.Status);
        //}

        //[HttpPost]
        //public void deleteMember(Member m)
        //{
        //    Console.WriteLine("Delete");
        //}
    }
}
