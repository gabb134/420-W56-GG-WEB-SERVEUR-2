using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProduitApp.Service
{
    public class Produit
    {
        // [Required(ErrorMessage ="Ce champ est obligatoire!")]
        public int IdProduit { get; set; } = 0;
        [Required(ErrorMessage = "Ce champ est obligatoire!")]
        [Range(50, 1000000, ErrorMessage = "Plage !")]
        public double dblPrix { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire!")]
        [RegularExpression(@"^[A-Za-z]{5,25}$", ErrorMessage = "La désignation doit être une chaine de caractères dont la longueur est dans l’intervalle [5, 25]!")]
        public string strDesignation { get; set; }

    }
}