using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _04_Demo_Validation.Models
{
   public class Model3
   {
      [Required(ErrorMessage = "Age absent !")]
      [Range(18,120,ErrorMessage = "L'âge doit être entier et dans l'intervalle 18 à 120 !")]
      public int Age { get; set; }
   }
}