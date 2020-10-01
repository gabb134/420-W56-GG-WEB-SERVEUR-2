using DemoEmployee.Metier;
using DemoEmployee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoEmployee.Controllers
{
    public class EmployeeServiceController : ApiController
    {
        IEmployeeDataAccess employeeDataAccess { get; set; }
         public EmployeeServiceController()
         {
            employeeDataAccess = new EmployeeDataAccessImp1();
         }
        // GET: api/EmployeeService 
        public IHttpActionResult Get()
        {
            IList <Employee> employees = employeeDataAccess.GetAllEmployees().ToList();
            if(employees.Count == 0)
            {
               return Content(HttpStatusCode.NotFound, "Employees not found");
            }
            return Ok(employees);
        }

        // GET: api/EmployeeService/5
        public IHttpActionResult Get(int id)
        {
            Employee employee = null;
            employee=employeeDataAccess.GetEmployeeData(id);
            if (employee == null)
               return Content(HttpStatusCode.NotFound, "Employee not found");
            return Ok(employee);
        }

        // POST: api/EmployeeService
        public IHttpActionResult Post([FromBody]Employee employee)
        {
            if (!ModelState.IsValid || employee == null)
               return BadRequest("Invalid data.");
            return Ok(employeeDataAccess.AddEmployee(employee));
        }

        // PUT: api/EmployeeService/5
        public IHttpActionResult Put(int id, [FromBody]Employee employee)
        {
            if (!ModelState.IsValid)
               return BadRequest("Not a valid model.");
            Employee emp = null;
            emp = employeeDataAccess.GetEmployeeData(id);
            if (emp !=null)
               employeeDataAccess.UpdateEmployee(employee);
            else 
               return NotFound();
            return Ok();
        }

        // DELETE: api/EmployeeService/5
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
            return BadRequest("Not a valid employee id");
            Employee emp = null;
            emp = employeeDataAccess.GetEmployeeData(id);
            if (emp !=null)
               employeeDataAccess.DeleteEmployee(id);
            else 
               return NotFound();
            return Ok();
        }
    }
}
