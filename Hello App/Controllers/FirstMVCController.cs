using Hello_App.Models;
using Hello_App.ViewModels;
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
            EmployeeViewModel empVM = new EmployeeViewModel(
                emp.FirstName + " " + emp.LastName,
                emp.Salary.ToString("C"),
                "Administrator");

            if (emp.Salary > 15000) { empVM.SalaryColor = "greenyellow"; }
            else { empVM.SalaryColor = "forestgreen"; }
            return View("ViewSelectedEmployee", empVM);
        }
    }
}
