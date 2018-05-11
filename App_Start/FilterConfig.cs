using System.Web;
using System.Web.Mvc;

namespace backEnd_lista_telefonica_angular
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
