using System;
using System.Web.Mvc;

namespace Hello_App.Controllers
{
    public class FirstMVCController : Controller
    {
        // GET: FirstMVC
        public ActionResult Greet()
        {
            return View("HelloView");
        }

        public ActionResult DisplayCurrentTime()
        {
            ViewData["CurrentTime"] = DateTime.Now.ToString();
            return View();
        }
    }
}