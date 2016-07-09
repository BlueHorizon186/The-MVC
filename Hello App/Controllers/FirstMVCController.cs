using Hello_App.Models;
using System.Web.Mvc;

namespace Hello_App.Controllers
{
    public class FirstMVCController : Controller
    {
        // GET: FirstMVC
        public ActionResult Greet()
        {
            return View();
        }

        public ActionResult ViewEmployee()
        {
            Employee emp = new Employee("Sukesh", "Marla", 20000);
            return View("ViewSelectedEmployee", emp);
        }
    }
}