namespace Hello_App.ViewModels
{
    public class EmployeeViewModel
    {
        public string EmployeeName { get; set; }
        public string Salary { get; set; }
        public string SalaryColor { get; set; }
        public string Username { get; set; }

        public EmployeeViewModel(string empName, string salary, string username)
        {
            EmployeeName = empName;
            Salary = salary;
            Username = username;
        }
    }
}
