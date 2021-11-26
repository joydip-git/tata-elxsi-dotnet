using HRMSApp.ServiceLayer.BusinessLayer.Contracts;
using HRMSApp.ServiceLayer.DataAccessLayer.Contracts;
using HRMSApp.ServiceLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMSApp.ServiceLayer.BusinessLayer.Implementations
{
    public class EmployeeBO : IApplicationBO<Employee>
    {
        IApplicationDao<Employee> _employeeDao;

        public EmployeeBO() { }

        public EmployeeBO(IApplicationDao<Employee> employeeDao)
        {
            this._employeeDao = employeeDao;
        }

        public List<Employee> FetchAllRecords()
        {
            try
            {
                return this._employeeDao.GetAll().OrderBy(e => e.Employeeid).ToList<Employee>();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Employee FetchRecord(int id)
        {
            try
            {
                return this._employeeDao.Get(id);                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int InsertRecord(Employee data)
        {
            try
            {
                if (data != null)
                {
                    return this._employeeDao.Add(data);
                }
                else
                {
                    throw new NullReferenceException("no data was passed");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ModifyRecord(Employee data)
        {
            throw new NotImplementedException();
        }

        public int RemoveRecord(int id)
        {
            try
            {
                return this._employeeDao.Delete(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
