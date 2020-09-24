using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_Demo.Controllers
{
    public class DropDownListController : Controller
    {
      // GET: DropDownList
         List<SelectListItem> mySkills = new List<SelectListItem>() {
           new SelectListItem {
               Text = "ASP.NET MVC", Value = "1"
           },
           new SelectListItem {
               Text = "ASP.NET WEB API", Value = "2"
           },
           new SelectListItem {
               Text = "ENTITY FRAMEWORK", Value = "3"
           },
           new SelectListItem {
               Text = "DOCUSIGN", Value = "4"
           },
           new SelectListItem {
               Text = "ORCHARD CMS", Value = "5"
           },
           new SelectListItem {
               Text = "JQUERY", Value = "6"
           },
           new SelectListItem {
               Text = "ZENDESK", Value = "7"
           },
           new SelectListItem {
               Text = "LINQ", Value = "8"
           },
           new SelectListItem {
               Text = "C#", Value = "9"
           },
           new SelectListItem {
               Text = "GOOGLE ANALYTICS", Value = "10"
           },
         };
         public ActionResult Index()
        {
           
            ViewBag.MySkills = mySkills;         
            ViewData["MySkills"] = mySkills;
            TempData["MySkills"] = mySkills;
            var myskill = new List<ConvertEnum>();
            foreach (MySkills lang in Enum.GetValues(typeof(MySkills)))
               myskill.Add(new ConvertEnum
               {
                  Value = (int)lang,
                  Text = lang.ToString()
               });
            ViewBag.MySkillEnum = myskill;
            return View();
        }

         public struct ConvertEnum
         {
            public int Value
            {
               get;
               set;
            }
            public String Text
            {
               get;
               set;
            }
         }
         public enum MySkills
         {
            ASPNETMVC,
            ASPNETWEPAPI,
            CSHARP,
            DOCUSIGN,
            JQUERY
         }
   }
}