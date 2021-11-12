namespace EmployeeManagementSystem.Entities
{
    public class Hr : Employee
    {
        public decimal GratuityPayment { get; set; }
        public Hr() { }
        public Hr(int id, string name, decimal basicPayment, decimal daPayment, decimal hraPayment, decimal gratuityPayment)
            : base(id, name, basicPayment, daPayment, hraPayment)
        {
            this.GratuityPayment = gratuityPayment;
        }

        public override void CalculateSalary()
        {
            base.CalculateSalary();
            this.TotalSalary += this.GratuityPayment;
        }
    }
}
