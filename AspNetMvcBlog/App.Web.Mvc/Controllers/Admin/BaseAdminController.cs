﻿using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public abstract class BaseAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
