using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercices1_3.Models;

namespace Exercices1_3.Controllers
{
    public class Serie03Controller : Controller
    {
        // GET: Serie03


        [HttpGet]
        public ActionResult Index()
        {
            ModelSerie03 model = new ModelSerie03();
            

            List<SelectListItem> listeCategorie = new List<SelectListItem>() { 
            new SelectListItem { Text = "Sélectionnez", Value = "-1"},
           new SelectListItem {Text = "Pairs", Value = "2"},
           new SelectListItem { Text = "Impairs", Value = "3"},
           new SelectListItem { Text = "Multiples de 3", Value = "4"},
           new SelectListItem {Text = "Multiples de 5", Value = "5" }};


            ViewBag.categories = listeCategorie;
            




            //Ajoutez du code à cette méthode qui répond à la requête GET
            return View(new ModelSerie03());
        }
        [HttpPost]
        public ActionResult Index(ModelSerie03 model)
        {
            // Ajoutez du code à cette méthode qui répond à la requête POST

            

            List<SelectListItem> listeCategorie = new List<SelectListItem>() {
            new SelectListItem { Text = "Sélectionnez", Value = "-1"},
           new SelectListItem {Text = "Pairs", Value = "2"},
           new SelectListItem { Text = "Impairs", Value = "3"},
           new SelectListItem { Text = "Multiples de 3", Value = "4"},
           new SelectListItem {Text = "Multiples de 5", Value = "5" }};

            
           

            return View();
        }
        private static List<SelectListItem> GenerateNumber(int debut, int fin, int pas)
        {
            return GenerateNumber(0, 20, 2); // 0 a 20 avec des bons de 2 (nombres pairs..)
        }
    }
}