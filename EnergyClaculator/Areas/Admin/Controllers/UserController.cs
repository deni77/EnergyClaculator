﻿using Microsoft.AspNetCore.Mvc;

namespace EnergyCalculator.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}