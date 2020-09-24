using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _04_Demo_Validation.Models
{
      public class Model5
      {
         [Required(ErrorMessage = "Code employé absent !")]
         [CustomRangeEmplyee(ErrorMessage = "Code employé invalide ou hors intervalle !")]
         public int CodeEmploye { get; set; }
      }

      internal class CustomRangeEmplyeeAttribute : ValidationAttribute
      {
         public override bool IsValid(object value)
         {
            int code = Convert.ToInt16(value);
            return ((code >= 1000 && code<=2000) || (code >= 3000 && code <= 4000));
         }
      }
}