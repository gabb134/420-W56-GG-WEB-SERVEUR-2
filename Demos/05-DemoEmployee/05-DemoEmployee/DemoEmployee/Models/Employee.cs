using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoEmployee.Models
{
   public class Employee
   {
      public int Id { get; set; }
      [Required]
      public string FirstName { get; set; }
      [Required]
      public string LastName { get; set; }
      [Required]
      public string Gender { get; set; }
      [Required]
      public string Department { get; set; }
      [Required]
      public string City { get; set; }
   }
}
