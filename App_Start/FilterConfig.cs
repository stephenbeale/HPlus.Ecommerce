using HPlus.Ecommerce.Filters;

using System.Web.Mvc;

namespace HPlus.Ecommerce
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //Built-in exception filter
            filters.Add(new HandleErrorAttribute());
            //My custom filter
            filters.Add(new LogRequestFilter());
        }
    }
}
