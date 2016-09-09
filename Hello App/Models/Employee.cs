using System.ComponentModel.DataAnnotations;

namespace Hello_App.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter your first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter your last name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage =  "Enter your salary.")]
        public int Salary { get; set; }

        //public Employee() { }

        //public Employee(string firstN, string lastN, int salary)
        //{
        //    FirstName = firstN;
        //    LastName = lastN;
        //    Salary = salary;
        //}
    }
}