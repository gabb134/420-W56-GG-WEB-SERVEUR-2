using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _04_Demo_Validation.Models
{
   public class Model4
   {
      [Display(Name = "Tel")]
      [DataType(DataType.PhoneNumber)]
      [RegularExpression(@"^\(\d{3}\)\s\d{3}-\d{4}$", ErrorMessage = "Le numéro de téléphone ne respecte pas le bon format!")]
      public string NoTelephone { get; set; }
   }
}