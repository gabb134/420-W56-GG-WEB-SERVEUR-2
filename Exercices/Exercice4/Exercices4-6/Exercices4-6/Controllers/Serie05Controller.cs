using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercices4_6.Models;

namespace Exercices4_6.Controllers
{
    public class Serie05Controller : Controller
    {
        // GET: Serie05
        [HttpGet]
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            if (ModelState.IsValid)
            {

                //   return View("Index", model);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}