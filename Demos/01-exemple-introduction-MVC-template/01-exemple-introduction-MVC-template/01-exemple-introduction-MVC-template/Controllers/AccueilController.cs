using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_exemple_introduction_MVC_template.Controllers
{
    public class AccueilController : Controller
    {
        // GET: Accueil
        public ActionResult Index()
        {
            return View();
        }
         // Méthode d'action qui retourne une vue utilisant la syntaxe Razor
         public ActionResult DemoRazor()
         {
            return View();
         }
         // Méthode d'action qui retourne une vue utilisant  des controles HTML et des HTML Helpers
         public ActionResult DemoHtmlHelper()
         {
            return View();
         }
         //Méthode d'action avec parametre 
         public string DemoParametres(string id)
         {
            return "La valeur de l'id est : " + id;         
         }
         //Méthode d'action avec deux parametres 
         public string DemoParametres2(string id, string id2)
         {
            return "La valeur de l'id est : " + id + "     La valeur de l'id2 est : " + id2;
         }
   }
}