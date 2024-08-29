using HPlus.Ecommerce.Filters;

using System.Web.Mvc;

namespace HPlus.Ecommerce
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //Changed this to my own custom one
            filters.Add(new CustomExceptionHandler());
            //My custom filter
            filters.Add(new LogRequestFilter());
        }
    }
}
