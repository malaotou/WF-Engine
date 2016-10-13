using System.Web;
using System.Web.Mvc;

namespace BOC.GSP.V2.WF.WebApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
