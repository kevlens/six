using System.Web;
using System.Web.Mvc;
using Web.Areas.Filters;

namespace Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new LoginValidateAttribute());
            filters.Add(new HandleErrorAttribute());
        }
    }
}