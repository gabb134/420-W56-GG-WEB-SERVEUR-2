using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercices1_3.Models
{
   public class CalculatriceModel
   {
      public int intNombre1 { get; set; }
      public int intNombre2 { get; set; }
      public string ddlOperateur { get; set; }
      public string resultat { get; set; }
      public bool etatNombre2visible { get; set; }
      public double dbResultat { get; set; }
   }
}