using Hello_App.Models;
using System.Data.Entity;

namespace Hello_App.DataAccessLayer
{
    public class SalesERPDAL : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("EmployeesTable");
            base.OnModelCreating(modelBuilder);
        }
    }
}