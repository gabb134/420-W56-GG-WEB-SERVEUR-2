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
   public class EmployeeService2Controller : ApiController
   {
      IEmployeeDataAccess employeeDataAccess { get; set; }
      public EmployeeService2Controller()
      {
         employeeDataAccess = new EmployeeDataAccessImp1();
      }
      // GET: api/EmployeeService2 
      public IEnumerable<Employee> Get()
      {
         return employeeDataAccess.GetAllEmployees().ToList();
      }

      // GET: api/EmployeeService2/5
      public Employee Get(int id)
      {
         return employeeDataAccess.GetEmployeeData(id);
      }

      // POST: api/EmployeeService2
      public void Post([FromBody]Employee employee)
      {
         employeeDataAccess.AddEmployee(employee);
      }

      // PUT: api/EmployeeService2/5
      public void Put(int id, [FromBody]Employee employee)
      {
         employeeDataAccess.UpdateEmployee(employee);
      }

      // DELETE: api/EmployeeService2/5
      public void Delete(int id)
      {
         employeeDataAccess.DeleteEmployee(id);
      }
   }
}
