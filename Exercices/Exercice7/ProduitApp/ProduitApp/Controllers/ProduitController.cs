using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProduitApp.Service;

namespace ProduitApp.Controllers
{
    public class ProduitController : Controller
    {
        IProduitService produitDataAccess { get; set; }
        // GET: Produit

        public ProduitController()
        {
            //produitDataAccess = new ProduitServiceImp();
            produitDataAccess = new ProduitServiceImp();
        }
        public ActionResult Index()
        {
            IEnumerable<Produit> produits = produitDataAccess.GetAllProduits();
            return View(produits.ToList());
        }

        // GET: Produit/Details/5
        public ActionResult Details(int id)
        {
            Produit produit = produitDataAccess.GetProduitData(id);
            return View(produit);
        }

        // GET: Produit/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produit/Create
        [HttpPost]
        public ActionResult Create(Produit produit)
        {

            // TODO: Add insert logic here
            if (ModelState.IsValid)
            {
                produitDataAccess.AddProduit(produit);
                return RedirectToAction("Index");
            }
            return View(produit);

        }

        // GET: Produit/Edit/5
        public ActionResult Edit(int id)
        {

            Produit produit = produitDataAccess.GetProduitData(id);
            return View(produit);
        }

        // POST: Produit/Edit/5
        [HttpPost]
        public ActionResult Edit(Produit produit)
        {
         
          
                if (ModelState.IsValid)
                {
                    produitDataAccess.UpdateProduit(produit);
                    return RedirectToAction("Index");
                }
                return View(produit);
               
           
        }

        // GET: Produit/Delete/5
        public ActionResult Delete(int id)
        {
            Produit produit = produitDataAccess.GetProduitData(id);
            return View(produit);
        }

        // POST: Produit/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Produit produit)
        {
            try
            {
                // TODO: Add delete logic here
                produitDataAccess.DeleteProduit(id);
               // for(int 1 =0; i< produitDataAccess.) faire en sorte que les id change pour les produits qui restent
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
