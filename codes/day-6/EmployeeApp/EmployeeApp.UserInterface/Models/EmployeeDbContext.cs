using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmployeeApp.UserInterface.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }
        public ICollection<Employee> Employees 
        {
            //public ICollection<Employee> Get()
            get;
            set;
        }
    }
}
