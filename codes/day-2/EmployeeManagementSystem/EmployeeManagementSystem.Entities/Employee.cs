namespace EmployeeManagementSystem.Entities
{
    public class Employee
    {
        
        #region Constructors
        public Employee() { }

        public Employee(int id, string name, decimal basicPayment, decimal daPayment, decimal hraPayment)
        {
            this.Id = id;
            this.Name = name;
            this.BasicPayment = basicPayment;
            this.DaPayment = daPayment;
            this.HraPayment = hraPayment;
        }

        #endregion

        #region Properties
        public decimal TotalSalary { get; protected set; }

        public decimal HraPayment
        {
            get;
            set;
        }

        public decimal DaPayment
        {
            get;
            set;
        }

        public decimal BasicPayment
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }
        #endregion 

        #region Methods
        public virtual void CalculateSalary()
        {
            this.TotalSalary = this.BasicPayment + this.DaPayment + this.HraPayment;
        }
        #endregion
    }
}
