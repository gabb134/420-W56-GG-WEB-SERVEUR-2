using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _02_Demo.Models
{
   public class ModeleFormulaire
   {
      [Display(Name = "Text")]
      [DataType(DataType.Text)]
      public string Text { get; set; }

      [Display(Name = "TextArea")]
      [DataType(DataType.MultilineText)]
      public string MultiLineText { get; set; }

      [Display(Name = "Number")]
      public int Number { get; set; }

      [Display(Name = "Decimal")]
      [UIHint("Decimal")]
      public double Decimal { get; set; }

      [Display(Name = "Tel")]
      [DataType(DataType.PhoneNumber)]
      public string Tel { get; set; }

      [Display(Name = "Date")]
      [DataType(DataType.Date)]
      public DateTime Date { get; set; }

      [Display(Name = "Time")]
      [DataType(DataType.Time)]
      public DateTime Time { get; set; }

      [Display(Name = "HiddenInput")]
      [UIHint("HiddenInput")]
      public string HiddenInput { get; set; }

      [Display(Name = "Boolean")]
      [UIHint("Boolean")]
      public bool Boolean { get; set; }

      [Display(Name = "Email")]
      [DataType(DataType.EmailAddress)]
      public string Email { get; set; }

      [Display(Name = "Url")]
      [DataType(DataType.Url)]
      public string Url { get; set; }
      [Display(Name = "Password")]
      [DataType(DataType.Password)]
      public string Password { get; set; }

      [Display(Name = "Currency")]
      [DataType(DataType.Currency)]
      public double Currency { get; set; }

      [Display(Name = "CreditCard")]
      [DataType(DataType.CreditCard)]
      public string CreditCard { get; set; }

      // constructeur
      public ModeleFormulaire()
      {
         Text = "tra la la";
         MultiLineText = "ligne1\nligne2";
         Number = 4;
         Decimal = 10.2;
         Tel = "0617181920";
         Date = DateTime.Now;
         Time = DateTime.Now;
         HiddenInput = "caché";
         Boolean = true;
         Email = "x@y.z";
         Url = "http://istia.univ-angers.fr";
         Password = "mdp";
         Currency = 4.2;
         CreditCard = "0123456789012345";
      }
   }
}