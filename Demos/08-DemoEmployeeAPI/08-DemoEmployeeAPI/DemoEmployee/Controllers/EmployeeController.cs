using DemoEmployee.Metier;
using DemoEmployee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoEmployee.Controllers
{
    public class EmployeeController : Controller
    {
         IEmployeeDataAccess employeeDataAccess { get; set; }
         public EmployeeController()
         {
            employeeDataAccess = new EmployeeDataAccessImp1();
         }
        // GET: Employee
        public ActionResult Index()
        {
            IEnumerable<Employee> employees = employeeDataAccess.GetAllEmployees();
            return View(employees.ToList());
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            Employee employee = employeeDataAccess.GetEmployeeData(id);
            return View(employee);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeDataAccess.AddEmployee(employee);
                return RedirectToAction("Index");
            }
            
                return View(employee);
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {            
            Employee employee = employeeDataAccess.GetEmployeeData(id);
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee employee)
        {
            if(id != employee.Id)
            { 
               return HttpNotFound();
            }
            if (ModelState.IsValid)
            {
                employeeDataAccess.UpdateEmployee(employee);
                return RedirectToAction("Index");
            }
            
                return View(employee);
            
            
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            Employee employee = employeeDataAccess.GetEmployeeData(id);
            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Employee employee)
        {
            try
            {
                // TODO: Add delete logic here
                employeeDataAccess.DeleteEmployee(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
