using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _04_Demo_Validation.Models
{
   public class Model1
   {
      [Required(ErrorMessage = "Nom absent !")]
      public string Nom { get; set; }
      [Required(ErrorMessage = "Prénom absent !")]
      public string Prenom { get; set; }
   }
}
