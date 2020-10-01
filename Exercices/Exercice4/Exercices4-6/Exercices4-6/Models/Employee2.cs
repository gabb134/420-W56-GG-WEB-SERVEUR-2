using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercices4_6.Models
{
    public class Employee2
    {
        [Required(ErrorMessage = "Absent !")]
        [Range(30000, 50000, ErrorMessage = "Plage !")]
        [RegularExpression(@"^\d{5,6}$", ErrorMessage = "Format !")]
        public int noEmploye { get; set; }

        [Required(ErrorMessage = "Absent !")]
        public string ddlDepartement { get; set; }


        [Required(ErrorMessage = "Absent !")]
        [RegularExpression(@"^\d{3}\s\d{3}", ErrorMessage = "Format !")]
        public string nas { get; set; }

        [Required(ErrorMessage = "Absent !")]
        [DataType(DataType.Date, ErrorMessage = "Format !")]
        [CustomDateDimanche(ErrorMessage = "La date doit être un dimanche")]
        [Range(typeof(DateTime), "2011/01/02", "2020/08/31", ErrorMessage = "Erreur!")]

        public DateTime dateSemaine { get; set; }

        //^\d{3}\s\d{3}$
        internal class CustomDateDimancheAttribute : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                return (Convert.ToDateTime(value).DayOfWeek.ToString() == "Sunday");
            }
        }
        [Required(ErrorMessage = "Absent !")]
        [RegularExpression(@"^[A-Z]\d[A-Z]\s\d[A-Z]\d$", ErrorMessage = "Format !")]
        public string codePostal { get; set; }

        [Required(ErrorMessage = "Absent !")]
        [RegularExpression(@"^[A-Za-z]{1,3}\.[A-Za-z]{2,}$", ErrorMessage = "Format !")]
        public string courriel { get; set; }


        //[CustomSemaineComplete(ErrorMessage = "Le nombre d'heures travaillées doit être de 0 à 29,99 ou de 0 à 23.99")] 
        [Required(ErrorMessage = "Absent !")]
        [RegularExpression(@"[\d]{1,2}([.,][\d]{1,2})?", ErrorMessage = "Format !")]
        [Range(0, 24, ErrorMessage = "Invalide !")]
        [CustomSemaineQuartHeure(ErrorMessage = "Invalide !")]
        //[Range("2","5", ErrorMessage = "Le nombre d'heures travaillées doit être de 0 à 29,99 ou de 0 à 23.99")]
        public double dimanche { get; set; }

        [Required(ErrorMessage = "Absent !")]
        [RegularExpression(@"[\d]{1,2}([.,][\d]{1,2})?", ErrorMessage = "Format !")]
        [Range(0, 24, ErrorMessage = "Invalide !")]
        [CustomSemaineQuartHeure(ErrorMessage = "Invalide !")]
        public double lundi { get; set; }

        [Required(ErrorMessage = "Absent !")]
        [RegularExpression(@"[\d]{1,2}([.,][\d]{1,2})?", ErrorMessage = "Format !")]
        [Range(0, 24, ErrorMessage = "Invalide !")]
        [CustomSemaineQuartHeure(ErrorMessage = "Invalide !")]
        public double mardi { get; set; }

        [Required(ErrorMessage = "Absent !")]
        [RegularExpression(@"[\d]{1,2}([.,][\d]{1,2})?", ErrorMessage = "Format !")]
        [Range(0, 24, ErrorMessage = "Invalide !")]
        [CustomSemaineQuartHeure(ErrorMessage = "Invalide !")]
        public double mercredi { get; set; }

        [Required(ErrorMessage = "Absent !")]
        [RegularExpression(@"[\d]{1,2}([.,][\d]{1,2})?", ErrorMessage = "Format !")]
        [Range(0, 24, ErrorMessage = "Invalide !")]
        [CustomSemaineQuartHeure(ErrorMessage = "Invalide !")]
        public double jeudi { get; set; }

        [Required(ErrorMessage = "Absent !")]
        [RegularExpression(@"[\d]{1,2}([.,][\d]{1,2})?", ErrorMessage = "Format !")]
        [Range(0, 24, ErrorMessage = "Invalide !")]
        [CustomSemaineQuartHeure(ErrorMessage = "Invalide !")]
        public double vendredi { get; set; }

        [Required(ErrorMessage = "Absent !")]
        [RegularExpression(@"[\d]{1,2}([.,][\d]{1,2})?", ErrorMessage = "Format !")]
        [Range(0, 24, ErrorMessage = "Invalide !")]
        [CustomSemaineQuartHeure(ErrorMessage = "Invalide !")]
        public double samedi { get; set; }

        internal class CustomSemaineQuartHeureAttribute : ValidationAttribute
         {
             public override bool IsValid(object value)
             {

                //   return (Convert.ToDateTime(value).DayOfWeek.ToString() == "Sunday");

                return (Convert.ToDouble(value)% 0.25 == 0);
             }
         }


    }
}