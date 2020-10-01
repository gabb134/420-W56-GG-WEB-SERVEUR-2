using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercices4_6.Models;

namespace Exercices4_6.Controllers
{
    public class Serie06Controller : Controller
    {
        // GET: Serie06
   
        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee2 emp)
        {
            if (ModelState.IsValid)
            {

                //   return View("Index", model);
                return View("Informationstransmises", emp);
            }
            return View(emp);
        }
        [HttpPost]
        public ActionResult Informationstransmises(Employee2 emp)
        {
            return View(emp);
        }
    }
}