
using Exercices1_3.Models;
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
            ViewBag.resultat = "En attente...";
            return View();
         }
         [HttpPost]
         public ActionResult CalculatriceV3(string tbNombre1, string tbNombre2, string ddlOperateur)
         {
            ViewBag.resultat = "En attente...";
            int intResultat = 0;
            string strOperateur = ddlOperateur;

            int intNombre1;
            int intNombre2;
            bool etat1 = int.TryParse(tbNombre1, out intNombre1);
            bool etat2 = int.TryParse(tbNombre2, out intNombre2);
            //Calcul
            switch (strOperateur)
            {
               case "+": intResultat = intNombre1 + intNombre2; break;
               case "-": intResultat = intNombre1 - intNombre2; break;
               case "x": intResultat = intNombre1 * intNombre2; break;
               case "/": intResultat = intNombre1 / intNombre2; break;
               default: strOperateur = null; break;
            }

            if (etat1 && etat2 && strOperateur != null)
               ViewBag.resultat = intResultat;

            return View();
         }

         [HttpGet]
         public ActionResult CalculatriceV4()
         {
            ViewBag.etatNombre2visible = "true";
            ViewBag.resultat = "En attente...";
            return View();
         }
         [HttpPost]
         public ActionResult CalculatriceV4(string tbNombre1, string tbNombre2, string ddlOperateur)
         {
            ViewBag.resultat = "En attente...";
            int intResultat = 0;
            double resultat = 0;
            string strOperateur = ddlOperateur;
            int intNombre1;
            int intNombre2;
            bool etat1 = int.TryParse(tbNombre1, out intNombre1);
            bool etat2 = int.TryParse(tbNombre2, out intNombre2);
            ViewBag.etatNombre2visible = "true";
            // Calcul
            switch (strOperateur)
            {
               case "+": intResultat = intNombre1 + intNombre2; break;
               case "-": intResultat = intNombre1 - intNombre2; break;
               case "x": intResultat = intNombre1 * intNombre2; break;
               case "/": if (etat1 && etat2 && strOperateur != null) intResultat = intNombre1 / intNombre2; break;
               case "Mod": if (etat1 && etat2 && strOperateur != null) intResultat = intNombre1 % intNombre2; break;
               case "%":
                  ViewBag.etatNombre2visible = "false";
                  if (etat1) { resultat = intNombre1 * 0.01; tbNombre2 = null; etat2 = false; ViewBag.resultat = resultat.ToString("0.00"); }
                  break;
               default: strOperateur = null; break;
            }
            if (etat1 && etat2 && strOperateur != null)
               ViewBag.resultat = intResultat;

            return View();
         }
      [HttpGet]
      public ActionResult CalculatriceV5()
      {
         CalculatriceModel calculatriceModel = new CalculatriceModel();
         calculatriceModel.etatNombre2visible = true;
         calculatriceModel.resultat = "En attente...";
         return View(calculatriceModel);
      }
      [HttpPost]
      public ActionResult CalculatriceV5(CalculatriceModel calculatriceModel)
      {
         calculatriceModel.resultat = "En attente...";
         int intResultat = 0;
         double resultat = 0;
         string strOperateur = calculatriceModel.ddlOperateur;
         //int intNombre1;
         //int intNombre2;
         //bool etat1 = int.TryParse(tbNombre1, out intNombre1);
         //bool etat2 = int.TryParse(tbNombre2, out intNombre2);
         calculatriceModel.etatNombre2visible = true;
         // Calcul
         switch (strOperateur)
         {
            case "+": intResultat = calculatriceModel.intNombre1 + calculatriceModel.intNombre2; break;
            case "-": intResultat = calculatriceModel.intNombre1 - calculatriceModel.intNombre2; break;
            case "x": intResultat = calculatriceModel.intNombre1 * calculatriceModel.intNombre2; break;
            case "/": if (calculatriceModel.intNombre2!=0 && strOperateur != null) intResultat = calculatriceModel.intNombre1 / calculatriceModel.intNombre2; break;
            case "Mod": if (calculatriceModel.intNombre2!=0 && strOperateur != null) intResultat = calculatriceModel.intNombre1 % calculatriceModel.intNombre2; break;
            case "%":
               calculatriceModel.etatNombre2visible = false;
               if (true) { calculatriceModel.dbResultat = calculatriceModel.intNombre1 * 0.01; calculatriceModel.intNombre2 = 0; calculatriceModel.resultat = calculatriceModel.dbResultat.ToString("0.00"); }
               break;
            default: strOperateur = null; break;
         }
         if (strOperateur != "%" )
            calculatriceModel.resultat = intResultat.ToString();
        

         return View(calculatriceModel);
      }
   }
}