using HRMSApp.ServiceLayer.BusinessLayer.Contracts;
using HRMSApp.ServiceLayer.Container;
using HRMSApp.ServiceLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HRMSApp.ServiceLayer.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        IApplicationBO<Employee> _employeeBo;
        ILogger<EmployeesController> _logger;
        //public EmployeesController() { }
        public EmployeesController(IApplicationBO<Employee> employeeBo, ILogger<EmployeesController> logger)
        {
            this._logger = logger;
            this._employeeBo = employeeBo;
            //db = Factory.Create<IApplicationDbContext, ApplicationDbContext>();
        }
        [HttpGet]
        [Route("fetchall")]
        //http://localhost:41723/api/Employees/fetchall
        public IActionResult GetEmployees()
        {
            try
            {
                return this.Ok(this._employeeBo.FetchAllRecords());
            }
            catch (Exception ex)
            {
                //_logger.
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("add")]
        //http://localhost:41723/api/Employees/add
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            try
            {
                return Ok(this._employeeBo.InsertRecord(employee));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
