using Blood_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blood_Management_System.Controllers
{
    public class MemberController : Controller
    {

        private readonly IWebHostEnvironment Environment;

        public MemberController(IWebHostEnvironment environment)
        {
            Environment = environment;

        }

        public IActionResult Admin()
        {

            //if (HttpContext.Session.GetString("Designation").Equals("President"))
            //    return RedirectToAction("Index", "Home");

            string name = "";
            if (HttpContext.Request.Cookies.ContainsKey("nameOfUser"))
                name = HttpContext.Request.Cookies["nameOfUser"];
            //Console.WriteLine(name);
            ViewData["name"] = name;

            MemberRepository memberRepository = new MemberRepository();
            List<Member> members = new List<Member>();
            members = memberRepository.GetMembers();

            return View(members);
        }

        [HttpPost]
        public IActionResult addMember(Member m, IFormFile postedFiles)
        {
            //Console.WriteLine(m.Name);
            //Console.WriteLine(m.Email);
            //Console.WriteLine(m.Password);
            //Console.WriteLine(m.RollNo);
            //Console.WriteLine(m.Phone);
            //Console.WriteLine(m.Designation);
            //Console.WriteLine(m.ListGroup);
            //Console.WriteLine(m.Status);

            string wwwPath = this.Environment.WebRootPath;
            string path = Path.Combine(wwwPath, "Uploads");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            //foreach (var file in postedFile)
            //{
                var fileName = Path.GetFileName(postedFiles.FileName);
                var pathWithFileName = Path.Combine(path, fileName);
                using (FileStream stream = new FileStream(pathWithFileName, FileMode.Create))
                {
                    postedFiles.CopyTo(stream);
                    //ViewBag.Message = "File Uploaded Successfully";
                }
            //}

            MemberRepository memberRepository = new MemberRepository();
            memberRepository.signUp(m);

            return RedirectToAction("Admin");
        }

        [HttpPost]
        public IActionResult updateMember(Member m)
        {
            //Console.WriteLine(m.Id);
            //Console.WriteLine(m.Name);
            //Console.WriteLine(m.Email);
            //Console.WriteLine(m.RollNo);
            //Console.WriteLine(m.Phone);
            //Console.WriteLine(m.Designation);
            //Console.WriteLine(m.ListGroup);
            //Console.WriteLine(m.Status);

            MemberRepository memberRepository = new MemberRepository();
            memberRepository.updateMember(m);

            return RedirectToAction("Admin");
        }

        public IActionResult deleteMember(int id)
        {
            Console.WriteLine(id);
            MemberRepository memberRepository = new MemberRepository();
            memberRepository.delete(id);

            return RedirectToAction("Admin");
        }
    }
}
