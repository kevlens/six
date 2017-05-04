using System.Web;
using System.Web.Mvc;
using SxShWeb.Areas.Filters;

namespace SxShWeb
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