using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Exercices4_6.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Erreur !")]
        [Range(30000,50000,ErrorMessage ="Erreur range!")]
        [RegularExpression(@"^\d{5,6}$", ErrorMessage = "La valeur n'est pas valide pour tbNoEmploye")]
        public int noEmploye { get; set; }

        [Required(ErrorMessage = "Erreur !")]
        public string ddlDepartement { get; set; }


        [Required(ErrorMessage = "Erreur !")]
        [RegularExpression(@"^\d{3}\s\d{3}", ErrorMessage = "La valeur n'est pas valide pour NAS")]
        public string nas { get; set; }

        [Required(ErrorMessage = "Erreur!")]
        [DataType(DataType.Date, ErrorMessage = "Erreur!")]
        [CustomDateDimanche(ErrorMessage ="La date doit être un dimanche")]
        [Range(typeof(DateTime),"2011/01/02", "2020/08/31", ErrorMessage = "Erreur!")]

        public DateTime dateSemaine { get; set; }

        //^\d{3}\s\d{3}$
        internal class CustomDateDimancheAttribute : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                return (Convert.ToDateTime(value).DayOfWeek.ToString() =="Sunday");
            }
        }
        [Required(ErrorMessage = "Erreur!")]
        [RegularExpression(@"^[A-Z]\d[A-Z]\s\d[A-Z]\d$", ErrorMessage = "La valeur n'est pas valide pour le code postal")]
        public string codePostal { get; set; }

        [Required(ErrorMessage = "Erreur!")]
        [RegularExpression(@"^[A-Za-z]{1,3}\.[A-Za-z]{2,}$", ErrorMessage = "La valeur n'est pas valide pour le courriel")]
        public string courriel { get; set; }


        //[CustomSemaineComplete(ErrorMessage = "Le nombre d'heures travaillées doit être de 0 à 29,99 ou de 0 à 23.99")] 
        [Required(ErrorMessage = "Erreur!")]
        [RegularExpression(@"^\d+([\.\,]?\d+)?$", ErrorMessage = "La valeur n'est pas valide")]
        [Range(0, 23.99, ErrorMessage = "Le nombre d'heures travaillées doit être de 0 à 29,99 ou de 0 à 23.99")]
        //[Range("2","5", ErrorMessage = "Le nombre d'heures travaillées doit être de 0 à 29,99 ou de 0 à 23.99")]
        public double dimanche { get; set; }

        [Required(ErrorMessage = "Erreur!")]
        [Range(0, 23.99, ErrorMessage = "Le nombre d'heures travaillées doit être de 0 à 29,99 ou de 0 à 23.99")]
        public double lundi { get; set; }

        [Required(ErrorMessage = "Erreur!")]
        [Range(0, 23.99, ErrorMessage = "Le nombre d'heures travaillées doit être de 0 à 29,99 ou de 0 à 23.99")]
        public double mardi { get; set; }

        [Required(ErrorMessage = "Erreur!")]
        [Range(0, 23.99, ErrorMessage = "Le nombre d'heures travaillées doit être de 0 à 29,99 ou de 0 à 23.99")]
        public double mercredi { get; set; }

        [Required(ErrorMessage = "Erreur!")]
        [Range(0, 23.99, ErrorMessage = "Le nombre d'heures travaillées doit être de 0 à 29,99 ou de 0 à 23.99")]
        public double jeudi { get; set; }

        [Required(ErrorMessage = "Erreur!")]
        [Range(0, 23.99, ErrorMessage = "Le nombre d'heures travaillées doit être de 0 à 29,99 ou de 0 à 23.99")]
        public double vendredi { get; set; }

        [Required(ErrorMessage = "Erreur!")]
        [Range(0, 23.99, ErrorMessage = "Le nombre d'heures travaillées doit être de 0 à 29,99 ou de 0 à 23.99")]
        public double samedi { get; set; }

       /*internal class CustomSemaineCompleteAttribute : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                return (Convert.ToDateTime(value).DayOfWeek.ToString() == "Sunday");
            }
        }*/


    }
}