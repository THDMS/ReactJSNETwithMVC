using System.Web;
using System.Web.Mvc;

namespace ReactJSNETwithMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());  
            //this is where i add more tests
        }
    }
}