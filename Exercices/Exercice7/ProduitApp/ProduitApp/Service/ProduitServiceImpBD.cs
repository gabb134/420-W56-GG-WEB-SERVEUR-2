using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProduitApp.Service
{
    public class ProduitServiceImpBD : IProduitService
    {
        string maChaineDeConnexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProduitAppBD;Integrated Security=True;";
        public Produit AddProduit(Produit prod)
        {

            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();


            string maRequeteSql = "INSERT INTO tbProduit(strDesignation, dblPrix) values ('"+prod.strDesignation+"',"+prod.dblPrix+")";

            SqlCommand maCommande = new SqlCommand(maRequeteSql, maConnexion);

            maCommande.ExecuteNonQuery();
            maConnexion.Close();


            return prod;
        }

        public void DeleteProduit(int IdProd)
        {
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();


            string maRequeteSql = "DELETE FROM tbProduit WHERE IdProduit = " + IdProd;

            SqlCommand maCommande = new SqlCommand(maRequeteSql, maConnexion);

            maCommande.ExecuteNonQuery();
            maConnexion.Close();
        }

        public IEnumerable<Produit> GetAllProduits()
        {
            List<Produit> lstProduits = new List<Produit>();

            using (SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion))
            {
                string maRequeteSql = "SELECT * FROM tbProduit";

                SqlCommand maCommande = new SqlCommand(maRequeteSql, maConnexion);
                maConnexion.Open();

                SqlDataReader lecture = maCommande.ExecuteReader();
                while (lecture.Read())
                {
                    Produit produit = new Produit();
                    produit.IdProduit = Convert.ToInt32(lecture["IdProduit"]);
                    produit.strDesignation = lecture["strDesignation"].ToString();
                    produit.dblPrix = Convert.ToDouble(lecture["dblPrix"]);
                    lstProduits.Add(produit);
                }
                maConnexion.Close();
            }
       
                return lstProduits;
        }

        public Produit GetProduitData(int IdProd)
        {
            Produit produit = new Produit();
            using(SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion))
            {
                string maRequeteSql = "SELECT * FROM tbProduit WHERE IdProduit = " + IdProd;
                SqlCommand maCommande = new SqlCommand(maRequeteSql, maConnexion);
                maConnexion.Open();

                SqlDataReader lecture = maCommande.ExecuteReader();

                while (lecture.Read())
                {
                    produit.IdProduit = Convert.ToInt32(lecture["IdProduit"]);
                    produit.strDesignation = lecture["strDesignation"].ToString();
                    produit.dblPrix = Convert.ToDouble( lecture["dblPrix"]);

                }
                maConnexion.Close();

            }
            return produit;
        }

        public void UpdateProduit(Produit prod)
        {
           SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();
            

            string maRequeteSql = "Update tbProduit set strDesignation = '"+ prod.strDesignation + "', dblPrix = " + prod.dblPrix + " where IdProduit = "+ prod.IdProduit;

            SqlCommand maCommande = new SqlCommand(maRequeteSql, maConnexion);

            maCommande.ExecuteNonQuery();
            maConnexion.Close();
       
        }
    }
}