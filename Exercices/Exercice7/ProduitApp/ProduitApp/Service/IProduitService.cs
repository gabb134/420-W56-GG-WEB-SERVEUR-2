using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduitApp.Service
{
    interface IProduitService
    {
        IEnumerable<Produit> GetAllProduits();
        Produit GetProduitData(int IdProd);
        Produit AddProduit(Produit prod);
        void UpdateProduit(Produit prod);
        void DeleteProduit(int IdProd);

    }
}
