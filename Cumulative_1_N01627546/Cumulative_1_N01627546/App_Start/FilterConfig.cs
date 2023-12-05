using System.Web;
using System.Web.Mvc;

namespace Cumulative_1_N01627546
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
