using System.Collections.Generic;

namespace Hello_App.ViewModels
{
    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
        public string Username { get; set; }
    }
}