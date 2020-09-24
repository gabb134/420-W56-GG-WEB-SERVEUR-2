using _02_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_Demo.Controllers
{
    public class AutoController : Controller
    {
         List<Auto> listAutos = new List<Auto>
         { new Auto() {id =1, Nom ="amgB", Couleur="Blanc", Marque = "Mercedes", Modèle ="AMG"}, new Auto() {id =2, Nom ="amgN", Couleur="Noir", Marque = "Mercedes", Modèle ="AMG" },
            new Auto() {id =3, Nom ="amgG", Couleur="Gris", Marque = "Mercedes", Modèle ="AMG" },new Auto() {id =4, Nom ="amgR", Couleur="Rouge", Marque = "Mercedes", Modèle ="AMG" },
            new Auto() {id =5, Nom ="fitB", Couleur="Blanc", Marque = "Honda", Modèle ="fit"}, new Auto() {id =6, Nom ="fitN", Couleur="Noir", Marque = "Honda", Modèle ="fit" },
            new Auto() {id =7, Nom ="fitG", Couleur="Gris", Marque = "Honda", Modèle ="fit" },new Auto() {id =8, Nom ="fitR", Couleur="Rouge", Marque = "Honda", Modèle ="fit" },
            new Auto() {id =9, Nom ="m3B", Couleur="Blanc", Marque = "Mazda", Modèle ="3"}, new Auto() {id =10, Nom ="m3N", Couleur="Noir", Marque = "Mazda", Modèle ="3" },
            new Auto() {id =11, Nom ="m3G", Couleur="Gris", Marque = "Mazda", Modèle ="3"},new Auto() {id =12, Nom ="m3R", Couleur="Rouge", Marque = "Mazda", Modèle ="3" },
            new Auto() {id =13, Nom ="mustangB", Couleur="Blanc", Marque = "Ford", Modèle ="Mustang GT"}, new Auto() {id =14, Nom ="mustangN", Couleur="Noir", Marque = "Ford", Modèle ="Mustang GT" },
            new Auto() {id =15, Nom ="mustangG", Couleur="Gris" , Marque = "Ford", Modèle ="Mustang GT"},new Auto() {id =16, Nom ="mustangR", Couleur="Rouge", Marque = "Ford", Modèle ="Mustang GT" },
            new Auto() {id =17, Nom ="sparkB", Couleur="Blanc", Marque = "Chevrolet", Modèle ="Spark"}, new Auto() {id =18, Nom ="sparkN", Couleur="Noir", Marque = "Chevrolet", Modèle ="Spark" },
            new Auto() {id =19, Nom ="sparkG", Couleur="Gris", Marque = "Chevrolet", Modèle ="Spark" },new Auto() {id =18, Nom ="sparkR", Couleur="Rouge", Marque = "Chevrolet", Modèle ="Spark" },
         };

      // GET: Auto
         public ActionResult Index()
         {
            return View(listAutos);
         }
         [HttpPost]
         public ActionResult Index(string ddlModele, string ddlCouleur)
         {
            return View(listAutos);
         }
         public ActionResult Details(int id)
         {
            Auto auto = listAutos.Where(a => a.id==id).FirstOrDefault();
            return View(auto);
         }

   }
}