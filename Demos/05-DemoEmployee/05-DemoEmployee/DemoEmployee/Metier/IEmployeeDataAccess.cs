using DemoEmployee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEmployee.Metier
{
   interface IEmployeeDataAccess
   {
      IEnumerable<Employee> GetAllEmployees();
      Employee GetEmployeeData(int ID);
      Employee AddEmployee(Employee emp);
      void UpdateEmployee(Employee emp);
      void DeleteEmployee(int ID);
      
   }
}

