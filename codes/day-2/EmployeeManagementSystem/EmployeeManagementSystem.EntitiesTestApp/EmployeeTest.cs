using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagementSystem.Entities;

namespace EmployeeManagementSystem.EntitiesTestApp
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void CalculateSalaryTestMethod()
        {
            Employee joydipEmployeeObjRef = new Employee(1, "joydip", 1000, 2000, 3000);
            joydipEmployeeObjRef.CalculateSalary();
            decimal actualSalary = joydipEmployeeObjRef.TotalSalary;
            Assert.AreEqual(6000, actualSalary);
        }
    }
}
