using System.Web;
using System.Web.Mvc;

namespace _06_DemoEmployeeEntityFramework
{
   public class FilterConfig
   {
      public static void RegisterGlobalFilters(GlobalFilterCollection filters)
      {
         filters.Add(new HandleErrorAttribute());
      }
   }
}
