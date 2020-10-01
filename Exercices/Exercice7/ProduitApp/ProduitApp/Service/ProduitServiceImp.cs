using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProduitApp.Service
{
    public class ProduitServiceImp : IProduitService
    {
        static int count = 0;
        static private Dictionary<int, Produit> produits = new Dictionary<int, Produit>();

        public Produit AddProduit(Produit prod)
        {
            count++;
            prod.IdProduit = count;
            produits[prod.IdProduit] = prod;

            return prod;
        }

        public void DeleteProduit(int IdProd)
        {
            produits.Remove(IdProd);
        }

        public IEnumerable<Produit> GetAllProduits()
        {
            return produits.Values;
        }

        public Produit GetProduitData(int IdProd)
        {
            Produit prod;
            produits.TryGetValue(IdProd, out prod);
            return prod;
        }

        public void UpdateProduit(Produit prod)
        {
            produits[prod.IdProduit] = prod;
        }
    }
}