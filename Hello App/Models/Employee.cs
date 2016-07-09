namespace Hello_App.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        public Employee(string firstN, string lastN, int salary)
        {
            FirstName = firstN;
            LastName = lastN;
            Salary = salary;
        }
    }
}