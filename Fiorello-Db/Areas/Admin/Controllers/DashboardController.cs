﻿using Microsoft.AspNetCore.Mvc;

namespace Fiorello_Db.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
