using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01_exemple_introduction_MVC_template.Models
{
   public class Etudiant
   {
      public int Id { get; set; }
      public string Nom { get; set; }
      public int Age { get; set; }
      public Etudiant() { }
      public Etudiant(int Id, string Nom, int Age) { this.Id = Id; this.Nom = Nom; this.Age = Age; }
   }
}