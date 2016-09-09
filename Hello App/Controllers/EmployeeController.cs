using Hello_App.Models;
using Hello_App.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Hello_App.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: FirstMVC
        public ActionResult Greet()
        {
            return View();
        }

        public ActionResult Index()
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
            return View(empLstModel);
        }

        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }

        public ActionResult SaveEmployee(Employee e, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Employee":
                    if (ModelState.IsValid)
                    {
                        var empBAL = new EmployeeBusinessLayer();
                        empBAL.SaveEmployee(e);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View("CreateEmployee");
                    }
                case "Cancel":
                    return RedirectToAction("Index");
            }
            return new EmptyResult();
        }
    }
}
