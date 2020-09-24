using System;
using System.ComponentModel.DataAnnotations;

namespace _02_Demo.Models
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