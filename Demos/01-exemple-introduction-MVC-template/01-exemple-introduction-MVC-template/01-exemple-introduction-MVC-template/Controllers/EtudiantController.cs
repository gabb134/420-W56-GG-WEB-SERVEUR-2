using _01_exemple_introduction_MVC_template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_exemple_introduction_MVC_template.Controllers
{
    public class EtudiantController : Controller
    {
        Etudiant etudiant = new Etudiant ( 1,  "Tramblay",  29 );
        static List<Etudiant> etudiants = new List<Etudiant>() 
        {
            new Etudiant(){ Id=1, Nom="Bill", Age = 39},
            new Etudiant(){ Id=2, Nom="Steve", Age = 29},
            new Etudiant(){ Id=3, Nom="Ram", Age = 28},
            new Etudiant(){ Id=4, Nom="Moin", Age = 20}
        };
        public ActionResult Index()
        {            
            return View(etudiants);
        }
         //utilisation de ViewData pour transferer les données de l'action vers la vue
         public ActionResult DetailsViewData()
         {
            Etudiant etudiant = new Etudiant { Id = 1, Nom = "Tramblay", Age = 29 };
            ViewData["Id"] = etudiant.Id;
            ViewData["Nom"] = etudiant.Nom;
            ViewData["Age"] = etudiant.Age;
            return View();
         }
         //utilisation de ViewBag pour transferer les données de l'action vers la vue
         public ActionResult DetailsViewBag()
         {
            Etudiant etudiant = new Etudiant { Id = 1, Nom = "Tramblay", Age = 29 };
            ViewBag.etudiant = etudiant;
            return View();
         }
         //utilisation d'une vue fortement typée pour transferer les données de l'action vers la vue
         public ActionResult Details()
         {
            Etudiant etudiant = new Etudiant { Id = 1, Nom = "Tramblay", Age = 29 };
            return View(etudiant);
         }
   }
}