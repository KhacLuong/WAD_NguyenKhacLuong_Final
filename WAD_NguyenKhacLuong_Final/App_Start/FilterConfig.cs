using System.Web;
using System.Web.Mvc;

namespace WAD_NguyenKhacLuong_Final
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
