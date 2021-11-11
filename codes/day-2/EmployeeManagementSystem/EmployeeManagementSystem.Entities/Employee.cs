using System;

namespace EmployeeManagementSystem.Entities
{
    public class Employee
    {
        #region Data Members
        //private int id;
        //private string name;
        //private decimal basicPayment;
        //private decimal daPayment;
        //private decimal hraPayment;
        //private decimal totalSalary;
        #endregion

        #region Constructors
        public Employee() { }

        public Employee(int id, string name, decimal basicPayment, decimal daPayment, decimal hraPayment)
        {
            //this.id = id;
            //this.name = name;
            //this.basicPayment = basicPayment;
            //this.daPayment = daPayment;
            //this.hraPayment = hraPayment;

            this.Id = id;
            this.Name = name;
            this.BasicPayment = basicPayment;
            this.DaPayment = daPayment;
            this.HraPayment = hraPayment;
        }

        #endregion

        #region Properties
        public decimal TotalSalary
        {
            get;// { return totalSalary; }
            private set;// { totalSalary = value; }
        }

        public decimal HraPayment
        {
            get;// { return hraPayment; }
            set;// { hraPayment = value; }
        }

        public decimal DaPayment
        {
            get;// { return daPayment; }
            set;// { daPayment = value; }
        }

        public decimal BasicPayment
        {
            get;// { return basicPayment; }
            set;// { basicPayment = value; }
        }

        public string Name
        {
            get; //{ return name; }
            set;// { name = value; }
        }

        public int Id
        {
            get;// { return id; }
            set;// { id = value; }
        }
        #endregion 

        #region Methods
        public void CalculateSalary()
        {
            // this.totalSalary = this.basicPayment + this.daPayment + this.hraPayment;
            this.TotalSalary = this.BasicPayment + this.DaPayment + this.HraPayment;
        }
        #endregion
    }
}
