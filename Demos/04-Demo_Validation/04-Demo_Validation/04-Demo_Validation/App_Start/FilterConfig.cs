using System.Web;
using System.Web.Mvc;

namespace _04_Demo_Validation
{
   public class FilterConfig
   {
      public static void RegisterGlobalFilters(GlobalFilterCollection filters)
      {
         filters.Add(new HandleErrorAttribute());
      }
   }
}
