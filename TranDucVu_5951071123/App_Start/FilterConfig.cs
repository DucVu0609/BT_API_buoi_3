using System.Web;
using System.Web.Mvc;

namespace TranDucVu_5951071123
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
