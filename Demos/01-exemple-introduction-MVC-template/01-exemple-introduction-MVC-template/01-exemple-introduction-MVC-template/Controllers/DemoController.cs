using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_exemple_introduction_MVC_template.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
         public String Time()
         {
            return @"L'heure actuelle retournée par la méthode d'action Time() est: " + DateTime.Now;
         }

         [ActionName("GetTime")]
         public String TimeUsingActionName()
         {
            return @"L'heure actuelle retournée par la méthode d'action TimeUsingActionName() est: " + DateTime.Now;
         }

         /* exemple montrant l'utilisation de l'attribut NoAction*/
         [ActionName("GetTime1")]
         public String TimeUsingNonActionMethod()
         {
            return GetTimeMethod();
         }
         [NonAction]
         public String GetTimeMethod()
         {
            return @"L'heure actuelle retournée par une méthode utilsant l'attribut NonAction est : " + DateTime.Now;
         }

         /* exemple montrant l'utilisation de l'attribut ActionVerbs (HttpGet et HttpPost)*/
         [HttpGet]
         public ActionResult DemoHttpGet()
         {
            ViewBag.message = "Ce message est envoyé par la méthode  DemoHttpGet avec l'attribut HttpGet";
            return View();
         }
         [HttpPost]
         public ActionResult DemoHttpPost()
         {
            ViewBag.message = "Ce message est envoyé par la méthode  DemoHttpPost avec l'attribut HttpPost";
            return View();
         }
   }
}