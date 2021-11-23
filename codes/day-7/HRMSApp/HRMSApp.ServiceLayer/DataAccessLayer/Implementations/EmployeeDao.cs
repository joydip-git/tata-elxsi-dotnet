using HRMSApp.ServiceLayer.DataAccessLayer.Contracts;
using HRMSApp.ServiceLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HRMSApp.ServiceLayer.DataAccessLayer.Implementations
{
    public class EmployeeDao : IApplicationDao<Employee>
    {
        private ApplicationDbContext _dbContext;

        public EmployeeDao() { }

        public EmployeeDao(ApplicationDbContext dbContext) 
        {
            this._dbContext = dbContext;
        }
        public int Add(Employee data)
        {
            try
            {
                this._dbContext.Employees.Add(data);
                return this._dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            try
            {
                return this._dbContext.Employees.ToList<Employee>();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Employee Get(int id)
        {
            try
            {
                return this._dbContext.Employees.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Update(Employee data)
        {
            throw new NotImplementedException();
        }
    }
}
