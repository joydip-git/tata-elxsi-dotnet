using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Entities
{
    public class Developer : Employee
    {
        public decimal IncentivePayment { get; set; }

        public Developer() { }
        public Developer(int id, string name, decimal basicPayment, decimal daPayment, decimal hraPayment, decimal incentivePayment)
            :base(id, name, basicPayment, daPayment, hraPayment)
        {
            this.IncentivePayment = incentivePayment;
        }
    }
}
