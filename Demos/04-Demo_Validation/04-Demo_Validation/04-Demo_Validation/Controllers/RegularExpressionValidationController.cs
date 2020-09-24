using _04_Demo_Validation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04_Demo_Validation.Controllers
{
    public class RegularExpressionValidationController : Controller
    {
         // GET: RegularExpressionValidation
         [HttpGet]
         public ActionResult Index()
         {
            return View();
         }

         [HttpPost]
         public ActionResult Index(Model4 model)
         {
            if (ModelState.IsValid)
            {
               return View("ValidationConfirmation", model);
            }

            return View();
         }
   }
}