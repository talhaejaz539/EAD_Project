﻿using Microsoft.AspNetCore.Mvc;

namespace Blood_Management_System.Controllers
{
    public class DonorController : Controller
    {
        public IActionResult DataManager()
        {
            return View();
        }
    }
}