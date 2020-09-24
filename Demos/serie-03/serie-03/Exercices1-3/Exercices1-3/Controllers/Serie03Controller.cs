using Exercices1_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercices1_3.Controllers
{
    public class Serie03Controller : Controller
    {
        
         static int ddlstate = -1;
         // GET: Serie03
         [HttpGet]
         public ActionResult Index()
         {
            List<SelectListItem> categories = new List<SelectListItem>() {
                       new SelectListItem {Text = "Sélectionnez", Value = "-1"},
                       new SelectListItem {Text = "Pairs", Value = "1"},
                       new SelectListItem {Text = "Impairs", Value = "2"},
                       new SelectListItem {Text = "Multiples de 3", Value = "3"},
                       new SelectListItem {Text = "Multiples de 5", Value = "4"}
                  };
            ViewBag.Categorie = categories;
            ViewBag.Nombre = GenerateNumber(0, 20, 2);
            ViewBag.nombreVisible = "invisible";

            return View(new ModelSerie03());
         }
         [HttpPost]
         public ActionResult Index(ModelSerie03 model)
         {
            List<SelectListItem> categories = new List<SelectListItem>() {
                       new SelectListItem {Text = "Sélectionnez", Value = "-1"},
                       new SelectListItem {Text = "Pairs", Value = "1"},
                       new SelectListItem {Text = "Impairs", Value = "2"},
                       new SelectListItem {Text = "Multiples de 3", Value = "3"},
                       new SelectListItem {Text = "Multiples de 5", Value = "4"}
                  };
            ViewBag.Categorie = categories;

            List<SelectListItem> ListeNombre;
            switch (model.Categorie)
            {
               case 1:
                  ListeNombre = GenerateNumber(0, 20, 2);
                  break;
               case 2:
                  ListeNombre = GenerateNumber(1, 20, 2);
                  break;
               case 3:
                  ListeNombre = GenerateNumber(3, 20, 3);
                  break;
               case 4:
                  ListeNombre = GenerateNumber(5, 20, 5);
                  break;
               default:
                  ListeNombre = GenerateNumber(0, 20, 2);
                  Console.WriteLine("Default case");
                  break;
            }
            ViewBag.Nombre = ListeNombre;

            if (ddlstate == -1 || ddlstate != model.Categorie)
            {
               model.Nombre = -1;
               ViewBag.nombreVisible = "invisible";
            }
            else
            {
               ViewBag.nombreVisible = "visible";
            }
            if (model.Nombre == -1)
               ViewBag.nombreVisible = "invisible";
            ddlstate = model.Categorie;
            return View(model);
         }


         private static List<SelectListItem> GenerateNumber(int debut, int fin, int Pas)
         {
            List<SelectListItem> list = new List<SelectListItem>() { new SelectListItem { Text = "Sélectionnez", Value = "-1" } };

            int i = debut;
            while (i <= fin)
            {
               string item = (i).ToString();
               list.Add(new SelectListItem { Text = item, Value = item });
               i = i + Pas;
            }
            return list;
         }
    }
}