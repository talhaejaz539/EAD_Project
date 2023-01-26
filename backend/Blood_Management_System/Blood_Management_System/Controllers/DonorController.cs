using Blood_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blood_Management_System.Controllers
{
    public class DonorController : Controller
    {
        public IActionResult DataManager()
        {
            return View();
        }

        //[HttpPost]
        //public void addDonor(Donor d)
        //{
        //    Console.WriteLine(d.Name);
        //    Console.WriteLine(d.RollNo);
        //    Console.WriteLine(d.PhoneNo);
        //    Console.WriteLine(d.TemporaryAddress);
        //    Console.WriteLine(d.PermanentAddress);
        //    Console.WriteLine(d.LastDonationDate);
        //    Console.WriteLine(d.BloodGroup);
        //    Console.WriteLine(d.Status);
        //}

        //[HttpPost]
        //public void updateDonor(Donor d)
        //{
        //    Console.WriteLine(d.Name);
        //    Console.WriteLine(d.RollNo);
        //    Console.WriteLine(d.PhoneNo);
        //    Console.WriteLine(d.TemporaryAddress);
        //    Console.WriteLine(d.PermanentAddress);
        //    Console.WriteLine(d.LastDonationDate);
        //    Console.WriteLine(d.BloodGroup);
        //    Console.WriteLine(d.Status);
        //}

        //[HttpPost]
        //public void deleteDonor(Donor d)
        //{
        //    Console.WriteLine("Delete");
        //}
    }
}
