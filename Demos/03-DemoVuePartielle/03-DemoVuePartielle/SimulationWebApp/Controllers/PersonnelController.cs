using SimulationWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimulationWebApp.Controllers
{
    public class PersonnelController : Controller
    {   // GET: Personnel
        List<Personnel> ListeEnseignants = new List<Personnel>
            {   new Personnel{ Nom = "Tardif", Prénom = "David", sexe = "Masculin", Age =55, AnnéeAncienneté=29, Département= "Informatique"},
                new Personnel{ Nom = "Bérubé", Prénom = "Fréderic", sexe = "Masculin", Age =43, AnnéeAncienneté=15, Département= "Mathématique"},
                new Personnel{ Nom = "Gagnon", Prénom = "Lucie", sexe = "Féminin", Age =37, AnnéeAncienneté=10, Département= "Administration"}
            };
        List<Personnel> ListeProfessionnels = new List<Personnel>
            {   new Personnel{ Nom = "Laliberté", Prénom = "Julie", sexe = "Féminin", Age =40, AnnéeAncienneté=17, Département= ""},
                new Personnel{ Nom = "Laverdière", Prénom = "Nathalie", sexe = "Féminin", Age =35, AnnéeAncienneté=11, Département= ""},
                new Personnel{ Nom = "tremblay", Prénom = "Éric", sexe = "Masculin", Age =57, AnnéeAncienneté=30, Département= ""}
            };
        public ActionResult Enseignants()
        {            
            return View(ListeEnseignants);
        }
        public ActionResult EnseignantsVuePartielle()
        {
            return View(ListeEnseignants);
        }
        public ActionResult Professionnels()
        {
            return View(ListeProfessionnels);
        }        
    }
}