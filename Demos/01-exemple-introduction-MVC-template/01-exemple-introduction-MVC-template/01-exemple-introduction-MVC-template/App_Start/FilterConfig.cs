using System.Web;
using System.Web.Mvc;

namespace _01_exemple_introduction_MVC_template
{
   public class FilterConfig
   {
      public static void RegisterGlobalFilters(GlobalFilterCollection filters)
      {
         filters.Add(new HandleErrorAttribute());
      }
   }
}
