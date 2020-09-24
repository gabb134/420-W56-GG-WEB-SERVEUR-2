using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercices1_3.Controllers
{
    public class Serie01Controller : Controller
    {
      public ActionResult CalculatriceV1(string tbNombre1, string tbNombre2, string ddlOperateur)
      {

         int intResultat = 0;
         string strOperateur = ddlOperateur;

         int intNombre1;
         int intNombre2;
         bool etat1 = int.TryParse(tbNombre1, out intNombre1);
         bool etat2 = int.TryParse(tbNombre2, out intNombre2);
         // Calcul
         switch (strOperateur)
         {
            case "+": intResultat = intNombre1 + intNombre2; break;
            case "-": intResultat = intNombre1 - intNombre2; break;
            case "x": intResultat = intNombre1 * intNombre2; break;
            case "/": intResultat = intNombre1 / intNombre2; break;
            default: strOperateur = null; break;
         }
         //Passage des valeurs de nombre1 et nombre2 à la vue en utilisant ViewBag
         if (etat1)
            @ViewBag.nombre1 = tbNombre1;
         if (etat2)
            @ViewBag.nombre2 = tbNombre2;

         ViewBag.resultat = "En attente...";
         if (etat1 && etat2 && strOperateur != null)
            ViewBag.resultat = intResultat.ToString();
         return View();
      }
      public ActionResult CalculatriceV2(string tbNombre1, string tbNombre2, string ddlOperateur)
      {

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

         ViewBag.resultat = "En attente...";
         if (etat1 && etat2 && strOperateur != null)
            ViewBag.resultat = intResultat;

         return View();
      }

   }
}
