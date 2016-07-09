namespace Hello_App.ViewModels
{
    public class EmployeeViewModel
    {
        public string EmployeeName { get; set; }
        public string Salary { get; set; }
        public string SalaryColor { get; set; }

        public EmployeeViewModel(string empName, string salary)
        {
            EmployeeName = empName;
            Salary = salary;
        }
    }
}
