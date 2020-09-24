using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _04_Demo_Validation.Models
{
   public class Model2
   {
      [Required(ErrorMessage = "Absent !")]
      public string MotPassePrecedent { get; set; }
      [Required(ErrorMessage = "Absent !")]
      public string NouveauMotPasse1 { get; set; }
      [Required(ErrorMessage = "Absent !")]
      [Compare("NouveauMotPasse1", ErrorMessage = "Deux nouveaux mots de passe ne concordent pas !")]
      public string NouveauMotPasse2 { get; set; }
   }
}