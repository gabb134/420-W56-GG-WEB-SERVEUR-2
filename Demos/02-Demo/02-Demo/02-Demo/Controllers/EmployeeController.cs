using _02_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Emplyee
        List<Employee> employees = new List<Employee> ();
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
         [ValidateAntiForgeryToken]
         public ActionResult Create(Employee employee)
         {
            if (ModelState.IsValid)
            {
               RedirectToAction("Index");
            }

            return View();
         }
   }
}