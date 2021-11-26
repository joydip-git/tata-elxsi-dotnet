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
                int result = this._employeeBo.InsertRecord(employee);
                return this.Created("http://localhost:41723/api/Employees/add", new { statuscode = 201, message = $"{result} record added" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("delete/{id}")]
        //http://localhost:41723/api/Employees/delete/1
        public IActionResult Remove(Nullable<int> id)
        {
            try
            {
                if (id.HasValue)
                {
                    var res = this._employeeBo.RemoveRecord(id.Value);
                    return Ok(new { statuscode = 200, message = $"{res} record deleted" });
                }
                else
                    return BadRequest("no id found in the request");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
