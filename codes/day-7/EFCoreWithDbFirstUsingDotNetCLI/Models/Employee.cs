using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreWithDbFirstUsingDotNetCLI.Models
{
    public partial class Employee
    {
        public int Employeeid { get; set; }
        public string Employeename { get; set; }
        public decimal Employeesalary { get; set; }
        public string Location { get; set; }
    }
}
