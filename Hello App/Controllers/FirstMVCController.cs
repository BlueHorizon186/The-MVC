﻿using System.Web.Mvc;

namespace Hello_App.Controllers
{
    public class FirstMVCController : Controller
    {
        // GET: FirstMVC
        public ActionResult Greet()
        {
            return View();
        }
    }
}