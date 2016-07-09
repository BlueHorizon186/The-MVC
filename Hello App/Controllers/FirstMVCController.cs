using Hello_App.Models;
using Hello_App.ViewModels;
using System.Collections.Generic;
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
            var empLstModel = new EmployeeListViewModel();
            var empBal = new EmployeeBusinessLayer();

            List<Employee> employees = empBal.GetEmployees();
            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            foreach (var emp in employees)
            {
                var empVM = new EmployeeViewModel(
                    emp.FirstName + " " + emp.LastName,
                    emp.Salary.ToString("C"));

                if (emp.Salary > 15000) { empVM.SalaryColor = "greenyellow"; }
                else { empVM.SalaryColor = "forestgreen"; }
                empViewModels.Add(empVM);
            }

            empLstModel.Employees = empViewModels;
            empLstModel.Username = "Admin";
            return View("ViewSelectedEmployee", empLstModel);
        }
    }
}
