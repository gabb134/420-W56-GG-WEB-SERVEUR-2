using ProduitApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProduitApp.Controllers
{
    public class ProduitServiceController : ApiController
    {
        IProduitService produitDataAccess { get; set; }
        // GET: Produit

        public ProduitServiceController()
        {
            //produitDataAccess = new ProduitServiceImp();
            produitDataAccess = new ProduitServiceImp();
        }

        // GET: api/ProduitService
        public IHttpActionResult Get()
        {
            IList<Produit> produits = produitDataAccess.GetAllProduits().ToList();
            if(produits.Count == 0)
            {
                return Content(HttpStatusCode.NotFound, "Produit non trouvé");
            }
            return Ok(produits);
        }
            
            
            /*public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/

        // GET: api/ProduitService/5
        public IHttpActionResult Get(int id) 
        {
            Produit produit = null;
            produit = produitDataAccess.GetProduitData(id);
            if(produit==null)
                return Content(HttpStatusCode.NotFound, "Produit non trouvé");
            return Ok(produit);
        }
            
            /*public string Get(int id)
        {
            return "value";
        }*/

        // POST: api/ProduitService
        public IHttpActionResult Post([FromBody]Produit produit) //Ajout
        {
            if (!ModelState.IsValid || produit == null)
                return BadRequest("Données invalides.");
            return Ok(produitDataAccess.AddProduit(produit));
        }
            /*public void Post([FromBody]string value)
        {
        }*/

        // PUT: api/ProduitService/5
        public IHttpActionResult put(int id,[FromBody]Produit produit) //Modification
        {
            if (!ModelState.IsValid)
                return BadRequest("Modèle invalide.");
            Produit prod = null;
            prod = produitDataAccess.GetProduitData(id);
            if (prod != null)
                produitDataAccess.UpdateProduit(produit);
            else
                return NotFound();
            return Ok();
        }
        
    
    /*public void Put(int id, [FromBody]string value)
        {
        }*/

        // DELETE: api/ProduitService/5
        public IHttpActionResult Delete(int id) // Suppression
        {
            if (id <= 0)
                return BadRequest("L'id du produit n'est pas valide.");
            Produit prod = null;
            prod = produitDataAccess.GetProduitData(id);
            if (prod != null)
                produitDataAccess.DeleteProduit(id);
            else
                return NotFound();
            return Ok();
        }
        /*public void Delete(int id)
        {
        }*/
    }
}
