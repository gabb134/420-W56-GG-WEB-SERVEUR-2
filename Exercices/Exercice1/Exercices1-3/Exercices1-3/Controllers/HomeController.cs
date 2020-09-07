using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercices1_3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //1. Ajoutez l’action suivante au contrôleur Home qui retourne une chaine de caractère
        //(string) "Bienvenue dans le laboratoire 1 de programmation serveur II – 420-W56" :
        public string Bienvenue()
        {
            return "Bienvenue dans le laboratoire 1 de programmation serveur II - 420-W56";
        }
        //3. Ajoutez l’action suivante au contrôleur Home qui retourne des données Json :
        public JsonResult ActionJson()
        {
            var list = new[]
                    {
         new { Id=1, Nom="Bill", Age = 39},
         new { Id=2, Nom="Steve", Age = 29},
         new { Id=3, Nom="Ram", Age = 28},
         new { Id=4, Nom="Moin", Age = 20}
         };
                    return Json(list, JsonRequestBehavior.AllowGet);
        }

        //5. Ajoutez l’action suivante au contrôleur Home :
        public ActionResult BienvenueAvecVue()
        {
            return View();
        }

        //9. Ajoutez une action ActionAvecId comme le montre la figure suivante :
        public ActionResult ActionAvecId(string id)
        {
            if (id == "1")
                return View("BienvenueAvecVue");
            else
                return View("Index");
        }


    }
}