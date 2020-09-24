using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoEmployee.Models;

namespace DemoEmployee.Metier
{
   
   public class EmployeeDataAccessImp1 : IEmployeeDataAccess
   {
      static int count = 0;
      static private Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
      public Employee AddEmployee(Employee emp)
      {
         count++;
         emp.Id = count;
         employees[emp.Id] = emp;
         return emp;
      }

      public void DeleteEmployee(int ID)
      {
         employees.Remove(ID);
      }
          
      public IEnumerable<Employee> GetAllEmployees()
      {
         return employees.Values; 
      }

      public Employee GetEmployeeData(int Id)
      {
         Employee emp;
         employees.TryGetValue(Id, out emp);
         return emp;
      }

      public void UpdateEmployee(Employee emp)
      {
         employees[emp.Id] = emp;
      }
   }
}