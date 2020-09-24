using System;
using System.ComponentModel.DataAnnotations;

namespace _04_Demo_Validation.Models
{
   internal class CustomHireDateAttribute : ValidationAttribute
   {
      public override bool IsValid(object value)
      {
         DateTime dateTime = Convert.ToDateTime(value);
         return dateTime <= DateTime.Now;
      }
   }
}