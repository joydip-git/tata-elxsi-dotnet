using EmployeeApp.UserInterface.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApp.UserInterface.Controllers
{
    public class EmployeesController : Controller
    {
        private EmployeeDao dao;
        public string Index()
        {
            return "Hello";
        }
        public ViewResult FetchEmployees()
        {
            try
            {
                dao = new EmployeeDao();
                var records = dao.GetEmployees();
                return this.View(records);
                //this.ViewBag.Val = "joydip";
                //return this.View(12);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
