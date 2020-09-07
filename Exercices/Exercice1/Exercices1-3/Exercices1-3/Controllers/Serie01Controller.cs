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

            switch (ddlOperateur)
            {
                case "+":
                    ViewBag.Resultat = int.Parse(tbNombre1) + int.Parse(tbNombre2);
                    break;
                case "-":
                    ViewBag.Resultat = int.Parse(tbNombre1) - int.Parse(tbNombre2);
                    break;
                case "x":
                    ViewBag.Resultat = int.Parse(tbNombre1) * int.Parse(tbNombre2);
                    break;
                case "/":
                    ViewBag.Resultat = int.Parse(tbNombre1) / int.Parse(tbNombre2);
                    break;
            }

            return View();

        }

        public ActionResult CalculatriceV2(string tbNombre1, string tbNombre2, string ddlOperateur)
        {
            //ajoutez votre code ici pour effectuer les opérations de la calculatrice.

            switch (ddlOperateur)
            {
                case "+":
                    ViewBag.Resultat2 = int.Parse(tbNombre1) + int.Parse(tbNombre2);
                    break;
                case "-":
                    ViewBag.Resultat2 = int.Parse(tbNombre1) - int.Parse(tbNombre2);
                    break;
                case "x":
                    ViewBag.Resultat2 = int.Parse(tbNombre1) * int.Parse(tbNombre2);
                    break;
                case "/":
                    ViewBag.Resultat2 = int.Parse(tbNombre1) / int.Parse(tbNombre2);
                    break;
            }

            return View();

        }
    }
}