using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercices1_3.Controllers
{
    public class Serie02Controller : Controller
    {
        // GET: Serie02
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CalculatriceV3()
        {
            //Ajouter du code à cette méthode qui répond à la requête GET
            return View();
        }

        [HttpPost]
        public ActionResult CalculatriceV3(string tbNombre1, string tbNombre2, string ddlOperateur)
        {
            // Ajouter du code à cette méthode qui répond à la requête POST

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
        public ActionResult CalculatriceV4(string tbNombre1, string tbNombre2, string ddlOperateur)
        {
            //Ajouter du code à cette méthode qui répond à la requête GET
            ViewBag.nomClass = "visible";
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
                case "Mod":
                    ViewBag.Resultat = int.Parse(tbNombre1) % int.Parse(tbNombre2);
                    break;
                case "%":
                    ViewBag.Resultat = double.Parse(tbNombre1) / 100;
                    ViewBag.nomClass = "invisible";
                    
                    break;
            }
            return View();
        }

    }
}