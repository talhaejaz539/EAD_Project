using Blood_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blood_Management_System.Controllers
{
    public class DonorController : Controller
    {
        public IActionResult DataManager()
        {
            string name = "";
            if (HttpContext.Request.Cookies.ContainsKey("nameOfUser"))
                name = HttpContext.Request.Cookies["nameOfUser"];
            //Console.WriteLine(name);
            ViewData["name"] = name;
            DonorRepository donorRepository = new DonorRepository();
            List<Donor> donors = new List<Donor>();
            donors = donorRepository.getDonors();

            return View(donors);
        }

        [HttpPost]
        public IActionResult addDonor(Donor d)
        {
            Console.WriteLine(d.Id);
            Console.WriteLine(d.Name);
            Console.WriteLine(d.RollNo);
            Console.WriteLine(d.PhoneNo);
            Console.WriteLine(d.TemporaryAddress);
            Console.WriteLine(d.PermanentAddress);
            Console.WriteLine(d.LastDonationDate);
            Console.WriteLine(d.BloodGroup);
            Console.WriteLine(d.Status);

            DonorRepository donorRepository = new DonorRepository();
            donorRepository.addDonor(d);

            return RedirectToAction("DataManager");
        }

        [HttpPost]
        public IActionResult updateDonor(Donor d)
        {
            Console.WriteLine("Update");
            Console.WriteLine(d.Id);
            Console.WriteLine(d.Name);
            Console.WriteLine(d.RollNo);
            Console.WriteLine(d.PhoneNo);
            Console.WriteLine(d.TemporaryAddress);
            Console.WriteLine(d.PermanentAddress);
            Console.WriteLine(d.LastDonationDate);
            Console.WriteLine(d.BloodGroup);
            Console.WriteLine(d.Status);

            DonorRepository donorRepository = new DonorRepository();
            donorRepository.update(d);

            return RedirectToAction("DataManager");
        }

        public IActionResult deleteDonor(int id)
        {
            Console.WriteLine(id);
            DonorRepository donorRepository = new DonorRepository();
            donorRepository.delete(id);

            return RedirectToAction("DataManager");
        }
    }
}
