using _04_Demo_Validation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04_Demo_Validation.Controllers
{
    public class RequiredValidationController : Controller
    {
        // GET: RequiredValidationServeur
       
         [HttpGet]
         public ActionResult Serveur()
         {
            return View();
         }

         [HttpPost]
         public ActionResult Serveur(Model1 model)
         {
            if (ModelState.IsValid)
            {               
               return View("ValidationConfirmation", model);
            }

            return View();
         }

         [HttpGet]
         public ActionResult Client()
         {
            return View();
         }

         [HttpPost]
         public ActionResult Client(Model1 model)
         {
            if (ModelState.IsValid)
            {
               return View("ValidationConfirmation", model);
            }

            return View();
         }
         public ActionResult Summary()
         {
            return View();
         }

         [HttpPost]
         public ActionResult Summary(Model1 model)
         {
            if (ModelState.IsValid)
            {
               return View("ValidationConfirmation", model);
            }

            return View();
         }
   }
}