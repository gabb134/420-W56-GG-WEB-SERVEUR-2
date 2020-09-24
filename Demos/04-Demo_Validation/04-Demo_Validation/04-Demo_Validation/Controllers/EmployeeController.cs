using _04_Demo_Validation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04_Demo_Validation.Controllers
{
    public class EmployeeController : Controller
    {
         // GET: Emplyee
         static List<Employee> employees = new List<Employee>();
         public ActionResult Index()
         {
            return View(employees);
         }
         [HttpGet]
         public ActionResult Create()
         {
            return View();
         }

         [HttpPost]         
         public ActionResult Create(Employee employee)
         {
            if (ModelState.IsValid)
            {
               employees.Add(employee);
               return RedirectToAction("Index");
            }

            return View();
         }
   }
}