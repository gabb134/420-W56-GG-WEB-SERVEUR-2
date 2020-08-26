using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercices1_3.Controllers
{
    public class Serie01Controller : Controller
    {
        // GET: Serie01
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalculatriceV1(string tbNombre1, string tbNombre2, string ddlOperateur)
        {
            //ajoutez votre code ici pour effectuer les opérations de la calculatrice.
            return View();

        }
    }
}