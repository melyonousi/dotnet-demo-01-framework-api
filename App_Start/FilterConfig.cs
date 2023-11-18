using System.Web;
using System.Web.Mvc;

namespace dotnet_demo_framework_api_04
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
